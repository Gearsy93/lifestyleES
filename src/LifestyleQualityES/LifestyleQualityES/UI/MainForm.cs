using LifestyleQualityES.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace LifestyleQualityES
{
    internal partial class formMainForm : Form
    {
        public KnowledgeBase _knowledgeBase;
        private KnowledgeAcquisitionComponent _knowledgeAcquisition;
        private string _fileName = null;
        private WorkingMemory _workingMemory;
        public ExplanationComponent explanationComponent;

        public formMainForm()
        {
            InitializeComponent();
            lvRules.ItemDrag += new ItemDragEventHandler(lvRules_ItemDrag);
            _knowledgeAcquisition = new KnowledgeAcquisitionComponent(ref _knowledgeBase);
        }

        public void Fill()
        {
            lvRules.Items.Clear();
            lvRulesPremises.Items.Clear();
            foreach (Rule rule in _knowledgeBase.Rules)
            {
                ListViewItem item = new ListViewItem();
                string explanation;
                if (rule.Explanation == "")
                {
                    explanation = rule.GenerateExplanation();
                }
                else explanation = rule.Explanation;
                item.SubItems.AddRange(new string[] { rule.Name, explanation });
                lvRules.Items.Add(item);
            }

            lvVariables.Items.Clear();
            rtbQuestionText.Text = "";
            lvVariablesDomainValues.Items.Clear();
            foreach (Variable variable in _knowledgeBase.Variables)
            {
                ListViewItem item = new ListViewItem();
                string type = "";
                if (variable.GetType() == typeof(AskedVariable))
                {
                    type = "Запрашиваемая";
                }
                else if (variable.GetType() == typeof(DeducibleVariable))
                {
                    type = "Выводимая";
                }
                else
                {
                    type = "Выводимо-запрашиваемая";
                }
                item.SubItems.AddRange(new string[] { variable.Name, type, variable.Domain.Name });
                lvVariables.Items.Add(item);
            }

            lvDomains.Items.Clear();
            lvDomainValues.Items.Clear();
            foreach (Domain domain in _knowledgeBase.Domains)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(domain.Name);
                lvDomains.Items.Add(item);
            }

        }

        #region ToolStripMenu

        private void mstOpen_Click(object sender, EventArgs e)
        {
            var loadResult = IO.LoadFromFile();
            
            if (loadResult.Item1 != null)
            {
                this._knowledgeBase = loadResult.Item1;
                _knowledgeAcquisition._knowledgeBase = loadResult.Item1;
                Fill();
                this._fileName = loadResult.Item2;
                mstSave.Enabled = true;
                mstSaveAs.Enabled = true;
                tbMain.Enabled = true;
                mstConsult.Enabled = true;
            }
        }

        private void mstNew_Click(object sender, EventArgs e)
        {
            var knowledgeBase = new KnowledgeBase();
            this._knowledgeBase = knowledgeBase;
            _knowledgeAcquisition._knowledgeBase = knowledgeBase;
            Fill();
            mstSaveAs.Enabled = true;
            tbMain.Enabled = true;
            mstConsult.Enabled = true;
        }

        private void mstSaveAs_Click(object sender, EventArgs e)
        {
            var result = IO.SaveNewFile(_knowledgeBase);
            if (result != null)
            {
                this._fileName = result;
                mstSave.Enabled = true;
            }
        }

        private void mstSave_Click(object sender, EventArgs e)
        {
            IO.ReWriteFile(this._fileName, this._knowledgeBase);
        }

        private void mstExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ItemClick

        private void lvRules_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lvRulesPremises.Items.Clear();
            foreach (Fact fact in _knowledgeBase.Rules[e.ItemIndex].Premise.Facts)
            {
                if (fact.GetType() == typeof(AdditiveFact))
                {
                    lvRulesPremises.Items.Add(((AdditiveFact)fact).PremiseToString());
                }
                else if (fact.GetType() == typeof(SingleFact))
                {
                    lvRulesPremises.Items.Add(((SingleFact)fact).Variable.Name.ToString() + " = " + ((SingleFact)fact).Value.Value.ToString());
                }
            }
        }

        private void lvVariables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            rtbQuestionText.Clear();
            lvVariablesDomainValues.Items.Clear();
            if (_knowledgeBase.Variables[e.ItemIndex].GetType() == typeof(AskedVariable))
            {
                rtbQuestionText.Text = ((AskedVariable)_knowledgeBase.Variables[e.ItemIndex]).Question;
            }
            else if (_knowledgeBase.Variables[e.ItemIndex].GetType() == typeof(DeducibleAskedVariable))
            {
                rtbQuestionText.Text = ((DeducibleAskedVariable)_knowledgeBase.Variables[e.ItemIndex]).Question;
            }
            foreach (var domainValue in _knowledgeBase.Variables[e.ItemIndex].Domain.Values)
            {
                lvVariablesDomainValues.Items.Add(domainValue.Value.ToString());
            }

        }

        private void lvDomains_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lvDomainValues.Items.Clear();
            foreach (var domainValue in _knowledgeBase.Domains[e.ItemIndex].Values)
            {
                lvDomainValues.Items.Add(domainValue.Value.ToString());
            }
        }

        #endregion

        #region ButtonClick

        #region Rules

        private void btAddRules_Click(object sender, EventArgs e)
        {
            var formRule = new formRule(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Add);
            formRule.ShowDialog();
            if (formRule.DialogResult == DialogResult.OK && lvRules.SelectedItems.Count > 0)
            {
                int insertIndex = lvRules.SelectedItems[0].Index;
                Rule rule = _knowledgeBase.Rules[_knowledgeBase.Rules.Count - 1];
                _knowledgeBase.Rules.RemoveAt(_knowledgeBase.Rules.Count - 1);
                _knowledgeBase.Rules.Insert(insertIndex + 1, rule);
            }
            Fill();
        }

        private void btEditRules_Click(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count == 0) return;
            var formRule = new formRule(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Update, lvRules.SelectedItems[0].Index);
            formRule.ShowDialog();
            Fill();
            btEditRules.Enabled = false;
            btDeleteRules.Enabled = false;
        }

        private void btDeleteRules_Click(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count == 0) return;
            _knowledgeAcquisition.DeleteRule(lvRules.SelectedItems[0].Index);
            Fill();
            btEditRules.Enabled = false;
            btDeleteRules.Enabled = false;
        }

        #endregion

        #region Variables

        private void btAddVariables_Click(object sender, EventArgs e)
        {
            var formVar = new formVariable(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Add);
            formVar.ShowDialog();
            Fill();
        }

        private void btEditVariables_Click(object sender, EventArgs e)
        {
            if (lvVariables.SelectedItems.Count == 0) return;
            var formVar = new formVariable(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Update, lvVariables.SelectedItems[0].Index);
            formVar.ShowDialog();
            Fill();
            btEditVariables.Enabled = false;
        }

        private void btDeleteVariables_Click(object sender, EventArgs e)
        {
            if (lvVariables.SelectedItems.Count == 0) return;
            Variable variable = _knowledgeBase.Variables[lvVariables.SelectedItems[0].Index];
            foreach (Rule rule in _knowledgeAcquisition._knowledgeBase.Rules)
            {
                if (rule.Conclusion.Variable == variable)
                {
                    MessageBox.Show("Эта переменная уже используется в правиле");
                    return;
                }
                foreach (Fact fact in rule.Premise.Facts)
                {
                    if (fact.GetType() == typeof(SingleFact))
                    {
                        if (((SingleFact)fact).Variable == variable)
                        {
                            MessageBox.Show("Эта переменная уже используется в правиле");
                            return;
                        }
                    }
                    else
                    {
                        foreach (Variable factVar in ((AdditiveFact)fact).Variables)
                        {
                            if (factVar ==  variable)
                            {
                                MessageBox.Show("Эта переменная уже используется в правиле");
                                return;
                            }
                        }
                    }
                }
            }

            _knowledgeAcquisition.DeleteVariable(lvVariables.SelectedItems[0].Index);
            Fill();
            btEditVariables.Enabled = false;
        }

        #endregion

        #region Domains

        private void btAddDomains_Click(object sender, EventArgs e)
        {
            var domainForm = new formDomain(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Add);
            domainForm.ShowDialog(); 
            Fill();
        }

        private void btEditDomains_Click(object sender, EventArgs e)
        {
            if (lvDomains.SelectedItems.Count == 0) return;
            var domainForm = new formDomain(_knowledgeAcquisition, KnowledgeAcquisitionComponent.Operation.Update, lvDomains.SelectedItems[0].Index);
            domainForm.ShowDialog();
            Fill();
            btEditDomains.Enabled = false;
            btDeleteDomains.Enabled = false;
        }

        private void btDeleteDomains_Click(object sender, EventArgs e)
        {
            if (lvDomains.SelectedItems.Count == 0) return;

            _knowledgeAcquisition.DeleteDomain(lvDomains.SelectedItems[0].Index);
            Fill();
            btEditDomains.Enabled = false;
            btDeleteDomains.Enabled = false;
        }

        #endregion

        #endregion

        private void mstBeginConsult_Click(object sender, EventArgs e)
        {
            var formConsult = new formConsult(_knowledgeBase, _workingMemory);
            formConsult.ShowDialog();
            this._workingMemory = formConsult._workingMemory;
            this.explanationComponent = formConsult.explanationComponent;
            mstShowExplanation.Enabled = true;
        }

        private void lvRules_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvRules.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvRules_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = lvRules.InsertionMark.Index;

            if (targetIndex == -1)
            {
                return;
            }
            if (lvRules.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));
   
            Rule rule = _knowledgeBase.Rules[draggedItem.Index];
            _knowledgeBase.Rules.Insert(targetIndex, rule);
            if (draggedItem.Index > targetIndex)
            {
                _knowledgeBase.Rules.RemoveAt(draggedItem.Index + 1);
            }
            else
            {
                _knowledgeBase.Rules.RemoveAt(draggedItem.Index);
            }
            Fill();
        }

        private void lvRules_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvRules_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint =
                lvRules.PointToClient(new Point(e.X, e.Y));

            int targetIndex = lvRules.InsertionMark.NearestIndex(targetPoint);

            if (targetIndex > -1)
            {
                Rectangle itemBounds = lvRules.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvRules.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvRules.InsertionMark.AppearsAfterItem = false;
                }
            }

            lvRules.InsertionMark.Index = targetIndex;
        }

        private void lvRules_DragLeave(object sender, EventArgs e)
        {
            lvRules.InsertionMark.Index = -1;
        }

        private void mstShowExplanation_Click(object sender, EventArgs e)
        {
            // Тоже добавить как параметр передачу компоненты пояснения
            if (_workingMemory != null && explanationComponent != null)
            {
                var explanationForm = new formExplanation(_workingMemory, explanationComponent);
                explanationForm.ShowDialog();

            }
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count > 0)
            {
                btEditRules.Enabled = true;
                btDeleteRules.Enabled = true;
            }
            else
            {
                btEditRules.Enabled = false;
                btDeleteRules.Enabled = false;
            }
        }

        private void lvVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVariables.SelectedItems.Count > 0)
            {
                btEditVariables.Enabled = true;
                btDeleteVariables.Enabled = true;
            }
            else
            {
                btEditVariables.Enabled = false;
                btDeleteVariables.Enabled = false;
            }
        }

        private void lvDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDomains.SelectedItems.Count > 0)
            {
                btEditDomains.Enabled = true;
                btDeleteDomains.Enabled = true;
            }
            else
            {
                btEditDomains.Enabled = false;
                btDeleteDomains.Enabled = false;
                lvDomainValues.Items.Clear();
            }
        }
    }
}
