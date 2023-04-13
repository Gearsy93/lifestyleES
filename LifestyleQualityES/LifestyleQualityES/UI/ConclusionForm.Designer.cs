namespace LifestyleQualityES.UI
{
    partial class ConclusionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConclusionForm));
            this.gbConclusionVariable = new System.Windows.Forms.GroupBox();
            this.btCreateVariable = new System.Windows.Forms.Button();
            this.cbVariables = new System.Windows.Forms.ComboBox();
            this.gbValue = new System.Windows.Forms.GroupBox();
            this.cbValues = new System.Windows.Forms.ComboBox();
            this.btReject = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.gbConclusionVariable.SuspendLayout();
            this.gbValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConclusionVariable
            // 
            this.gbConclusionVariable.Controls.Add(this.btCreateVariable);
            this.gbConclusionVariable.Controls.Add(this.cbVariables);
            this.gbConclusionVariable.Location = new System.Drawing.Point(5, 15);
            this.gbConclusionVariable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConclusionVariable.Name = "gbConclusionVariable";
            this.gbConclusionVariable.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConclusionVariable.Size = new System.Drawing.Size(467, 64);
            this.gbConclusionVariable.TabIndex = 0;
            this.gbConclusionVariable.TabStop = false;
            this.gbConclusionVariable.Text = "Переменная заключения";
            // 
            // btCreateVariable
            // 
            this.btCreateVariable.BackColor = System.Drawing.Color.Transparent;
            this.btCreateVariable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateVariable.BackgroundImage")));
            this.btCreateVariable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateVariable.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btCreateVariable.Location = new System.Drawing.Point(425, 23);
            this.btCreateVariable.Margin = new System.Windows.Forms.Padding(0);
            this.btCreateVariable.Name = "btCreateVariable";
            this.btCreateVariable.Size = new System.Drawing.Size(28, 26);
            this.btCreateVariable.TabIndex = 2;
            this.btCreateVariable.UseVisualStyleBackColor = false;
            this.btCreateVariable.Click += new System.EventHandler(this.btCreateVariable_Click);
            // 
            // cbVariables
            // 
            this.cbVariables.FormattingEnabled = true;
            this.cbVariables.Location = new System.Drawing.Point(12, 23);
            this.cbVariables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVariables.Name = "cbVariables";
            this.cbVariables.Size = new System.Drawing.Size(408, 24);
            this.cbVariables.TabIndex = 0;
            this.cbVariables.SelectedValueChanged += new System.EventHandler(this.cbVariables_SelectedValueChanged);
            // 
            // gbValue
            // 
            this.gbValue.Controls.Add(this.cbValues);
            this.gbValue.Location = new System.Drawing.Point(5, 87);
            this.gbValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbValue.Name = "gbValue";
            this.gbValue.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbValue.Size = new System.Drawing.Size(467, 66);
            this.gbValue.TabIndex = 1;
            this.gbValue.TabStop = false;
            this.gbValue.Text = "Значение переменной";
            // 
            // cbValues
            // 
            this.cbValues.FormattingEnabled = true;
            this.cbValues.Location = new System.Drawing.Point(12, 25);
            this.cbValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbValues.Name = "cbValues";
            this.cbValues.Size = new System.Drawing.Size(440, 24);
            this.cbValues.TabIndex = 0;
            this.cbValues.SelectedValueChanged += new System.EventHandler(this.cbValues_SelectedValueChanged);
            // 
            // btReject
            // 
            this.btReject.Location = new System.Drawing.Point(372, 161);
            this.btReject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(100, 28);
            this.btReject.TabIndex = 2;
            this.btReject.Text = "Отмена";
            this.btReject.UseVisualStyleBackColor = true;
            this.btReject.Click += new System.EventHandler(this.btReject_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(264, 161);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 28);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ConclusionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 196);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btReject);
            this.Controls.Add(this.gbValue);
            this.Controls.Add(this.gbConclusionVariable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ConclusionForm";
            this.Text = "Заключение";
            this.gbConclusionVariable.ResumeLayout(false);
            this.gbValue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConclusionVariable;
        private System.Windows.Forms.ComboBox cbVariables;
        private System.Windows.Forms.Button btCreateVariable;
        private System.Windows.Forms.GroupBox gbValue;
        private System.Windows.Forms.ComboBox cbValues;
        private System.Windows.Forms.Button btReject;
        private System.Windows.Forms.Button btOK;
    }
}