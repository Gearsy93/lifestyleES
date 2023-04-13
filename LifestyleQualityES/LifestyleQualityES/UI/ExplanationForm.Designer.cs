namespace LifestyleQualityES
{
    partial class formExplanation
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
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.llHide = new System.Windows.Forms.LinkLabel();
            this.tvRules = new System.Windows.Forms.TreeView();
            this.gbVariables = new System.Windows.Forms.GroupBox();
            this.lvVariables = new System.Windows.Forms.ListView();
            this.aboba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbRules.SuspendLayout();
            this.gbVariables.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.llHide);
            this.gbRules.Controls.Add(this.tvRules);
            this.gbRules.Location = new System.Drawing.Point(13, 13);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(309, 282);
            this.gbRules.TabIndex = 0;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Правила";
            // 
            // llHide
            // 
            this.llHide.AutoSize = true;
            this.llHide.Location = new System.Drawing.Point(57, 0);
            this.llHide.Name = "llHide";
            this.llHide.Size = new System.Drawing.Size(83, 13);
            this.llHide.TabIndex = 1;
            this.llHide.TabStop = true;
            this.llHide.Text = "(раскрыть все)";
            this.llHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHide_LinkClicked);
            // 
            // tvRules
            // 
            this.tvRules.HotTracking = true;
            this.tvRules.Location = new System.Drawing.Point(6, 19);
            this.tvRules.Name = "tvRules";
            this.tvRules.PathSeparator = "+";
            this.tvRules.ShowPlusMinus = false;
            this.tvRules.ShowRootLines = false;
            this.tvRules.Size = new System.Drawing.Size(297, 257);
            this.tvRules.TabIndex = 0;
            this.tvRules.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvRules_AfterCollapse);
            this.tvRules.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvRules_AfterExpand);
            // 
            // gbVariables
            // 
            this.gbVariables.Controls.Add(this.lvVariables);
            this.gbVariables.Location = new System.Drawing.Point(328, 13);
            this.gbVariables.Name = "gbVariables";
            this.gbVariables.Size = new System.Drawing.Size(309, 282);
            this.gbVariables.TabIndex = 1;
            this.gbVariables.TabStop = false;
            this.gbVariables.Text = "Переменные";
            // 
            // lvVariables
            // 
            this.lvVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aboba,
            this.chName,
            this.chValue});
            this.lvVariables.HideSelection = false;
            this.lvVariables.Location = new System.Drawing.Point(6, 19);
            this.lvVariables.Name = "lvVariables";
            this.lvVariables.Size = new System.Drawing.Size(297, 257);
            this.lvVariables.TabIndex = 0;
            this.lvVariables.UseCompatibleStateImageBehavior = false;
            this.lvVariables.View = System.Windows.Forms.View.Details;
            // 
            // aboba
            // 
            this.aboba.Width = 0;
            // 
            // chName
            // 
            this.chName.Text = "Имя";
            this.chName.Width = 147;
            // 
            // chValue
            // 
            this.chValue.Text = "Значение";
            this.chValue.Width = 146;
            // 
            // formExplanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 307);
            this.Controls.Add(this.gbVariables);
            this.Controls.Add(this.gbRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formExplanation";
            this.Text = "Объяснение";
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            this.gbVariables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.GroupBox gbVariables;
        private System.Windows.Forms.TreeView tvRules;
        private System.Windows.Forms.ListView lvVariables;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.LinkLabel llHide;
        private System.Windows.Forms.ColumnHeader aboba;
    }
}