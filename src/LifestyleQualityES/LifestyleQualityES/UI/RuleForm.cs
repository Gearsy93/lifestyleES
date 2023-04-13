using LifestyleQualityES.Model;
using LifestyleQualityES.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static LifestyleQualityES.Model.KnowledgeAcquisitionComponent;

namespace LifestyleQualityES
{
    internal partial class formRule : Form
    {
        private int _selectedIndex;
        private Operation _operation;
        private List<Fact> facts;
        private SingleFact _conslusion;
        private Rule _updateRule;
        public KnowledgeAcquisitionComponent _kAC;

        public formRule(KnowledgeAcquisitionComponent _kAC, Operation operation)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this._operation = operation;
            _selectedIndex = -1;
            this.facts = new List<Fact>();
            this.Text = "Добавление правила";
        }

        public formRule(KnowledgeAcquisitionComponent _kAC, Operation operation, int index)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this._operation = operation;
            this.Text = "Обновление правила";
            this._selectedIndex = index;
            this._updateRule = _kAC._knowledgeBase.Rules[index];
            this.facts = _updateRule.Premise.Facts;
            this._conslusion = _updateRule.Conclusion;
            rtbExplanation.Text = _updateRule.Explanation;
            tbRuleName.Text = _updateRule.Name;
            _ = _updateRule.Premise.FactOperator == FactOperator.Сonjunction ? rbAnd.Checked = true : rbOr.Checked = true;
            Fill();
        }

        public void Fill()
        {
            lvPremise.Items.Clear();
            if (_operation == Operation.Add)
            {
                foreach (Fact fact in facts)
                {
                    lvPremise.Items.Add(fact.PremiseToString());
                }
            }
            else
            {
                foreach (Fact fact in _kAC._knowledgeBase.Rules[_selectedIndex].Premise.Facts)
                {
                    lvPremise.Items.Add(fact.PremiseToString());
                } 
            }
            if (_conslusion != null)
            {
                tbConclusion.Text = _conslusion.Variable.Name + " = " + _conslusion.Value.Value;
            }
        }

        #region Premise

        private void btAddPremise_Click(object sender, EventArgs e)
        {
            var formFact = new formFactPremise(_kAC, _operation, Operation.Add);
            if (formFact.ShowDialog() == DialogResult.OK)
            {
                if (formFact.variables.Count == 1)
                {
                    facts.Add(new SingleFact(formFact.variables[0], formFact.resultValue));
                }
                else
                {
                    facts.Add(new AdditiveFact(formFact.variables, (NumericDomainValue)formFact.resultValue));
                }
                Fill();
            }
            
        }

        private void btEditPremise_Click(object sender, EventArgs e)
        {
            if (lvPremise.SelectedItems.Count == 0) return;
            var formFact = new formFactPremise(_kAC, _operation, Operation.Update, facts[lvPremise.SelectedItems[0].Index]);
            if (formFact.ShowDialog() == DialogResult.OK)
            {
                if (facts[lvPremise.SelectedItems[0].Index].GetType() == typeof(SingleFact))
                {
                    if (formFact.variables.Count == 1)
                    {
                        ((SingleFact)facts[lvPremise.SelectedItems[0].Index]).Variable = formFact.variables[0];
                        ((SingleFact)facts[lvPremise.SelectedItems[0].Index]).Value = formFact.resultValue;
                    }
                    else
                    {
                        int index = lvPremise.SelectedItems[0].Index;
                        facts.RemoveAt(lvPremise.SelectedItems[0].Index);
                        facts.Insert(index, new AdditiveFact(formFact.variables, (NumericDomainValue)formFact.resultValue));
                    }
                }
                else
                {
                    if (formFact.variables.Count == 1)
                    {
                        int index = lvPremise.SelectedItems[0].Index;
                        facts.RemoveAt(lvPremise.SelectedItems[0].Index);
                        facts.Insert(index, new SingleFact(formFact.variables[0], formFact.resultValue));
                    }
                    else
                    {
                        ((AdditiveFact)facts[lvPremise.SelectedItems[0].Index]).Variables = formFact.variables;
                        ((AdditiveFact)facts[lvPremise.SelectedItems[0].Index]).Value = (NumericDomainValue)formFact.resultValue;
                    }
                }
            }
            Fill();
            btEditPremise.Enabled = false;
            btDeletePremise.Enabled = false;
        }

        private void btDeletePremise_Click(object sender, EventArgs e)
        {
            if (lvPremise.SelectedItems.Count == 0) return;
            facts.RemoveAt(lvPremise.SelectedItems[0].Index);
            Fill();
            btEditPremise.Enabled = false;
            btDeletePremise.Enabled = false;
        }


        #endregion

        private void btEditConclusion_Click(object sender, EventArgs e)
        {
            ConclusionForm conclusionForm;
            if (_conslusion == null)
            {
                conclusionForm = new ConclusionForm(_kAC, "", "");
            }
            else
            {
                conclusionForm = new ConclusionForm(_kAC, _conslusion.Variable.Name, _conslusion.Value.Value);
            }
            conclusionForm.ShowDialog();
            
            if (conclusionForm.DialogResult == DialogResult.OK)
            {
                if (_conslusion == null)
                {
                    _conslusion = new SingleFact(conclusionForm._variable, conclusionForm._variableValue);
                }
                else
                {
                    _conslusion.Variable = conclusionForm._variable;
                    _conslusion.Value = conclusionForm._variableValue;
                }
            }
            Fill();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbRuleName.Text == "")
            {
                MessageBox.Show("Не задано имя правила");
                return;
            }
            if (lvPremise.Items.Count == 0)
            {
                MessageBox.Show("Посылка должно содержать минимум 1 факт");
                return;
            }
            if (rbAnd.Checked == false && rbOr.Checked == false)
            {
                MessageBox.Show("Не выбрано отношений фактов посылки");
                return;
            }
            if (_conslusion == null)
            {
                MessageBox.Show("Правило должно содержать заключение");
                return;
            }

            if (_operation == Operation.Add)
            {
                foreach (var rule in _kAC._knowledgeBase.Rules)
                {
                    if (rule.Name == tbRuleName.Text)
                    {
                        MessageBox.Show("Правило с таким именем уже существует");
                        return;
                    }
                }
                _kAC.AddRule(facts, rbAnd.Checked, tbRuleName.Text, _conslusion, rtbExplanation.Text);
            }
            else
            {
                foreach (var rule in _kAC._knowledgeBase.Rules)
                {
                    if (rule.Name == tbRuleName.Text && rule != this._updateRule)
                    {
                        MessageBox.Show("Правило с таким именем уже существует");
                        return;
                    }
                }
                _kAC.UpdateRule(facts, rbAnd.Checked, tbRuleName.Text, _conslusion, rtbExplanation.Text, _selectedIndex);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvPremise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPremise.SelectedItems.Count > 0)
            {
                btEditPremise.Enabled = true;
                btDeletePremise.Enabled = true;
            }
            else
            {
                btEditPremise.Enabled = false;
                btDeletePremise.Enabled = false;
            }
        }
    }
}
