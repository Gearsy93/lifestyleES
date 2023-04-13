using LifestyleQualityES.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static LifestyleQualityES.Model.KnowledgeAcquisitionComponent;

namespace LifestyleQualityES
{
    internal partial class formDomain : Form
    {
        private int selectedIndex;
        private Operation operation;
        private Domain _updateDomain;
        public KnowledgeAcquisitionComponent _kAC;
        public formDomain(KnowledgeAcquisitionComponent _kAC, Operation operation)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this.operation = operation;
            selectedIndex = -1;
            this.Text = "Добавление домена";
            lvDomainValues.ItemDrag += new ItemDragEventHandler(lvDomainValues_ItemDrag);
        }

        public formDomain(KnowledgeAcquisitionComponent _kAC, Operation operation, int index)
        {
            InitializeComponent();
            this._kAC = _kAC;
            this.operation = operation;
            selectedIndex = -1;
            this.Text = "Обновление домена";
            this.selectedIndex = index;
            lvDomainValues.ItemDrag += new ItemDragEventHandler(lvDomainValues_ItemDrag);
            this._updateDomain = _kAC._knowledgeBase.Domains[index];
            tbDomainName.Text = _kAC._knowledgeBase.Domains[index].Name;
            if (_kAC._knowledgeBase.Domains[index].IsNumeric) cbIsNumeric.Checked = true;
            foreach (DomainValue domainValue in _kAC._knowledgeBase.Domains[index].Values)
            {
                lvDomainValues.Items.Add(domainValue.Value);
            }
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvDomainValues.SelectedItems.Count == 0) return;
            if (operation == Operation.Update)
            {
                foreach (DomainValue domainValue in _kAC._knowledgeBase.Domains[selectedIndex].Values)
                {
                    if (domainValue.Value == lvDomainValues.SelectedItems[0].Text)
                    {
                        foreach (Rule rule in _kAC._knowledgeBase.Rules)
                        {
                            if (rule.Conclusion.Value == domainValue)
                            {
                                MessageBox.Show("Это значение домена уже используется в правиле");
                                return;
                            }
                            foreach (Fact fact in rule.Premise.Facts)
                            {
                                if (fact.GetType() == typeof(SingleFact))
                                {
                                    if (((SingleFact)fact).Value == domainValue)
                                    {
                                        MessageBox.Show("Это значение домена уже используется в правиле");
                                        return;
                                    }
                                }
                                else
                                {
                                    if (((AdditiveFact)fact).Value == domainValue)
                                    {
                                        MessageBox.Show("Это значение домена уже используется в правиле");
                                        return;
                                    }
                                }
                            }
                        }
                        break;
                    }

                }
            }
            lvDomainValues.Items.RemoveAt(lvDomainValues.SelectedItems[0].Index);
            btDelete.Enabled = false;
            btEdit.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbNewValue.Text == "") return;

            if (lvDomainValues.Items.OfType<ListViewItem>().ToList().Any(a => a.Text == tbNewValue.Text))
            {
                MessageBox.Show("Домен уже содержит такое значение");
                return;
            }

            lvDomainValues.Items.Add(tbNewValue.Text);
            tbNewValue.Text = "";
        }

        private void lvDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDomainValues.SelectedItems.Count == 0)
            {
                btDelete.Enabled = false;
                btEdit.Enabled = false;
                return;
            }
            tbNewValue.Text = lvDomainValues.SelectedItems[0].Text;
            btDelete.Enabled = true;
            btEdit.Enabled = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lvDomainValues.SelectedItems.Count == 0 || tbNewValue.Text == "") return;
            foreach (ListViewItem item in lvDomainValues.Items.OfType<ListViewItem>().ToList())
            {
                if (item.Index != lvDomainValues.SelectedItems[0].Index)
                {
                    if (item.Text == tbNewValue.Text)
                    {
                        MessageBox.Show("Домен уже содержит такое значение");
                        return;
                    }
                }
            }
            if (operation == Operation.Update)
            {
                foreach (DomainValue domainValue in _kAC._knowledgeBase.Domains[selectedIndex].Values)
                {
                    if (domainValue.Value == lvDomainValues.SelectedItems[0].Text)
                    {
                        foreach (Rule rule in _kAC._knowledgeBase.Rules)
                        {
                            if (rule.Conclusion.Value == domainValue)
                            {
                                MessageBox.Show("Это значение домена используется в правиле");
                                return;
                            }
                            foreach (Fact fact in rule.Premise.Facts)
                            {
                                if (fact.GetType() == typeof(SingleFact))
                                {
                                    if (((SingleFact)fact).Value == domainValue)
                                    {
                                        MessageBox.Show("Это значение домена используется в правиле");
                                        return;
                                    }
                                }
                                else
                                {
                                    if (((AdditiveFact)fact).Value == domainValue)
                                    {
                                        MessageBox.Show("Это значение домена используется в правиле");
                                        return;
                                    }
                                }
                            }
                        }
                        break;
                    }

                }
            }
            lvDomainValues.Items[lvDomainValues.SelectedItems[0].Index].Text = tbNewValue.Text;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbDomainName.Text == "")
            {
                MessageBox.Show("Пустое имя домена");
                return;
            }
            if (cbIsNumeric.Checked)
            {
                foreach (string value in lvDomainValues.Items.OfType<ListViewItem>().ToList().Select(x => x.Text).ToList())
                {
                    try 
                    {
                        Convert.ToDouble(value);
                    }
                    catch
                    {
                        MessageBox.Show("Числовой домен содержит не числовое значение");
                        return;
                    }
                }
            }

            if (tbDomainName.Text.Contains(","))
            {
                MessageBox.Show("Название домена содержит недопустимый символ ','");
                return;
            }

            if (operation == Operation.Add)
            {
                if (_kAC.DomainContains(tbDomainName.Text))
                {
                    MessageBox.Show("Данное имя домена уже существует");
                    return;
                }

                _kAC.AddDomain(tbDomainName.Text, lvDomainValues.Items.OfType<ListViewItem>().ToList().Select(x => x.Text).ToList(), cbIsNumeric.Checked);
            }
            else
            {
                
                foreach (Domain domain in _kAC._knowledgeBase.Domains)
                {
                    if (domain.Name == tbDomainName.Text && domain != _updateDomain)
                    {
                        MessageBox.Show("Данное имя домена уже существует");
                        return;
                    }
                }
                _kAC.UpdateDomain(selectedIndex, tbDomainName.Text, lvDomainValues.Items.OfType<ListViewItem>().ToList().Select(x => x.Text).ToList(), cbIsNumeric.Checked);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lvDomainValues_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvDomainValues.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void lvDomainValues_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = lvDomainValues.InsertionMark.Index;

            if (targetIndex == -1)
            {
                return;
            }
            if (lvDomainValues.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            lvDomainValues.Items.Insert(
            targetIndex, (ListViewItem)draggedItem.Clone());

            lvDomainValues.Items.Remove(draggedItem);
        }

        private void lvDomainValues_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void lvDomainValues_DragLeave(object sender, EventArgs e)
        {
            lvDomainValues.InsertionMark.Index = -1;
        }

        private void lvDomainValues_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint =
                lvDomainValues.PointToClient(new Point(e.X, e.Y));

            int targetIndex = lvDomainValues.InsertionMark.NearestIndex(targetPoint);

            if (targetIndex > -1)
            {
                Rectangle itemBounds = lvDomainValues.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvDomainValues.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvDomainValues.InsertionMark.AppearsAfterItem = false;
                }
            }

            lvDomainValues.InsertionMark.Index = targetIndex;
        }
    }
}
