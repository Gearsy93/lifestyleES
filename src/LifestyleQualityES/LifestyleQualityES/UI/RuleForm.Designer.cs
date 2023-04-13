namespace LifestyleQualityES
{
    partial class formRule
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
            this.gbRuleName = new System.Windows.Forms.GroupBox();
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.gbPremise = new System.Windows.Forms.GroupBox();
            this.btDeletePremise = new System.Windows.Forms.Button();
            this.btAddPremise = new System.Windows.Forms.Button();
            this.btEditPremise = new System.Windows.Forms.Button();
            this.lvPremise = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.tbConclusion = new System.Windows.Forms.TextBox();
            this.btEditConclusion = new System.Windows.Forms.Button();
            this.gbExplanation = new System.Windows.Forms.GroupBox();
            this.rtbExplanation = new System.Windows.Forms.RichTextBox();
            this.gbRuleType = new System.Windows.Forms.GroupBox();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.btOK = new System.Windows.Forms.Button();
            this.btReject = new System.Windows.Forms.Button();
            this.gbRuleName.SuspendLayout();
            this.gbPremise.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.gbExplanation.SuspendLayout();
            this.gbRuleType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRuleName
            // 
            this.gbRuleName.Controls.Add(this.tbRuleName);
            this.gbRuleName.Location = new System.Drawing.Point(6, 12);
            this.gbRuleName.Name = "gbRuleName";
            this.gbRuleName.Size = new System.Drawing.Size(566, 48);
            this.gbRuleName.TabIndex = 0;
            this.gbRuleName.TabStop = false;
            this.gbRuleName.Text = "Имя правила";
            // 
            // tbRuleName
            // 
            this.tbRuleName.Location = new System.Drawing.Point(7, 16);
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(553, 20);
            this.tbRuleName.TabIndex = 0;
            // 
            // gbPremise
            // 
            this.gbPremise.Controls.Add(this.btDeletePremise);
            this.gbPremise.Controls.Add(this.btAddPremise);
            this.gbPremise.Controls.Add(this.btEditPremise);
            this.gbPremise.Controls.Add(this.lvPremise);
            this.gbPremise.Location = new System.Drawing.Point(6, 66);
            this.gbPremise.Name = "gbPremise";
            this.gbPremise.Size = new System.Drawing.Size(281, 143);
            this.gbPremise.TabIndex = 1;
            this.gbPremise.TabStop = false;
            this.gbPremise.Text = "Посылка";
            // 
            // btDeletePremise
            // 
            this.btDeletePremise.Enabled = false;
            this.btDeletePremise.Location = new System.Drawing.Point(183, 106);
            this.btDeletePremise.Name = "btDeletePremise";
            this.btDeletePremise.Size = new System.Drawing.Size(92, 23);
            this.btDeletePremise.TabIndex = 4;
            this.btDeletePremise.Text = "Удалить";
            this.btDeletePremise.UseVisualStyleBackColor = true;
            this.btDeletePremise.Click += new System.EventHandler(this.btDeletePremise_Click);
            // 
            // btAddPremise
            // 
            this.btAddPremise.Location = new System.Drawing.Point(6, 106);
            this.btAddPremise.Name = "btAddPremise";
            this.btAddPremise.Size = new System.Drawing.Size(92, 23);
            this.btAddPremise.TabIndex = 3;
            this.btAddPremise.Text = "Добавить";
            this.btAddPremise.UseVisualStyleBackColor = true;
            this.btAddPremise.Click += new System.EventHandler(this.btAddPremise_Click);
            // 
            // btEditPremise
            // 
            this.btEditPremise.Enabled = false;
            this.btEditPremise.Location = new System.Drawing.Point(94, 106);
            this.btEditPremise.Name = "btEditPremise";
            this.btEditPremise.Size = new System.Drawing.Size(92, 23);
            this.btEditPremise.TabIndex = 2;
            this.btEditPremise.Text = "Изменить";
            this.btEditPremise.UseVisualStyleBackColor = true;
            this.btEditPremise.Click += new System.EventHandler(this.btEditPremise_Click);
            // 
            // lvPremise
            // 
            this.lvPremise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvPremise.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPremise.HideSelection = false;
            this.lvPremise.Location = new System.Drawing.Point(6, 19);
            this.lvPremise.MultiSelect = false;
            this.lvPremise.Name = "lvPremise";
            this.lvPremise.Size = new System.Drawing.Size(269, 80);
            this.lvPremise.TabIndex = 0;
            this.lvPremise.UseCompatibleStateImageBehavior = false;
            this.lvPremise.View = System.Windows.Forms.View.Details;
            this.lvPremise.SelectedIndexChanged += new System.EventHandler(this.lvPremise_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 265;
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.tbConclusion);
            this.gbConclusion.Controls.Add(this.btEditConclusion);
            this.gbConclusion.Location = new System.Drawing.Point(293, 66);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Size = new System.Drawing.Size(279, 143);
            this.gbConclusion.TabIndex = 2;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Заключение";
            // 
            // tbConclusion
            // 
            this.tbConclusion.Location = new System.Drawing.Point(6, 19);
            this.tbConclusion.Name = "tbConclusion";
            this.tbConclusion.ReadOnly = true;
            this.tbConclusion.Size = new System.Drawing.Size(267, 20);
            this.tbConclusion.TabIndex = 6;
            // 
            // btEditConclusion
            // 
            this.btEditConclusion.Location = new System.Drawing.Point(6, 45);
            this.btEditConclusion.Name = "btEditConclusion";
            this.btEditConclusion.Size = new System.Drawing.Size(267, 23);
            this.btEditConclusion.TabIndex = 5;
            this.btEditConclusion.Text = "Изменить";
            this.btEditConclusion.UseVisualStyleBackColor = true;
            this.btEditConclusion.Click += new System.EventHandler(this.btEditConclusion_Click);
            // 
            // gbExplanation
            // 
            this.gbExplanation.Controls.Add(this.rtbExplanation);
            this.gbExplanation.Location = new System.Drawing.Point(6, 292);
            this.gbExplanation.Name = "gbExplanation";
            this.gbExplanation.Size = new System.Drawing.Size(566, 80);
            this.gbExplanation.TabIndex = 3;
            this.gbExplanation.TabStop = false;
            this.gbExplanation.Text = "Пояснение";
            // 
            // rtbExplanation
            // 
            this.rtbExplanation.Location = new System.Drawing.Point(7, 19);
            this.rtbExplanation.Name = "rtbExplanation";
            this.rtbExplanation.Size = new System.Drawing.Size(553, 51);
            this.rtbExplanation.TabIndex = 0;
            this.rtbExplanation.Text = "";
            // 
            // gbRuleType
            // 
            this.gbRuleType.Controls.Add(this.rbOr);
            this.gbRuleType.Controls.Add(this.rbAnd);
            this.gbRuleType.Location = new System.Drawing.Point(6, 216);
            this.gbRuleType.Name = "gbRuleType";
            this.gbRuleType.Size = new System.Drawing.Size(566, 70);
            this.gbRuleType.TabIndex = 4;
            this.gbRuleType.TabStop = false;
            this.gbRuleType.Text = "Отношения фактов посылки";
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(6, 44);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(49, 17);
            this.rbOr.TabIndex = 1;
            this.rbOr.TabStop = true;
            this.rbOr.Text = "ИЛИ";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Location = new System.Drawing.Point(7, 20);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(33, 17);
            this.rbAnd.TabIndex = 0;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "И";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(416, 378);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btReject
            // 
            this.btReject.Location = new System.Drawing.Point(497, 378);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(75, 23);
            this.btReject.TabIndex = 6;
            this.btReject.Text = "Отмена";
            this.btReject.UseVisualStyleBackColor = true;
            this.btReject.Click += new System.EventHandler(this.btReject_Click);
            // 
            // formRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 410);
            this.Controls.Add(this.btReject);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbRuleType);
            this.Controls.Add(this.gbExplanation);
            this.Controls.Add(this.gbConclusion);
            this.Controls.Add(this.gbPremise);
            this.Controls.Add(this.gbRuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formRule";
            this.Text = "Правило";
            this.gbRuleName.ResumeLayout(false);
            this.gbRuleName.PerformLayout();
            this.gbPremise.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.gbConclusion.PerformLayout();
            this.gbExplanation.ResumeLayout(false);
            this.gbRuleType.ResumeLayout(false);
            this.gbRuleType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRuleName;
        private System.Windows.Forms.TextBox tbRuleName;
        private System.Windows.Forms.GroupBox gbPremise;
        private System.Windows.Forms.GroupBox gbConclusion;
        private System.Windows.Forms.GroupBox gbExplanation;
        private System.Windows.Forms.RichTextBox rtbExplanation;
        private System.Windows.Forms.Button btEditPremise;
        private System.Windows.Forms.ListView lvPremise;
        private System.Windows.Forms.Button btDeletePremise;
        private System.Windows.Forms.Button btAddPremise;
        private System.Windows.Forms.Button btEditConclusion;
        private System.Windows.Forms.GroupBox gbRuleType;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btReject;
        private System.Windows.Forms.TextBox tbConclusion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}