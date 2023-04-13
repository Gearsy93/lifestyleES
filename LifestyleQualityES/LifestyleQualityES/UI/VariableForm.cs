using LifestyleQualityES.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LifestyleQualityES.Model.KnowledgeAcquisitionComponent;

namespace LifestyleQualityES
{
    
    internal partial class formVariable : Form
    {
        private int _selectedIndex;
        public VarType _varType;
        private Operation _operation;
        public KnowledgeAcquisitionComponent _kAC;
        private Variable _updateVariable;
        public formVariable(KnowledgeAcquisitionComponent _kAC, Operation operation)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this._operation = operation;
            _selectedIndex = -1;
            this.Text = "Добавление переменной";
            FillDomainValues(_kAC._knowledgeBase.Domains);
        }

        public formVariable(KnowledgeAcquisitionComponent _kAC, Operation operation, int index)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this._operation = operation;
            this.Text = "Обновление переменной";
            this._selectedIndex = index;
            FillDomainValues(_kAC._knowledgeBase.Domains);
            _updateVariable = _kAC._knowledgeBase.Variables[index];
            tbVariableName.Text = _kAC._knowledgeBase.Variables[index].Name;
            cbDomainList.SelectedIndex = cbDomainList.FindString(_kAC._knowledgeBase.Variables[index].Domain.Name);
            if (_kAC._knowledgeBase.Variables[index].GetType() == typeof(AskedVariable))
            {
                rbRequested.Checked = true;
                rtbQuestionText.Text = ((AskedVariable)_kAC._knowledgeBase.Variables[index]).Question;
            }
            else if (_kAC._knowledgeBase.Variables[index].GetType() == typeof(DeducibleVariable))
            {
                rbOutput.Checked = true;
            }
            else
            {
                rbRequestedOutput.Checked = true;
                rtbQuestionText.Text = ((DeducibleAskedVariable)_kAC._knowledgeBase.Variables[index]).Question;
            }

        }

        public void FillDomainValues(List<Domain> domains)
        {
            cbDomainList.Items.Clear();
            foreach (Domain domain in domains)
            {
                cbDomainList.Items.Add(domain.Name.ToString());
            }
        }

        private void btAddDomain_Click(object sender, EventArgs e)
        {
            var domainForm = new formDomain(_kAC, Operation.Add);
            if (domainForm.ShowDialog() == DialogResult.OK)
            {
                FillDomainValues(_kAC._knowledgeBase.Domains);
                if (_kAC._knowledgeBase.Domains.Count != 0)
                {
                    cbDomainList.SelectedIndex = cbDomainList.Items.Count - 1;
                }
            }
        }

        private void rbRequested_CheckedChanged(object sender, EventArgs e)
        {
            rtbQuestionText.Enabled = true;
        }

        private void rbOutput_CheckedChanged(object sender, EventArgs e)
        {
            rtbQuestionText.Enabled = false;
        }

        private void rbRequestedOutput_CheckedChanged(object sender, EventArgs e)
        {
            rtbQuestionText.Enabled = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbVariableName.Text == "")
            {
                MessageBox.Show("Пустое имя переменной");
                return;
            }
            if (cbDomainList.SelectedItem == null)
            {
                MessageBox.Show("Домен не выбран");
                return;
            }
            Domain domain = _kAC._knowledgeBase.GetDomainByName(cbDomainList.SelectedItem.ToString());
            if (domain == null)
            {
                MessageBox.Show("Домен с данным именем не найден");
                return;
            }

            VarType varType;
            if (rbRequested.Checked == true)
            {
                varType = VarType.Asked;
            }
            else if (rbOutput.Checked == true)
            {
                varType = VarType.Deducible;
            }
            else if (rbRequestedOutput.Checked == true)
            {
                varType = VarType.DeducibleAsked;
            }
            else
            {
                MessageBox.Show("Тип переменной не выбран");
                return;
            }

            string question = rtbQuestionText.Text;
            if (varType != VarType.Deducible && question == "")
            {
                question = "Значение переменной " + tbVariableName.Text + "?";
            }

            if (tbVariableName.Text.Contains(","))
            {
                MessageBox.Show("Имя переменной содержит недопустимый символ ','");
                return;
            }

            
            if (_operation == Operation.Add)
            {
                if (_kAC.VariableContains(tbVariableName.Text))
                {
                    MessageBox.Show("Данное имя переменной уже существует");
                    return;
                }

                _kAC.AddVariable(tbVariableName.Text, domain, varType, question);
            }
            else
            {
                foreach(Variable variable in _kAC._knowledgeBase.Variables) 
                {
                    if (variable.Name == tbVariableName.Text && variable != _updateVariable)
                    {
                        MessageBox.Show("Данное имя переменной уже существует");
                        return;
                    }    
                }
                _kAC.UpdateVariable(_selectedIndex, tbVariableName.Text, domain, varType, question);
            }

            _varType = varType;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
