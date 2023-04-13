namespace LifestyleQualityES
{
    partial class formDomain
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
            this.dbDomainName = new System.Windows.Forms.GroupBox();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.gbDomainValues = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.lvDomainValues = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddNewValue = new System.Windows.Forms.GroupBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.btReject = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.cbIsNumeric = new System.Windows.Forms.CheckBox();
            this.dbDomainName.SuspendLayout();
            this.gbDomainValues.SuspendLayout();
            this.gbAddNewValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDomainName
            // 
            this.dbDomainName.Controls.Add(this.tbDomainName);
            this.dbDomainName.Location = new System.Drawing.Point(12, 12);
            this.dbDomainName.Name = "dbDomainName";
            this.dbDomainName.Size = new System.Drawing.Size(394, 51);
            this.dbDomainName.TabIndex = 0;
            this.dbDomainName.TabStop = false;
            this.dbDomainName.Text = "Имя домена";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(7, 20);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(381, 20);
            this.tbDomainName.TabIndex = 0;
            // 
            // gbDomainValues
            // 
            this.gbDomainValues.Controls.Add(this.btDelete);
            this.gbDomainValues.Controls.Add(this.lvDomainValues);
            this.gbDomainValues.Location = new System.Drawing.Point(12, 92);
            this.gbDomainValues.Name = "gbDomainValues";
            this.gbDomainValues.Size = new System.Drawing.Size(394, 184);
            this.gbDomainValues.TabIndex = 1;
            this.gbDomainValues.TabStop = false;
            this.gbDomainValues.Text = "Допустимые значения домена";
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(6, 155);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(382, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lvDomainValues
            // 
            this.lvDomainValues.AllowDrop = true;
            this.lvDomainValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDomainValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDomainValues.FullRowSelect = true;
            this.lvDomainValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDomainValues.HideSelection = false;
            this.lvDomainValues.Location = new System.Drawing.Point(7, 19);
            this.lvDomainValues.MultiSelect = false;
            this.lvDomainValues.Name = "lvDomainValues";
            this.lvDomainValues.Size = new System.Drawing.Size(381, 138);
            this.lvDomainValues.TabIndex = 0;
            this.lvDomainValues.UseCompatibleStateImageBehavior = false;
            this.lvDomainValues.View = System.Windows.Forms.View.Details;
            this.lvDomainValues.SelectedIndexChanged += new System.EventHandler(this.lvDomainValues_SelectedIndexChanged);
            this.lvDomainValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvDomainValues_DragDrop);
            this.lvDomainValues.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvDomainValues_DragEnter);
            this.lvDomainValues.DragOver += new System.Windows.Forms.DragEventHandler(this.lvDomainValues_DragOver);
            this.lvDomainValues.DragLeave += new System.EventHandler(this.lvDomainValues_DragLeave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 350;
            // 
            // gbAddNewValue
            // 
            this.gbAddNewValue.Controls.Add(this.btEdit);
            this.gbAddNewValue.Controls.Add(this.btAdd);
            this.gbAddNewValue.Controls.Add(this.tbNewValue);
            this.gbAddNewValue.Location = new System.Drawing.Point(12, 282);
            this.gbAddNewValue.Name = "gbAddNewValue";
            this.gbAddNewValue.Size = new System.Drawing.Size(394, 52);
            this.gbAddNewValue.TabIndex = 2;
            this.gbAddNewValue.TabStop = false;
            this.gbAddNewValue.Text = "Введите новое значение";
            // 
            // btEdit
            // 
            this.btEdit.Enabled = false;
            this.btEdit.Location = new System.Drawing.Point(313, 19);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 20);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Изменить";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(232, 19);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 20);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(7, 19);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(219, 20);
            this.tbNewValue.TabIndex = 0;
            // 
            // btReject
            // 
            this.btReject.Location = new System.Drawing.Point(331, 340);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(75, 23);
            this.btReject.TabIndex = 3;
            this.btReject.Text = "Отмена";
            this.btReject.UseVisualStyleBackColor = true;
            this.btReject.Click += new System.EventHandler(this.btReject_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(250, 340);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // cbIsNumeric
            // 
            this.cbIsNumeric.AutoSize = true;
            this.cbIsNumeric.Location = new System.Drawing.Point(18, 69);
            this.cbIsNumeric.Name = "cbIsNumeric";
            this.cbIsNumeric.Size = new System.Drawing.Size(111, 17);
            this.cbIsNumeric.TabIndex = 6;
            this.cbIsNumeric.Text = "Числовой домен";
            this.cbIsNumeric.UseVisualStyleBackColor = true;
            // 
            // formDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 376);
            this.Controls.Add(this.cbIsNumeric);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btReject);
            this.Controls.Add(this.gbAddNewValue);
            this.Controls.Add(this.gbDomainValues);
            this.Controls.Add(this.dbDomainName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formDomain";
            this.Text = "Домен";
            this.dbDomainName.ResumeLayout(false);
            this.dbDomainName.PerformLayout();
            this.gbDomainValues.ResumeLayout(false);
            this.gbAddNewValue.ResumeLayout(false);
            this.gbAddNewValue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dbDomainName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.GroupBox gbDomainValues;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ListView lvDomainValues;
        private System.Windows.Forms.GroupBox gbAddNewValue;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Button btReject;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox cbIsNumeric;
    }
}