using LifestyleQualityES.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static LifestyleQualityES.Model.KnowledgeAcquisitionComponent;

namespace LifestyleQualityES.UI
{
    internal partial class ConclusionForm : Form
    {
        public Variable _variable;
        public DomainValue _variableValue;
        public KnowledgeAcquisitionComponent _kAC;

        public ConclusionForm(KnowledgeAcquisitionComponent _kAC, string variableName, string variableValue)
        {
            InitializeComponent();
            this._kAC = _kAC;
            FillVariables();
            if (variableName != "")
            {
                _variable = _kAC.GetVariableByName(variableName);
                _variableValue = _variable.Domain.GetValueByString(variableValue);
                foreach (var variable in cbVariables.Items)
                {
                    if (variable.ToString() == variableName)
                    {
                        cbVariables.SelectedItem = variable;
                        break;
                    }
                }
                FillDomain(_variableValue.Domain);
                foreach(var value in cbValues.Items)
                {
                    if (_variableValue.Value.ToString() == value.ToString())
                    {
                        cbValues.SelectedItem = value;
                        break;
                    }
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (cbVariables.SelectedIndex == -1)
            {
                MessageBox.Show("Переменная не выбрана");
                return;
            }
            if (cbValues.SelectedIndex == -1) 
            {
                MessageBox.Show("Значение переменной не выбрано");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCreateVariable_Click(object sender, EventArgs e)
        {
            var formVariable = new formVariable(_kAC, Operation.Add);
            if (formVariable.ShowDialog() == DialogResult.OK && formVariable._varType != VarType.Asked)
            {
                FillVariables();
                cbVariables.SelectedIndex = cbVariables.Items.Count - 1;
            }
        }

        public void FillVariables()
        {
            cbVariables.Items.Clear();
            foreach (Variable variable in _kAC._knowledgeBase.Variables)
            {
                if (variable.GetType() == typeof(DeducibleVariable) || variable.GetType() == typeof(DeducibleAskedVariable))
                {
                    cbVariables.Items.Add(variable.Name);
                }
            }
        }

        public void FillDomain(Domain domain)
        {
            cbValues.Items.Clear();
            foreach(var domainValue in domain.Values)
            {
                cbValues.Items.Add(domainValue.Value);
            }
        }

        private void cbVariables_SelectedValueChanged(object sender, EventArgs e)
        {
            _variable = _kAC.GetVariableByName(cbVariables.SelectedItem.ToString());
            FillDomain(_variable.Domain);
            cbValues.SelectedIndex = -1;
            cbValues.Text = "";
        }

        private void cbValues_SelectedValueChanged(object sender, EventArgs e)
        {
            _variableValue = _variable.Domain.GetValueByString(cbValues.SelectedItem.ToString());
        }
    }
}
