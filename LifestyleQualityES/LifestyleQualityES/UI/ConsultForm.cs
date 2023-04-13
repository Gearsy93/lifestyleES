using LifestyleQualityES.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LifestyleQualityES
{
    internal partial class formConsult : Form
    {
        private KnowledgeBase _knowledgeBase;
        public WorkingMemory _workingMemory;
        private LogicalInferenceMechanism _inference;
        Thread deduceThread;
        public List<string> answers;
        public List<string> shellAnswers;
        public string selectedAnswer;
        private int currentMessage = 0;
        public bool deduceStopped = true;
        public ExplanationComponent explanationComponent;

        public static ManualResetEvent autoEvent = new ManualResetEvent(false);

        public formConsult(KnowledgeBase knowledgeBase, WorkingMemory workingMemory)
        {
            InitializeComponent();
            this._knowledgeBase = knowledgeBase;
            this._workingMemory = workingMemory;
            answers = new List<string>();
            shellAnswers = new List<string>();
            foreach (Variable variable in knowledgeBase.Variables) 
            {
                if (variable.GetType() == typeof(DeducibleVariable) || variable.GetType() == typeof(DeducibleAskedVariable))
                {
                    answers.Add(variable.Name);
                }
            }

            foreach (string ans in answers)
            {
                cbAnswers.Items.Add(ans);
            }
            cbAnswers.SelectedIndex = cbAnswers.Items.Count - 1;
        }

        private Label CreateMessageCloud(string message)
        {
            Label label = new Label();
            label.Text = message;
            label.Dock = DockStyle.Fill;
            label.AutoSize = true;
            label.Size = new System.Drawing.Size(1200, 26);
            label.Font = new Font("Montserrat", 9, FontStyle.Regular);
            tlpMessages.RowCount++;
            return label;
        }

        private void ShowMessage(Label label, bool isLeft)
        {
            tlpMessages.Controls.Add(label, isLeft ? 0 : 1, currentMessage);
            tlpMessages.GetControlFromPosition(isLeft ? 0 : 1, currentMessage).BackColor = Color.FromArgb(isLeft ? 206 : 201, isLeft ? 251 : 255, isLeft ? 255 : 222);
            tlpMessages.GetControlFromPosition(isLeft ? 0 : 1, currentMessage).Margin = new Padding(0, 5, 5, 0);
            tlpMessages.GetControlFromPosition(isLeft ? 0 : 1, currentMessage).Padding = new Padding(5);
            flpChat.ScrollControlIntoView(label);
            currentMessage++;
        }

        private void ShowButtons()
        {
            btNewConsult.Visible = true;
            btShowExplanation.Visible = true;
        }

        private void HideButtons()
        {
            btNewConsult.Visible = false;
            btShowExplanation.Visible = false;
        }

        private void btNewConsult_Click(object sender, EventArgs e)
        {
            if (cbAnswers.SelectedIndex >= 0)
            {
                _workingMemory = new WorkingMemory(this._knowledgeBase);
                this._inference = new LogicalInferenceMechanism(_workingMemory, this, _knowledgeBase);
                answers.Clear();
                shellAnswers.Clear();
                cbAnswers.Text = "";
                currentMessage = 0;
                autoEvent = new ManualResetEvent(false);
                deduceStopped = false;
                HideButtons();
                tlpMessages.Controls.Clear();
                tlpMessages.RowCount = 0;
                tlpMessages.RowStyles.Clear();
                KnowledgeAcquisitionComponent kAC = new KnowledgeAcquisitionComponent(ref _knowledgeBase);
                Variable goalVariable = kAC.GetVariableByName(cbAnswers.SelectedItem.ToString());
                _inference.goalVariable = goalVariable;
                int answerCount = shellAnswers.Count;
                deduceThread = new Thread(goalVariable => _inference.DeduceVariable((Variable)goalVariable));
                deduceThread.Start(goalVariable);
                while (answerCount == shellAnswers.Count && deduceThread.IsAlive);
                if (shellAnswers.Count == 0)
                {
                    ShowMessage(CreateMessageCloud("Консультация не была завершена успешно!\n"), true);
                    tlpMessages.GetControlFromPosition(0, currentMessage - 1).BackColor = Color.FromArgb(255, 0, 0);

                    btReply.Enabled = false;
                    btShowExplanation.Enabled = true;
                    deduceStopped = true;
                    cbAnswers.Items.Clear();
                    cbAnswers.Text = "";
                    answers.Clear();
                    ShowButtons();
                    foreach (Variable variable in _knowledgeBase.Variables)
                    {
                        if (variable.GetType() == typeof(DeducibleVariable) || variable.GetType() == typeof(DeducibleAskedVariable))
                        {
                            answers.Add(variable.Name);
                        }
                    }
                    foreach (string ans in answers)
                    {
                        cbAnswers.Items.Add(ans);
                    }
                    cbAnswers.SelectedIndex = cbAnswers.Items.Count - 1;
                    return;
                }
                ShowMessage(CreateMessageCloud(shellAnswers[shellAnswers.Count - 1]), true);
                cbAnswers.Items.Clear();
                foreach (string ans in answers)
                {
                    cbAnswers.Items.Add(ans);
                }
                cbAnswers.SelectedIndex = 0;
            }
        }

        private void cbAnswers_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btReply_Click(object sender, EventArgs e)
        {
            
            if (!deduceStopped)
            {
                if (cbAnswers.SelectedIndex > -1)
                {
                    int answerCount = shellAnswers.Count;                      
                    selectedAnswer = cbAnswers.SelectedItem.ToString();
                    autoEvent.Set();
                    autoEvent.Reset();
                    ShowMessage(CreateMessageCloud(cbAnswers.SelectedItem.ToString()), false);
                    while (answerCount == shellAnswers.Count && deduceThread.IsAlive);
                    if (!deduceThread.IsAlive)
                    {
                        btReply.Enabled = false;
                        btShowExplanation.Enabled = true;
                        deduceStopped = true;
                        cbAnswers.Items.Clear();
                        cbAnswers.Text = "";
                        answers.Clear();
                        bool found = false;
                        this.explanationComponent = new ExplanationComponent(_workingMemory);
                        explanationComponent.CreateTree(_inference.goalVariable);
                        foreach (var value in _workingMemory.DeducedFacts)
                        {
                            if (value.Variable == _inference.goalVariable)
                            {
                                ShowMessage(CreateMessageCloud("Консультация завершена успешно!\n" + value.PremiseToString()), true);
                                tlpMessages.GetControlFromPosition(0, currentMessage - 1).BackColor = Color.FromArgb(0, 255, 0);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            ShowMessage(CreateMessageCloud("Консультация не была завершена успешно!\n"), true);
                            tlpMessages.GetControlFromPosition(0, currentMessage - 1).BackColor = Color.FromArgb(255, 0, 0);
                        }
                        ShowButtons();
                        foreach (Variable variable in _knowledgeBase.Variables)
                        {
                            if (variable.GetType() == typeof(DeducibleVariable) || variable.GetType() == typeof(DeducibleAskedVariable))
                            {
                                answers.Add(variable.Name);
                            }
                        }

                        foreach (string ans in answers)
                        {
                            cbAnswers.Items.Add(ans);
                        }
                        cbAnswers.SelectedIndex = cbAnswers.Items.Count - 1;
                    }
                    else
                    {
                        ShowMessage(CreateMessageCloud(shellAnswers[shellAnswers.Count - 1]), true);
                        cbAnswers.Items.Clear();
                        foreach (string ans in answers)
                        {
                            cbAnswers.Items.Add(ans);
                        }
                        cbAnswers.SelectedIndex = 0;
                    }
                    
                }
            }
        }

        private void btShowExplanation_Click(object sender, EventArgs e)
        {
            // Добавить проверку на выведенный treenode
            if (_workingMemory != null && explanationComponent != null)
            {
                var explanationForm = new formExplanation(_workingMemory, explanationComponent);
                explanationForm.ShowDialog();
                
            }
        }

        private void cbAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnswers.SelectedIndex >= 0)
            {
                btNewConsult.Enabled = true;
                if (deduceThread != null && deduceThread.IsAlive)
                {
                    btReply.Enabled = true;
                }
            }
            else
            {
                btNewConsult.Enabled = false;
                if (deduceThread != null && deduceThread.IsAlive)
                {
                    btReply.Enabled = false;
                }
            }
        }

        private void formConsult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btReply.Enabled)
                {
                    btReply_Click(sender, e);
                }
            }
        }
    }
}
