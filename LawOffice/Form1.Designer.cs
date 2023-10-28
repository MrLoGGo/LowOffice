namespace LawOffice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClientPage = new System.Windows.Forms.Panel();
            this.ClientPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddClient = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Employees = new System.Windows.Forms.Button();
            this.ProceduresBut = new System.Windows.Forms.Button();
            this.ClientsBut = new System.Windows.Forms.Button();
            this.CasesBut = new System.Windows.Forms.Button();
            this.CasesPage = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.EndLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StartLabel = new System.Windows.Forms.Label();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CaseLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.IdCaseLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestPage = new System.Windows.Forms.Panel();
            this.loliconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lawOfficeDataSet = new LawOffice.LawOfficeDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new LawOffice.LawOfficeDataSetTableAdapters.ClientsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPage.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CasesPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TestPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loliconBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawOfficeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPage
            // 
            this.ClientPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientPage.Controls.Add(this.ClientPanel);
            this.ClientPage.Controls.Add(this.AddClient);
            this.ClientPage.Location = new System.Drawing.Point(0, 24);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Size = new System.Drawing.Size(810, 487);
            this.ClientPage.TabIndex = 0;
            // 
            // ClientPanel
            // 
            this.ClientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClientPanel.AutoScroll = true;
            this.ClientPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ClientPanel.Location = new System.Drawing.Point(43, 79);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(725, 296);
            this.ClientPanel.TabIndex = 7;
            // 
            // AddClient
            // 
            this.AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClient.BackColor = System.Drawing.SystemColors.Control;
            this.AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddClient.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddClient.Location = new System.Drawing.Point(262, 406);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(277, 35);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "ADD";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_ClickAsync);
            // 
            // MainPage
            // 
            this.MainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Controls.Add(this.panel2);
            this.MainPage.Location = new System.Drawing.Point(0, 24);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(810, 487);
            this.MainPage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Law office";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Employees);
            this.panel2.Controls.Add(this.ProceduresBut);
            this.panel2.Controls.Add(this.ClientsBut);
            this.panel2.Controls.Add(this.CasesBut);
            this.panel2.Location = new System.Drawing.Point(75, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 253);
            this.panel2.TabIndex = 0;
            // 
            // Employees
            // 
            this.Employees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Employees.Location = new System.Drawing.Point(0, 166);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(661, 31);
            this.Employees.TabIndex = 3;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // ProceduresBut
            // 
            this.ProceduresBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProceduresBut.Location = new System.Drawing.Point(0, 129);
            this.ProceduresBut.Name = "ProceduresBut";
            this.ProceduresBut.Size = new System.Drawing.Size(661, 31);
            this.ProceduresBut.TabIndex = 2;
            this.ProceduresBut.Text = "Procedures";
            this.ProceduresBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProceduresBut.UseVisualStyleBackColor = true;
            this.ProceduresBut.Click += new System.EventHandler(this.ProceduresBut_Click);
            // 
            // ClientsBut
            // 
            this.ClientsBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsBut.Location = new System.Drawing.Point(0, 92);
            this.ClientsBut.Name = "ClientsBut";
            this.ClientsBut.Size = new System.Drawing.Size(661, 31);
            this.ClientsBut.TabIndex = 1;
            this.ClientsBut.Text = "Clients";
            this.ClientsBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsBut.UseVisualStyleBackColor = true;
            this.ClientsBut.Click += new System.EventHandler(this.ClientsBut_Click);
            // 
            // CasesBut
            // 
            this.CasesBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CasesBut.Location = new System.Drawing.Point(0, 55);
            this.CasesBut.Name = "CasesBut";
            this.CasesBut.Size = new System.Drawing.Size(661, 31);
            this.CasesBut.TabIndex = 0;
            this.CasesBut.Text = "Cases";
            this.CasesBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CasesBut.UseVisualStyleBackColor = true;
            this.CasesBut.Click += new System.EventHandler(this.CasesBut_Click);
            // 
            // CasesPage
            // 
            this.CasesPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CasesPage.Controls.Add(this.dateTimePicker2);
            this.CasesPage.Controls.Add(this.EndLabel);
            this.CasesPage.Controls.Add(this.dateTimePicker1);
            this.CasesPage.Controls.Add(this.StartLabel);
            this.CasesPage.Controls.Add(this.ClientComboBox);
            this.CasesPage.Controls.Add(this.textBox2);
            this.CasesPage.Controls.Add(this.textBox1);
            this.CasesPage.Controls.Add(this.CaseLabel);
            this.CasesPage.Controls.Add(this.ClientLabel);
            this.CasesPage.Controls.Add(this.IdCaseLabel);
            this.CasesPage.Location = new System.Drawing.Point(0, 24);
            this.CasesPage.Name = "CasesPage";
            this.CasesPage.Size = new System.Drawing.Size(810, 487);
            this.CasesPage.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 195);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(335, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(29, 198);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(26, 13);
            this.EndLabel.TabIndex = 9;
            this.EndLabel.Text = "End";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(29, 171);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(29, 13);
            this.StartLabel.TabIndex = 7;
            this.StartLabel.Text = "Start";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(75, 63);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(335, 21);
            this.ClientComboBox.Sorted = true;
            this.ClientComboBox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 73);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 3;
            // 
            // CaseLabel
            // 
            this.CaseLabel.AutoSize = true;
            this.CaseLabel.Location = new System.Drawing.Point(29, 93);
            this.CaseLabel.Name = "CaseLabel";
            this.CaseLabel.Size = new System.Drawing.Size(31, 13);
            this.CaseLabel.TabIndex = 2;
            this.CaseLabel.Text = "Case";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(29, 66);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(33, 13);
            this.ClientLabel.TabIndex = 1;
            this.ClientLabel.Text = "Client";
            // 
            // IdCaseLabel
            // 
            this.IdCaseLabel.AutoSize = true;
            this.IdCaseLabel.Location = new System.Drawing.Point(29, 40);
            this.IdCaseLabel.Name = "IdCaseLabel";
            this.IdCaseLabel.Size = new System.Drawing.Size(44, 13);
            this.IdCaseLabel.TabIndex = 0;
            this.IdCaseLabel.Text = "ID case";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // TestPage
            // 
            this.TestPage.Controls.Add(this.dataGridView1);
            this.TestPage.Location = new System.Drawing.Point(0, 24);
            this.TestPage.Name = "TestPage";
            this.TestPage.Size = new System.Drawing.Size(810, 488);
            this.TestPage.TabIndex = 8;
            // 
            // loliconBindingSource
            // 
            this.loliconBindingSource.DataMember = "Lolicon";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // lawOfficeDataSet
            // 
            this.lawOfficeDataSet.DataSetName = "LawOfficeDataSet";
            this.lawOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.lawOfficeDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 511);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ClientPage);
            this.Controls.Add(this.CasesPage);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.TestPage);
            this.MinimumSize = new System.Drawing.Size(826, 550);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Law Office";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientPage.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.CasesPage.ResumeLayout(false);
            this.CasesPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TestPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loliconBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lawOfficeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ClientPage;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.FlowLayoutPanel ClientPanel;
        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClientsBut;
        private System.Windows.Forms.Button CasesBut;
        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button ProceduresBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CasesPage;
        private System.Windows.Forms.Label IdCaseLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label CaseLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Panel TestPage;
        private System.Windows.Forms.BindingSource loliconBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LawOfficeDataSet lawOfficeDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private LawOfficeDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}

