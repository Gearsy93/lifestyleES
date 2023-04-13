namespace LifestyleQualityES
{
    partial class formFactPremise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFactPremise));
            this.cbFacts = new System.Windows.Forms.ComboBox();
            this.btCreateVariable = new System.Windows.Forms.Button();
            this.gbFact = new System.Windows.Forms.GroupBox();
            this.btRemoveVariable = new System.Windows.Forms.Button();
            this.lvAdditive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbValue = new System.Windows.Forms.GroupBox();
            this.cbValues = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btReject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.gbFact.SuspendLayout();
            this.gbValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFacts
            // 
            this.cbFacts.FormattingEnabled = true;
            this.cbFacts.Location = new System.Drawing.Point(9, 19);
            this.cbFacts.Name = "cbFacts";
            this.cbFacts.Size = new System.Drawing.Size(307, 21);
            this.cbFacts.TabIndex = 0;
            this.cbFacts.SelectedIndexChanged += new System.EventHandler(this.cbFacts_SelectedIndexChanged);
            // 
            // btCreateVariable
            // 
            this.btCreateVariable.BackColor = System.Drawing.Color.Transparent;
            this.btCreateVariable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateVariable.BackgroundImage")));
            this.btCreateVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateVariable.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btCreateVariable.Location = new System.Drawing.Point(319, 19);
            this.btCreateVariable.Margin = new System.Windows.Forms.Padding(0);
            this.btCreateVariable.Name = "btCreateVariable";
            this.btCreateVariable.Size = new System.Drawing.Size(21, 21);
            this.btCreateVariable.TabIndex = 1;
            this.btCreateVariable.UseVisualStyleBackColor = false;
            this.btCreateVariable.Click += new System.EventHandler(this.btCreateVariable_Click);
            // 
            // gbFact
            // 
            this.gbFact.Controls.Add(this.btRemoveVariable);
            this.gbFact.Controls.Add(this.lvAdditive);
            this.gbFact.Location = new System.Drawing.Point(4, 103);
            this.gbFact.Name = "gbFact";
            this.gbFact.Size = new System.Drawing.Size(350, 151);
            this.gbFact.TabIndex = 3;
            this.gbFact.TabStop = false;
            this.gbFact.Text = "Аддитивные переменные факта";
            // 
            // btRemoveVariable
            // 
            this.btRemoveVariable.Enabled = false;
            this.btRemoveVariable.Location = new System.Drawing.Point(9, 109);
            this.btRemoveVariable.Name = "btRemoveVariable";
            this.btRemoveVariable.Size = new System.Drawing.Size(330, 23);
            this.btRemoveVariable.TabIndex = 3;
            this.btRemoveVariable.Text = "Удалить";
            this.btRemoveVariable.UseVisualStyleBackColor = true;
            this.btRemoveVariable.Click += new System.EventHandler(this.btRemoveVariable_Click);
            // 
            // lvAdditive
            // 
            this.lvAdditive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAdditive.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAdditive.HideSelection = false;
            this.lvAdditive.Location = new System.Drawing.Point(9, 20);
            this.lvAdditive.MultiSelect = false;
            this.lvAdditive.Name = "lvAdditive";
            this.lvAdditive.Size = new System.Drawing.Size(330, 83);
            this.lvAdditive.TabIndex = 2;
            this.lvAdditive.UseCompatibleStateImageBehavior = false;
            this.lvAdditive.View = System.Windows.Forms.View.Details;
            this.lvAdditive.SelectedIndexChanged += new System.EventHandler(this.lvAdditive_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 326;
            // 
            // gbValue
            // 
            this.gbValue.Controls.Add(this.cbValues);
            this.gbValue.Location = new System.Drawing.Point(4, 273);
            this.gbValue.Name = "gbValue";
            this.gbValue.Size = new System.Drawing.Size(350, 55);
            this.gbValue.TabIndex = 4;
            this.gbValue.TabStop = false;
            this.gbValue.Text = "Значение";
            // 
            // cbValues
            // 
            this.cbValues.FormattingEnabled = true;
            this.cbValues.Location = new System.Drawing.Point(8, 19);
            this.cbValues.Name = "cbValues";
            this.cbValues.Size = new System.Drawing.Size(331, 21);
            this.cbValues.TabIndex = 0;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(198, 344);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btReject
            // 
            this.btReject.Location = new System.Drawing.Point(279, 344);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(75, 23);
            this.btReject.TabIndex = 6;
            this.btReject.Text = "Отмена";
            this.btReject.UseVisualStyleBackColor = true;
            this.btReject.Click += new System.EventHandler(this.btReject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(166, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.cbFacts);
            this.groupBox1.Controls.Add(this.btCreateVariable);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление переменных факта";
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(9, 47);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(330, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // formFactPremise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(358, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReject);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbValue);
            this.Controls.Add(this.gbFact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formFactPremise";
            this.Text = "Факт";
            this.gbFact.ResumeLayout(false);
            this.gbValue.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFacts;
        private System.Windows.Forms.Button btCreateVariable;
        private System.Windows.Forms.GroupBox gbFact;
        private System.Windows.Forms.GroupBox gbValue;
        private System.Windows.Forms.ComboBox cbValues;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btReject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvAdditive;
        private System.Windows.Forms.Button btRemoveVariable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}