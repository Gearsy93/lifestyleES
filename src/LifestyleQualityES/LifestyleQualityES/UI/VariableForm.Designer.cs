namespace LifestyleQualityES
{
    partial class formVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVariable));
            this.gbVariableName = new System.Windows.Forms.GroupBox();
            this.tbVariableName = new System.Windows.Forms.TextBox();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.btAddDomain = new System.Windows.Forms.Button();
            this.cbDomainList = new System.Windows.Forms.ComboBox();
            this.gbVariableType = new System.Windows.Forms.GroupBox();
            this.rbRequestedOutput = new System.Windows.Forms.RadioButton();
            this.rbOutput = new System.Windows.Forms.RadioButton();
            this.rbRequested = new System.Windows.Forms.RadioButton();
            this.gbQuestionText = new System.Windows.Forms.GroupBox();
            this.rtbQuestionText = new System.Windows.Forms.RichTextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btReject = new System.Windows.Forms.Button();
            this.gbVariableName.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.gbVariableType.SuspendLayout();
            this.gbQuestionText.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVariableName
            // 
            this.gbVariableName.Controls.Add(this.tbVariableName);
            this.gbVariableName.Location = new System.Drawing.Point(9, 15);
            this.gbVariableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVariableName.Name = "gbVariableName";
            this.gbVariableName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVariableName.Size = new System.Drawing.Size(489, 65);
            this.gbVariableName.TabIndex = 0;
            this.gbVariableName.TabStop = false;
            this.gbVariableName.Text = "Имя переменной";
            // 
            // tbVariableName
            // 
            this.tbVariableName.Location = new System.Drawing.Point(9, 25);
            this.tbVariableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVariableName.Name = "tbVariableName";
            this.tbVariableName.Size = new System.Drawing.Size(471, 22);
            this.tbVariableName.TabIndex = 0;
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.btAddDomain);
            this.gbDomain.Controls.Add(this.cbDomainList);
            this.gbDomain.Location = new System.Drawing.Point(9, 89);
            this.gbDomain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDomain.Size = new System.Drawing.Size(489, 65);
            this.gbDomain.TabIndex = 1;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Домен";
            // 
            // btAddDomain
            // 
            this.btAddDomain.BackColor = System.Drawing.Color.Transparent;
            this.btAddDomain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddDomain.BackgroundImage")));
            this.btAddDomain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddDomain.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btAddDomain.Location = new System.Drawing.Point(453, 25);
            this.btAddDomain.Margin = new System.Windows.Forms.Padding(0);
            this.btAddDomain.Name = "btAddDomain";
            this.btAddDomain.Size = new System.Drawing.Size(28, 26);
            this.btAddDomain.TabIndex = 2;
            this.btAddDomain.UseVisualStyleBackColor = false;
            this.btAddDomain.Click += new System.EventHandler(this.btAddDomain_Click);
            // 
            // cbDomainList
            // 
            this.cbDomainList.FormattingEnabled = true;
            this.cbDomainList.Location = new System.Drawing.Point(9, 25);
            this.cbDomainList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDomainList.Name = "cbDomainList";
            this.cbDomainList.Size = new System.Drawing.Size(439, 24);
            this.cbDomainList.TabIndex = 0;
            // 
            // gbVariableType
            // 
            this.gbVariableType.Controls.Add(this.rbRequestedOutput);
            this.gbVariableType.Controls.Add(this.rbOutput);
            this.gbVariableType.Controls.Add(this.rbRequested);
            this.gbVariableType.Location = new System.Drawing.Point(9, 161);
            this.gbVariableType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVariableType.Name = "gbVariableType";
            this.gbVariableType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbVariableType.Size = new System.Drawing.Size(489, 110);
            this.gbVariableType.TabIndex = 2;
            this.gbVariableType.TabStop = false;
            this.gbVariableType.Text = "Тип переменной";
            // 
            // rbRequestedOutput
            // 
            this.rbRequestedOutput.AutoSize = true;
            this.rbRequestedOutput.Location = new System.Drawing.Point(9, 81);
            this.rbRequestedOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRequestedOutput.Name = "rbRequestedOutput";
            this.rbRequestedOutput.Size = new System.Drawing.Size(204, 20);
            this.rbRequestedOutput.TabIndex = 2;
            this.rbRequestedOutput.TabStop = true;
            this.rbRequestedOutput.Text = "Запрашиваемо-выводимая";
            this.rbRequestedOutput.UseVisualStyleBackColor = true;
            this.rbRequestedOutput.CheckedChanged += new System.EventHandler(this.rbRequestedOutput_CheckedChanged);
            // 
            // rbOutput
            // 
            this.rbOutput.AutoSize = true;
            this.rbOutput.Location = new System.Drawing.Point(9, 54);
            this.rbOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(102, 20);
            this.rbOutput.TabIndex = 1;
            this.rbOutput.TabStop = true;
            this.rbOutput.Text = "Выводимая";
            this.rbOutput.UseVisualStyleBackColor = true;
            this.rbOutput.CheckedChanged += new System.EventHandler(this.rbOutput_CheckedChanged);
            // 
            // rbRequested
            // 
            this.rbRequested.AutoSize = true;
            this.rbRequested.Location = new System.Drawing.Point(9, 25);
            this.rbRequested.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRequested.Name = "rbRequested";
            this.rbRequested.Size = new System.Drawing.Size(134, 20);
            this.rbRequested.TabIndex = 0;
            this.rbRequested.TabStop = true;
            this.rbRequested.Text = "Запрашиваемая";
            this.rbRequested.UseVisualStyleBackColor = true;
            this.rbRequested.CheckedChanged += new System.EventHandler(this.rbRequested_CheckedChanged);
            // 
            // gbQuestionText
            // 
            this.gbQuestionText.Controls.Add(this.rtbQuestionText);
            this.gbQuestionText.Location = new System.Drawing.Point(9, 278);
            this.gbQuestionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbQuestionText.Name = "gbQuestionText";
            this.gbQuestionText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbQuestionText.Size = new System.Drawing.Size(489, 130);
            this.gbQuestionText.TabIndex = 3;
            this.gbQuestionText.TabStop = false;
            this.gbQuestionText.Text = "Текст вопроса";
            // 
            // rtbQuestionText
            // 
            this.rtbQuestionText.Enabled = false;
            this.rtbQuestionText.Location = new System.Drawing.Point(9, 25);
            this.rtbQuestionText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbQuestionText.Name = "rtbQuestionText";
            this.rtbQuestionText.Size = new System.Drawing.Size(471, 98);
            this.rtbQuestionText.TabIndex = 0;
            this.rtbQuestionText.Text = "";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(291, 416);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 28);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btReject
            // 
            this.btReject.Location = new System.Drawing.Point(399, 416);
            this.btReject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(100, 28);
            this.btReject.TabIndex = 5;
            this.btReject.Text = "Отмена";
            this.btReject.UseVisualStyleBackColor = true;
            this.btReject.Click += new System.EventHandler(this.btReject_Click);
            // 
            // formVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 452);
            this.Controls.Add(this.btReject);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gbQuestionText);
            this.Controls.Add(this.gbVariableType);
            this.Controls.Add(this.gbDomain);
            this.Controls.Add(this.gbVariableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "formVariable";
            this.Text = "Переменная";
            this.gbVariableName.ResumeLayout(false);
            this.gbVariableName.PerformLayout();
            this.gbDomain.ResumeLayout(false);
            this.gbVariableType.ResumeLayout(false);
            this.gbVariableType.PerformLayout();
            this.gbQuestionText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVariableName;
        private System.Windows.Forms.TextBox tbVariableName;
        private System.Windows.Forms.GroupBox gbDomain;
        private System.Windows.Forms.ComboBox cbDomainList;
        private System.Windows.Forms.GroupBox gbVariableType;
        private System.Windows.Forms.Button btAddDomain;
        private System.Windows.Forms.RadioButton rbRequestedOutput;
        private System.Windows.Forms.RadioButton rbOutput;
        private System.Windows.Forms.RadioButton rbRequested;
        private System.Windows.Forms.GroupBox gbQuestionText;
        private System.Windows.Forms.RichTextBox rtbQuestionText;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btReject;
    }
}