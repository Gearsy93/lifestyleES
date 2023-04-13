using LifestyleQualityES.Model;
using System.Drawing;
using System.Windows.Forms;

namespace LifestyleQualityES
{
    internal partial class formExplanation : Form
    {
        public WorkingMemory workingMemory;
        public formExplanation(WorkingMemory workingMemory, ExplanationComponent explanationComponent)
        {
            this.workingMemory = workingMemory;
            InitializeComponent();
            foreach (SingleFact singleFact in workingMemory.DeducedFacts)
            {
                ListViewItem item = new ListViewItem();
                string displayValue = singleFact.Value.Value;
                if (singleFact.Value.GetType() == typeof(NumericDomainValue))
                {
                    if (((NumericDomainValue)singleFact.Value).GetDoubleValue() == 1)
                    {
                        displayValue = "Да";
                    }
                    else if (((NumericDomainValue)singleFact.Value).GetDoubleValue() == 2)
                    {
                        displayValue = "Нет";
                    }
                }
                item.SubItems.AddRange(new string[] { singleFact.Variable.Name, displayValue });
                lvVariables.Items.Add(item);
                if (singleFact.Variable == explanationComponent.goalVariable)
                {
                    item.BackColor = Color.Green;
                    item.ForeColor = Color.White;
                }
            }
            if (explanationComponent != null)
            {
                tvRules.Nodes.Add((TreeNode)(explanationComponent.treeNode).Clone());
            }

        }

        private void llHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llHide.Text == "(раскрыть все)")
            {
                tvRules.ExpandAll();
                llHide.Text = "(свернуть все)";
            }
            else
            {
                tvRules.CollapseAll();
                llHide.Text = "(раскрыть все)";
            }
        }

        private void tvRules_AfterExpand(object sender, TreeViewEventArgs e)
        {
            llHide.Text = "(свернуть все)";
        }

        private void tvRules_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            llHide.Text = "(раскрыть все)";
        }
    }
}
