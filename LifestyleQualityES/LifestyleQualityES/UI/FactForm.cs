using LifestyleQualityES.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static LifestyleQualityES.Model.KnowledgeAcquisitionComponent;

namespace LifestyleQualityES
{
    internal partial class formFactPremise : Form
    {
        public List<Variable> variables;
        public Fact fact;
        public DomainValue resultValue;
        public KnowledgeAcquisitionComponent _kAC;

        public formFactPremise(KnowledgeAcquisitionComponent _kAC, Operation ruleOperation, Operation factOperation)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this.Text = "Добавление факта посылки";
            variables = new List<Variable>();
            FillVariables();
        }

        public formFactPremise(KnowledgeAcquisitionComponent _kAC, Operation ruleOperation, Operation factOperation, Fact fact)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this.Text = "Обновление факта посылки";
            this.fact = fact;
            FillVariables();
            variables = new List<Variable>();
            if (fact.GetType() == typeof(SingleFact))
            {
                variables.Add(((SingleFact)fact).Variable);
                lvAdditive.Items.Add(((SingleFact)fact).Variable.Name);
                resultValue = ((SingleFact)fact).Value;
            }
            else
            {
                foreach (Variable variable in ((AdditiveFact)fact).Variables)
                {
                    variables.Add(variable);
                    lvAdditive.Items.Add(variable.Name);
                }
                resultValue = ((AdditiveFact)fact).Value;
            }
            cbValues.Items.Clear();
            foreach (DomainValue domainValue in variables[0].Domain.Values)
            {
                cbValues.Items.Add(domainValue.Value);
                if (domainValue.Value == resultValue.Value)
                {
                    cbValues.SelectedIndex = cbValues.Items.Count - 1;
                }
            }
        }

        public void FillVariables()
        {
            cbFacts.Items.Clear();
            foreach (Variable variable in _kAC._knowledgeBase.Variables)
            {
                cbFacts.Items.Add(variable.Name);
            }
        }

        private void btCreateVariable_Click(object sender, EventArgs e)
        {
            var formVariable = new formVariable(_kAC, Operation.Add);
            if (formVariable.ShowDialog() == DialogResult.OK)
            {
                FillVariables();
                cbFacts.SelectedIndex = cbFacts.Items.Count - 1;
            }
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbFacts.SelectedIndex == -1) return;
            string variableName = cbFacts.SelectedItem.ToString();
            Variable variable = _kAC.GetVariableByName(variableName);
            if (variable == null)
            {
                MessageBox.Show("Переменная не найдена в базе");
                return;
            }
            if (lvAdditive.Items.Count == 0)
            {
                lvAdditive.Items.Add(variableName);
                variables.Add(variable);
                cbValues.Items.Clear();
                foreach (DomainValue domainValue in variable.Domain.Values)
                {
                    cbValues.Items.Add(domainValue.Value);
                }
                
            }
            else
            {
                string firstListVarName = lvAdditive.Items[0].Text;
                Variable firstListVar = _kAC.GetVariableByName(firstListVarName);
                Domain firstListVarDomain = firstListVar.Domain;
                if (!firstListVarDomain.IsNumeric)
                {
                    MessageBox.Show("Аддитивные переменные должны быть числовыми");
                    return;
                }
                foreach (string varName in lvAdditive.Items.OfType<ListViewItem>().ToList().Select(x => x.Text).ToList())
                {
                    Variable variableLoc = _kAC.GetVariableByName(varName);
                    if(variableLoc.Domain != firstListVarDomain)
                    {
                        MessageBox.Show("Аддитивные переменные должны иметь одинаковый домен");
                        return;
                    }
                }
                if (variable.Domain != firstListVarDomain)
                {
                    MessageBox.Show("Добавляемая аддитивная переменная должна иметь такой же домен, как у уже добавленных переменных");
                    return;
                }
                lvAdditive.Items.Add(variableName);
                variables.Add(variable);
                cbValues.Items.Clear();
                foreach (DomainValue domainValue in firstListVarDomain.Values)
                {
                    cbValues.Items.Add(domainValue.Value);
                }
            }
            btAdd.Enabled = false;
        }

        private void btRemoveVariable_Click(object sender, EventArgs e)
        {
            if (lvAdditive.SelectedItems.Count == 0) return;
            string name = lvAdditive.SelectedItems[0].Text;
            lvAdditive.Items.RemoveAt(lvAdditive.SelectedItems[0].Index);
            variables.Remove(_kAC.GetVariableByName(name));
            if(lvAdditive.Items.Count == 0)
            {
                cbValues.SelectedIndex = -1;
            }
            btRemoveVariable.Enabled = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lvAdditive.Items.Count == 0)
            {
                MessageBox.Show("Факт должен содержать минимум 1 переменную");
                return;
            }
            if (cbValues.SelectedIndex == -1)
            {
                MessageBox.Show("Факт должен содержать значение переменной");
                return;
            }
            resultValue = variables[0].Domain.GetValueByString(cbValues.Items[cbValues.SelectedIndex].ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void cbFacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFacts.SelectedIndex >= 0)
            {
                btAdd.Enabled = true;
            }
            else
            {
                btAdd.Enabled = false; 
            }
        }

        private void lvAdditive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdditive.SelectedItems.Count > 0)
            {
                btRemoveVariable.Enabled = true;
            }
            else
            {
                btRemoveVariable.Enabled = false;
            }
        }
    }
}
