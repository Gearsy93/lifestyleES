namespace LifestyleQualityES
{
    partial class formMainForm
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
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.gbPremise = new System.Windows.Forms.GroupBox();
            this.lvRulesPremises = new System.Windows.Forms.ListView();
            this.chColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEditRules = new System.Windows.Forms.GroupBox();
            this.btDeleteRules = new System.Windows.Forms.Button();
            this.btEditRules = new System.Windows.Forms.Button();
            this.btAddRules = new System.Windows.Forms.Button();
            this.lvRules = new System.Windows.Forms.ListView();
            this.chVoidRules = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameRules = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriptionRules = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpVariables = new System.Windows.Forms.TabPage();
            this.gbVariablesDomainValue = new System.Windows.Forms.GroupBox();
            this.lvVariablesDomainValues = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbQuestionTextVariables = new System.Windows.Forms.GroupBox();
            this.rtbQuestionText = new System.Windows.Forms.RichTextBox();
            this.gbEditVariables = new System.Windows.Forms.GroupBox();
            this.btDeleteVariables = new System.Windows.Forms.Button();
            this.btEditVariables = new System.Windows.Forms.Button();
            this.btAddVariables = new System.Windows.Forms.Button();
            this.lvVariables = new System.Windows.Forms.ListView();
            this.chEmptyVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameVariables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTypeVariables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDomainVariables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDomains = new System.Windows.Forms.TabPage();
            this.lvDomains = new System.Windows.Forms.ListView();
            this.chVoidDomains = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNameDomains = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDomainValue = new System.Windows.Forms.GroupBox();
            this.lvDomainValues = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbEditDomains = new System.Windows.Forms.GroupBox();
            this.btDeleteDomains = new System.Windows.Forms.Button();
            this.btEditDomains = new System.Windows.Forms.Button();
            this.btAddDomains = new System.Windows.Forms.Button();
            this.mstFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mstNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mstOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mstSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mstSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mstExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.mstBeginConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.mstShowExplanation = new System.Windows.Forms.ToolStripMenuItem();
            this.msBar = new System.Windows.Forms.MenuStrip();
            this.tbMain.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.gbPremise.SuspendLayout();
            this.gbEditRules.SuspendLayout();
            this.tpVariables.SuspendLayout();
            this.gbVariablesDomainValue.SuspendLayout();
            this.gbQuestionTextVariables.SuspendLayout();
            this.gbEditVariables.SuspendLayout();
            this.tpDomains.SuspendLayout();
            this.gbDomainValue.SuspendLayout();
            this.gbEditDomains.SuspendLayout();
            this.msBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpRules);
            this.tbMain.Controls.Add(this.tpVariables);
            this.tbMain.Controls.Add(this.tpDomains);
            this.tbMain.Enabled = false;
            this.tbMain.Location = new System.Drawing.Point(0, 27);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(800, 411);
            this.tbMain.TabIndex = 1;
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.gbPremise);
            this.tpRules.Controls.Add(this.gbEditRules);
            this.tpRules.Controls.Add(this.lvRules);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpRules.Size = new System.Drawing.Size(792, 385);
            this.tpRules.TabIndex = 0;
            this.tpRules.Text = "Правила";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // gbPremise
            // 
            this.gbPremise.Controls.Add(this.lvRulesPremises);
            this.gbPremise.Location = new System.Drawing.Point(588, 125);
            this.gbPremise.Name = "gbPremise";
            this.gbPremise.Size = new System.Drawing.Size(196, 246);
            this.gbPremise.TabIndex = 2;
            this.gbPremise.TabStop = false;
            this.gbPremise.Text = "Посылка";
            // 
            // lvRulesPremises
            // 
            this.lvRulesPremises.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvRulesPremises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRulesPremises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColumn});
            this.lvRulesPremises.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvRulesPremises.HideSelection = false;
            this.lvRulesPremises.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvRulesPremises.Location = new System.Drawing.Point(6, 20);
            this.lvRulesPremises.Name = "lvRulesPremises";
            this.lvRulesPremises.Size = new System.Drawing.Size(184, 220);
            this.lvRulesPremises.TabIndex = 0;
            this.lvRulesPremises.UseCompatibleStateImageBehavior = false;
            this.lvRulesPremises.View = System.Windows.Forms.View.SmallIcon;
            // 
            // chColumn
            // 
            this.chColumn.Text = "";
            this.chColumn.Width = 400;
            // 
            // gbEditRules
            // 
            this.gbEditRules.Controls.Add(this.btDeleteRules);
            this.gbEditRules.Controls.Add(this.btEditRules);
            this.gbEditRules.Controls.Add(this.btAddRules);
            this.gbEditRules.Location = new System.Drawing.Point(588, 3);
            this.gbEditRules.Name = "gbEditRules";
            this.gbEditRules.Size = new System.Drawing.Size(196, 115);
            this.gbEditRules.TabIndex = 1;
            this.gbEditRules.TabStop = false;
            this.gbEditRules.Text = "Редактирование";
            // 
            // btDeleteRules
            // 
            this.btDeleteRules.Enabled = false;
            this.btDeleteRules.Location = new System.Drawing.Point(6, 77);
            this.btDeleteRules.Name = "btDeleteRules";
            this.btDeleteRules.Size = new System.Drawing.Size(184, 23);
            this.btDeleteRules.TabIndex = 2;
            this.btDeleteRules.Text = "Удалить";
            this.btDeleteRules.UseVisualStyleBackColor = true;
            this.btDeleteRules.Click += new System.EventHandler(this.btDeleteRules_Click);
            // 
            // btEditRules
            // 
            this.btEditRules.Enabled = false;
            this.btEditRules.Location = new System.Drawing.Point(6, 48);
            this.btEditRules.Name = "btEditRules";
            this.btEditRules.Size = new System.Drawing.Size(184, 23);
            this.btEditRules.TabIndex = 1;
            this.btEditRules.Text = "Изменить";
            this.btEditRules.UseVisualStyleBackColor = true;
            this.btEditRules.Click += new System.EventHandler(this.btEditRules_Click);
            // 
            // btAddRules
            // 
            this.btAddRules.Location = new System.Drawing.Point(6, 19);
            this.btAddRules.Name = "btAddRules";
            this.btAddRules.Size = new System.Drawing.Size(184, 23);
            this.btAddRules.TabIndex = 0;
            this.btAddRules.Text = "Добавить";
            this.btAddRules.UseVisualStyleBackColor = true;
            this.btAddRules.Click += new System.EventHandler(this.btAddRules_Click);
            // 
            // lvRules
            // 
            this.lvRules.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvRules.AllowDrop = true;
            this.lvRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVoidRules,
            this.chNameRules,
            this.chDescriptionRules});
            this.lvRules.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvRules.FullRowSelect = true;
            this.lvRules.HideSelection = false;
            this.lvRules.Location = new System.Drawing.Point(0, 0);
            this.lvRules.MultiSelect = false;
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(582, 385);
            this.lvRules.TabIndex = 0;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            this.lvRules.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvRules_ItemSelectionChanged);
            this.lvRules.SelectedIndexChanged += new System.EventHandler(this.lvRules_SelectedIndexChanged);
            this.lvRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvRules_DragDrop);
            this.lvRules.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvRules_DragEnter);
            this.lvRules.DragOver += new System.Windows.Forms.DragEventHandler(this.lvRules_DragOver);
            this.lvRules.DragLeave += new System.EventHandler(this.lvRules_DragLeave);
            // 
            // chVoidRules
            // 
            this.chVoidRules.Text = "";
            this.chVoidRules.Width = 0;
            // 
            // chNameRules
            // 
            this.chNameRules.Text = "Имя";
            // 
            // chDescriptionRules
            // 
            this.chDescriptionRules.Text = "Описание";
            this.chDescriptionRules.Width = 1200;
            // 
            // tpVariables
            // 
            this.tpVariables.Controls.Add(this.gbVariablesDomainValue);
            this.tpVariables.Controls.Add(this.gbQuestionTextVariables);
            this.tpVariables.Controls.Add(this.gbEditVariables);
            this.tpVariables.Controls.Add(this.lvVariables);
            this.tpVariables.Location = new System.Drawing.Point(4, 22);
            this.tpVariables.Name = "tpVariables";
            this.tpVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariables.Size = new System.Drawing.Size(792, 385);
            this.tpVariables.TabIndex = 1;
            this.tpVariables.Text = "Переменные";
            this.tpVariables.UseVisualStyleBackColor = true;
            // 
            // gbVariablesDomainValue
            // 
            this.gbVariablesDomainValue.Controls.Add(this.lvVariablesDomainValues);
            this.gbVariablesDomainValue.Location = new System.Drawing.Point(588, 249);
            this.gbVariablesDomainValue.Name = "gbVariablesDomainValue";
            this.gbVariablesDomainValue.Size = new System.Drawing.Size(196, 122);
            this.gbVariablesDomainValue.TabIndex = 3;
            this.gbVariablesDomainValue.TabStop = false;
            this.gbVariablesDomainValue.Text = "Значения домена";
            // 
            // lvVariablesDomainValues
            // 
            this.lvVariablesDomainValues.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvVariablesDomainValues.AllowDrop = true;
            this.lvVariablesDomainValues.AutoArrange = false;
            this.lvVariablesDomainValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvVariablesDomainValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvVariablesDomainValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvVariablesDomainValues.HideSelection = false;
            this.lvVariablesDomainValues.Location = new System.Drawing.Point(7, 20);
            this.lvVariablesDomainValues.Name = "lvVariablesDomainValues";
            this.lvVariablesDomainValues.Size = new System.Drawing.Size(183, 96);
            this.lvVariablesDomainValues.TabIndex = 0;
            this.lvVariablesDomainValues.UseCompatibleStateImageBehavior = false;
            this.lvVariablesDomainValues.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // gbQuestionTextVariables
            // 
            this.gbQuestionTextVariables.Controls.Add(this.rtbQuestionText);
            this.gbQuestionTextVariables.Location = new System.Drawing.Point(588, 125);
            this.gbQuestionTextVariables.Name = "gbQuestionTextVariables";
            this.gbQuestionTextVariables.Size = new System.Drawing.Size(196, 109);
            this.gbQuestionTextVariables.TabIndex = 2;
            this.gbQuestionTextVariables.TabStop = false;
            this.gbQuestionTextVariables.Text = "Текст вопроса";
            // 
            // rtbQuestionText
            // 
            this.rtbQuestionText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbQuestionText.Location = new System.Drawing.Point(7, 20);
            this.rtbQuestionText.Name = "rtbQuestionText";
            this.rtbQuestionText.ReadOnly = true;
            this.rtbQuestionText.Size = new System.Drawing.Size(183, 83);
            this.rtbQuestionText.TabIndex = 0;
            this.rtbQuestionText.Text = "";
            // 
            // gbEditVariables
            // 
            this.gbEditVariables.Controls.Add(this.btDeleteVariables);
            this.gbEditVariables.Controls.Add(this.btEditVariables);
            this.gbEditVariables.Controls.Add(this.btAddVariables);
            this.gbEditVariables.Location = new System.Drawing.Point(588, 3);
            this.gbEditVariables.Name = "gbEditVariables";
            this.gbEditVariables.Size = new System.Drawing.Size(196, 115);
            this.gbEditVariables.TabIndex = 1;
            this.gbEditVariables.TabStop = false;
            this.gbEditVariables.Text = "Редактирование";
            // 
            // btDeleteVariables
            // 
            this.btDeleteVariables.Enabled = false;
            this.btDeleteVariables.Location = new System.Drawing.Point(6, 77);
            this.btDeleteVariables.Name = "btDeleteVariables";
            this.btDeleteVariables.Size = new System.Drawing.Size(184, 23);
            this.btDeleteVariables.TabIndex = 2;
            this.btDeleteVariables.Text = "Удалить";
            this.btDeleteVariables.UseVisualStyleBackColor = true;
            this.btDeleteVariables.Click += new System.EventHandler(this.btDeleteVariables_Click);
            // 
            // btEditVariables
            // 
            this.btEditVariables.Enabled = false;
            this.btEditVariables.Location = new System.Drawing.Point(6, 48);
            this.btEditVariables.Name = "btEditVariables";
            this.btEditVariables.Size = new System.Drawing.Size(184, 23);
            this.btEditVariables.TabIndex = 1;
            this.btEditVariables.Text = "Изменить";
            this.btEditVariables.UseVisualStyleBackColor = true;
            this.btEditVariables.Click += new System.EventHandler(this.btEditVariables_Click);
            // 
            // btAddVariables
            // 
            this.btAddVariables.Location = new System.Drawing.Point(6, 19);
            this.btAddVariables.Name = "btAddVariables";
            this.btAddVariables.Size = new System.Drawing.Size(184, 23);
            this.btAddVariables.TabIndex = 0;
            this.btAddVariables.Text = "Добавить";
            this.btAddVariables.UseVisualStyleBackColor = true;
            this.btAddVariables.Click += new System.EventHandler(this.btAddVariables_Click);
            // 
            // lvVariables
            // 
            this.lvVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmptyVar,
            this.chNameVariables,
            this.chTypeVariables,
            this.chDomainVariables});
            this.lvVariables.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lvVariables.FullRowSelect = true;
            this.lvVariables.HideSelection = false;
            this.lvVariables.Location = new System.Drawing.Point(0, 0);
            this.lvVariables.MultiSelect = false;
            this.lvVariables.Name = "lvVariables";
            this.lvVariables.Size = new System.Drawing.Size(582, 385);
            this.lvVariables.TabIndex = 0;
            this.lvVariables.UseCompatibleStateImageBehavior = false;
            this.lvVariables.View = System.Windows.Forms.View.Details;
            this.lvVariables.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvVariables_ItemSelectionChanged);
            this.lvVariables.SelectedIndexChanged += new System.EventHandler(this.lvVariables_SelectedIndexChanged);
            // 
            // chEmptyVar
            // 
            this.chEmptyVar.Text = "";
            this.chEmptyVar.Width = 0;
            // 
            // chNameVariables
            // 
            this.chNameVariables.Text = "Имя";
            this.chNameVariables.Width = 220;
            // 
            // chTypeVariables
            // 
            this.chTypeVariables.Text = "Тип";
            this.chTypeVariables.Width = 120;
            // 
            // chDomainVariables
            // 
            this.chDomainVariables.Text = "Домен";
            this.chDomainVariables.Width = 246;
            // 
            // tpDomains
            // 
            this.tpDomains.Controls.Add(this.lvDomains);
            this.tpDomains.Controls.Add(this.gbDomainValue);
            this.tpDomains.Controls.Add(this.gbEditDomains);
            this.tpDomains.Location = new System.Drawing.Point(4, 22);
            this.tpDomains.Name = "tpDomains";
            this.tpDomains.Padding = new System.Windows.Forms.Padding(3);
            this.tpDomains.Size = new System.Drawing.Size(792, 385);
            this.tpDomains.TabIndex = 2;
            this.tpDomains.Text = "Домены";
            this.tpDomains.UseVisualStyleBackColor = true;
            // 
            // lvDomains
            // 
            this.lvDomains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVoidDomains,
            this.chNameDomains});
            this.lvDomains.FullRowSelect = true;
            this.lvDomains.HideSelection = false;
            this.lvDomains.Location = new System.Drawing.Point(0, 0);
            this.lvDomains.MultiSelect = false;
            this.lvDomains.Name = "lvDomains";
            this.lvDomains.Size = new System.Drawing.Size(581, 385);
            this.lvDomains.TabIndex = 0;
            this.lvDomains.UseCompatibleStateImageBehavior = false;
            this.lvDomains.View = System.Windows.Forms.View.Details;
            this.lvDomains.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDomains_ItemSelectionChanged);
            this.lvDomains.SelectedIndexChanged += new System.EventHandler(this.lvDomains_SelectedIndexChanged);
            // 
            // chVoidDomains
            // 
            this.chVoidDomains.Text = "";
            this.chVoidDomains.Width = 0;
            // 
            // chNameDomains
            // 
            this.chNameDomains.Text = "Имя";
            this.chNameDomains.Width = 585;
            // 
            // gbDomainValue
            // 
            this.gbDomainValue.Controls.Add(this.lvDomainValues);
            this.gbDomainValue.Location = new System.Drawing.Point(588, 125);
            this.gbDomainValue.Name = "gbDomainValue";
            this.gbDomainValue.Size = new System.Drawing.Size(197, 246);
            this.gbDomainValue.TabIndex = 2;
            this.gbDomainValue.TabStop = false;
            this.gbDomainValue.Text = "Значения домена";
            // 
            // lvDomainValues
            // 
            this.lvDomainValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDomainValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvDomainValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDomainValues.HideSelection = false;
            this.lvDomainValues.Location = new System.Drawing.Point(7, 20);
            this.lvDomainValues.Name = "lvDomainValues";
            this.lvDomainValues.Size = new System.Drawing.Size(183, 220);
            this.lvDomainValues.TabIndex = 0;
            this.lvDomainValues.UseCompatibleStateImageBehavior = false;
            this.lvDomainValues.View = System.Windows.Forms.View.List;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 183;
            // 
            // gbEditDomains
            // 
            this.gbEditDomains.Controls.Add(this.btDeleteDomains);
            this.gbEditDomains.Controls.Add(this.btEditDomains);
            this.gbEditDomains.Controls.Add(this.btAddDomains);
            this.gbEditDomains.Location = new System.Drawing.Point(588, 3);
            this.gbEditDomains.Name = "gbEditDomains";
            this.gbEditDomains.Size = new System.Drawing.Size(196, 115);
            this.gbEditDomains.TabIndex = 1;
            this.gbEditDomains.TabStop = false;
            this.gbEditDomains.Text = "Редактирование";
            // 
            // btDeleteDomains
            // 
            this.btDeleteDomains.Enabled = false;
            this.btDeleteDomains.Location = new System.Drawing.Point(6, 77);
            this.btDeleteDomains.Name = "btDeleteDomains";
            this.btDeleteDomains.Size = new System.Drawing.Size(184, 23);
            this.btDeleteDomains.TabIndex = 2;
            this.btDeleteDomains.Text = "Удалить";
            this.btDeleteDomains.UseVisualStyleBackColor = true;
            this.btDeleteDomains.Click += new System.EventHandler(this.btDeleteDomains_Click);
            // 
            // btEditDomains
            // 
            this.btEditDomains.Enabled = false;
            this.btEditDomains.Location = new System.Drawing.Point(6, 48);
            this.btEditDomains.Name = "btEditDomains";
            this.btEditDomains.Size = new System.Drawing.Size(184, 23);
            this.btEditDomains.TabIndex = 1;
            this.btEditDomains.Text = "Изменить";
            this.btEditDomains.UseVisualStyleBackColor = true;
            this.btEditDomains.Click += new System.EventHandler(this.btEditDomains_Click);
            // 
            // btAddDomains
            // 
            this.btAddDomains.Location = new System.Drawing.Point(6, 19);
            this.btAddDomains.Name = "btAddDomains";
            this.btAddDomains.Size = new System.Drawing.Size(184, 23);
            this.btAddDomains.TabIndex = 0;
            this.btAddDomains.Text = "Добавить";
            this.btAddDomains.UseVisualStyleBackColor = true;
            this.btAddDomains.Click += new System.EventHandler(this.btAddDomains_Click);
            // 
            // mstFile
            // 
            this.mstFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstNew,
            this.mstOpen,
            this.mstSave,
            this.mstSaveAs,
            this.mstExit});
            this.mstFile.Name = "mstFile";
            this.mstFile.Size = new System.Drawing.Size(48, 20);
            this.mstFile.Text = "Файл";
            // 
            // mstNew
            // 
            this.mstNew.Name = "mstNew";
            this.mstNew.Size = new System.Drawing.Size(163, 22);
            this.mstNew.Text = "Новый";
            this.mstNew.Click += new System.EventHandler(this.mstNew_Click);
            // 
            // mstOpen
            // 
            this.mstOpen.Name = "mstOpen";
            this.mstOpen.Size = new System.Drawing.Size(163, 22);
            this.mstOpen.Text = "Открыть...";
            this.mstOpen.Click += new System.EventHandler(this.mstOpen_Click);
            // 
            // mstSave
            // 
            this.mstSave.Enabled = false;
            this.mstSave.Name = "mstSave";
            this.mstSave.Size = new System.Drawing.Size(163, 22);
            this.mstSave.Text = "Сохранить";
            this.mstSave.Click += new System.EventHandler(this.mstSave_Click);
            // 
            // mstSaveAs
            // 
            this.mstSaveAs.Enabled = false;
            this.mstSaveAs.Name = "mstSaveAs";
            this.mstSaveAs.Size = new System.Drawing.Size(163, 22);
            this.mstSaveAs.Text = "Сохранить как...";
            this.mstSaveAs.Click += new System.EventHandler(this.mstSaveAs_Click);
            // 
            // mstExit
            // 
            this.mstExit.Name = "mstExit";
            this.mstExit.Size = new System.Drawing.Size(163, 22);
            this.mstExit.Text = "Выход";
            this.mstExit.Click += new System.EventHandler(this.mstExit_Click);
            // 
            // mstConsult
            // 
            this.mstConsult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstBeginConsult,
            this.mstShowExplanation});
            this.mstConsult.Enabled = false;
            this.mstConsult.Name = "mstConsult";
            this.mstConsult.Size = new System.Drawing.Size(96, 20);
            this.mstConsult.Text = "Консультация";
            // 
            // mstBeginConsult
            // 
            this.mstBeginConsult.Name = "mstBeginConsult";
            this.mstBeginConsult.Size = new System.Drawing.Size(196, 22);
            this.mstBeginConsult.Text = "Начать консультацию";
            this.mstBeginConsult.Click += new System.EventHandler(this.mstBeginConsult_Click);
            // 
            // mstShowExplanation
            // 
            this.mstShowExplanation.Enabled = false;
            this.mstShowExplanation.Name = "mstShowExplanation";
            this.mstShowExplanation.Size = new System.Drawing.Size(196, 22);
            this.mstShowExplanation.Text = "Показать объяснение";
            this.mstShowExplanation.Click += new System.EventHandler(this.mstShowExplanation_Click);
            // 
            // msBar
            // 
            this.msBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstFile,
            this.mstConsult});
            this.msBar.Location = new System.Drawing.Point(0, 0);
            this.msBar.Name = "msBar";
            this.msBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msBar.Size = new System.Drawing.Size(800, 24);
            this.msBar.TabIndex = 0;
            this.msBar.Text = "menuStrip1";
            // 
            // formMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.msBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msBar;
            this.MaximizeBox = false;
            this.Name = "formMainForm";
            this.Text = "Качество образа жизни";
            this.tbMain.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.gbPremise.ResumeLayout(false);
            this.gbEditRules.ResumeLayout(false);
            this.tpVariables.ResumeLayout(false);
            this.gbVariablesDomainValue.ResumeLayout(false);
            this.gbQuestionTextVariables.ResumeLayout(false);
            this.gbEditVariables.ResumeLayout(false);
            this.tpDomains.ResumeLayout(false);
            this.gbDomainValue.ResumeLayout(false);
            this.gbEditDomains.ResumeLayout(false);
            this.msBar.ResumeLayout(false);
            this.msBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpVariables;
        private System.Windows.Forms.TabPage tpDomains;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.GroupBox gbEditRules;
        private System.Windows.Forms.GroupBox gbPremise;
        private System.Windows.Forms.ListView lvVariables;
        private System.Windows.Forms.ColumnHeader chEmptyVar;
        private System.Windows.Forms.ColumnHeader chNameVariables;
        private System.Windows.Forms.ColumnHeader chTypeVariables;
        private System.Windows.Forms.ColumnHeader chDomainVariables;
        private System.Windows.Forms.GroupBox gbQuestionTextVariables;
        private System.Windows.Forms.GroupBox gbEditVariables;
        private System.Windows.Forms.GroupBox gbDomainValue;
        private System.Windows.Forms.GroupBox gbEditDomains;
        private System.Windows.Forms.ListView lvDomains;
        private System.Windows.Forms.ColumnHeader chNameDomains;
        private System.Windows.Forms.Button btDeleteRules;
        private System.Windows.Forms.Button btEditRules;
        private System.Windows.Forms.Button btAddRules;
        private System.Windows.Forms.Button btDeleteVariables;
        private System.Windows.Forms.Button btEditVariables;
        private System.Windows.Forms.Button btAddVariables;
        private System.Windows.Forms.Button btDeleteDomains;
        private System.Windows.Forms.Button btEditDomains;
        private System.Windows.Forms.Button btAddDomains;
        private System.Windows.Forms.GroupBox gbVariablesDomainValue;
        private System.Windows.Forms.ListView lvRulesPremises;
        private System.Windows.Forms.ListView lvVariablesDomainValues;
        private System.Windows.Forms.RichTextBox rtbQuestionText;
        private System.Windows.Forms.ListView lvDomainValues;
        private System.Windows.Forms.ColumnHeader chVoidDomains;
        private System.Windows.Forms.ColumnHeader chColumn;
        public System.Windows.Forms.ColumnHeader chVoidRules;
        public System.Windows.Forms.ColumnHeader chNameRules;
        public System.Windows.Forms.ColumnHeader chDescriptionRules;
        private System.Windows.Forms.ToolStripMenuItem mstFile;
        private System.Windows.Forms.ToolStripMenuItem mstNew;
        private System.Windows.Forms.ToolStripMenuItem mstOpen;
        private System.Windows.Forms.ToolStripMenuItem mstSave;
        private System.Windows.Forms.ToolStripMenuItem mstSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mstExit;
        private System.Windows.Forms.ToolStripMenuItem mstConsult;
        private System.Windows.Forms.ToolStripMenuItem mstBeginConsult;
        private System.Windows.Forms.ToolStripMenuItem mstShowExplanation;
        private System.Windows.Forms.MenuStrip msBar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

