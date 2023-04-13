namespace LifestyleQualityES
{
    partial class formConsult
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
            this.btNewConsult = new System.Windows.Forms.Button();
            this.btShowExplanation = new System.Windows.Forms.Button();
            this.cbAnswers = new System.Windows.Forms.ComboBox();
            this.btReply = new System.Windows.Forms.Button();
            this.tlpMessages = new System.Windows.Forms.TableLayoutPanel();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.flpChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNewConsult
            // 
            this.btNewConsult.Enabled = false;
            this.btNewConsult.Location = new System.Drawing.Point(8, 353);
            this.btNewConsult.Name = "btNewConsult";
            this.btNewConsult.Size = new System.Drawing.Size(195, 24);
            this.btNewConsult.TabIndex = 3;
            this.btNewConsult.Text = "Новая консультация";
            this.btNewConsult.UseVisualStyleBackColor = true;
            this.btNewConsult.Click += new System.EventHandler(this.btNewConsult_Click);
            // 
            // btShowExplanation
            // 
            this.btShowExplanation.Enabled = false;
            this.btShowExplanation.Location = new System.Drawing.Point(228, 353);
            this.btShowExplanation.Name = "btShowExplanation";
            this.btShowExplanation.Size = new System.Drawing.Size(195, 24);
            this.btShowExplanation.TabIndex = 4;
            this.btShowExplanation.Text = "Показать объяснение";
            this.btShowExplanation.UseVisualStyleBackColor = true;
            this.btShowExplanation.Click += new System.EventHandler(this.btShowExplanation_Click);
            // 
            // cbAnswers
            // 
            this.cbAnswers.FormattingEnabled = true;
            this.cbAnswers.Location = new System.Drawing.Point(8, 326);
            this.cbAnswers.Name = "cbAnswers";
            this.cbAnswers.Size = new System.Drawing.Size(320, 21);
            this.cbAnswers.TabIndex = 1;
            this.cbAnswers.SelectedIndexChanged += new System.EventHandler(this.cbAnswers_SelectedIndexChanged);
            this.cbAnswers.SelectedValueChanged += new System.EventHandler(this.cbAnswers_SelectedValueChanged);
            // 
            // btReply
            // 
            this.btReply.Enabled = false;
            this.btReply.Location = new System.Drawing.Point(338, 326);
            this.btReply.Name = "btReply";
            this.btReply.Size = new System.Drawing.Size(85, 20);
            this.btReply.TabIndex = 2;
            this.btReply.Text = "Ответить";
            this.btReply.UseVisualStyleBackColor = true;
            this.btReply.Click += new System.EventHandler(this.btReply_Click);
            // 
            // tlpMessages
            // 
            this.tlpMessages.AutoSize = true;
            this.tlpMessages.ColumnCount = 2;
            this.tlpMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tlpMessages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tlpMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpMessages.Location = new System.Drawing.Point(15, 16);
            this.tlpMessages.Margin = new System.Windows.Forms.Padding(15, 16, 4, 4);
            this.tlpMessages.Name = "tlpMessages";
            this.tlpMessages.RowCount = 1;
            this.tlpMessages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMessages.Size = new System.Drawing.Size(390, 50);
            this.tlpMessages.TabIndex = 0;
            // 
            // flpChat
            // 
            this.flpChat.AutoScroll = true;
            this.flpChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpChat.Controls.Add(this.tlpMessages);
            this.flpChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChat.Location = new System.Drawing.Point(0, 0);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(432, 322);
            this.flpChat.TabIndex = 0;
            // 
            // formConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 386);
            this.Controls.Add(this.btShowExplanation);
            this.Controls.Add(this.btReply);
            this.Controls.Add(this.btNewConsult);
            this.Controls.Add(this.cbAnswers);
            this.Controls.Add(this.flpChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formConsult";
            this.ShowIcon = false;
            this.Text = "Консультация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formConsult_KeyDown);
            this.flpChat.ResumeLayout(false);
            this.flpChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btReply;
        private System.Windows.Forms.Button btNewConsult;
        private System.Windows.Forms.Button btShowExplanation;
        public System.Windows.Forms.ComboBox cbAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMessages;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
    }
}