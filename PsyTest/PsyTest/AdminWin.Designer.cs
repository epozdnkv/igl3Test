namespace PsyTest
{
    partial class AdminWin
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
            this.tcAdminPanel = new System.Windows.Forms.TabControl();
            this.tpUsersList = new System.Windows.Forms.TabPage();
            this.dgvUsList = new System.Windows.Forms.DataGridView();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbResult = new System.Windows.Forms.TabPage();
            this.btnResult = new System.Windows.Forms.Button();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.tbQuestList = new System.Windows.Forms.TabPage();
            this.dgvQList = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.numQuest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResults = new System.Windows.Forms.Button();
            this.tcAdminPanel.SuspendLayout();
            this.tpUsersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsList)).BeginInit();
            this.tbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.tbQuestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdminPanel
            // 
            this.tcAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAdminPanel.Controls.Add(this.tpUsersList);
            this.tcAdminPanel.Controls.Add(this.tbResult);
            this.tcAdminPanel.Controls.Add(this.tbQuestList);
            this.tcAdminPanel.Location = new System.Drawing.Point(12, 27);
            this.tcAdminPanel.Name = "tcAdminPanel";
            this.tcAdminPanel.SelectedIndex = 0;
            this.tcAdminPanel.Size = new System.Drawing.Size(514, 304);
            this.tcAdminPanel.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcAdminPanel.TabIndex = 0;
            // 
            // tpUsersList
            // 
            this.tpUsersList.Controls.Add(this.dgvUsList);
            this.tpUsersList.Location = new System.Drawing.Point(4, 22);
            this.tpUsersList.Name = "tpUsersList";
            this.tpUsersList.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsersList.Size = new System.Drawing.Size(506, 278);
            this.tpUsersList.TabIndex = 0;
            this.tpUsersList.Text = "Список пользователей";
            this.tpUsersList.UseVisualStyleBackColor = true;
            // 
            // dgvUsList
            // 
            this.dgvUsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.lName});
            this.dgvUsList.Location = new System.Drawing.Point(3, 6);
            this.dgvUsList.Name = "dgvUsList";
            this.dgvUsList.Size = new System.Drawing.Size(500, 305);
            this.dgvUsList.TabIndex = 0;
            // 
            // fName
            // 
            this.fName.HeaderText = "Имя";
            this.fName.Name = "fName";
            this.fName.Width = 200;
            // 
            // lName
            // 
            this.lName.HeaderText = "Фамилия";
            this.lName.Name = "lName";
            this.lName.Width = 200;
            // 
            // tbResult
            // 
            this.tbResult.Controls.Add(this.btnResults);
            this.tbResult.Controls.Add(this.btnResult);
            this.tbResult.Controls.Add(this.cmbUserList);
            this.tbResult.Controls.Add(this.dgvResult);
            this.tbResult.Location = new System.Drawing.Point(4, 22);
            this.tbResult.Name = "tbResult";
            this.tbResult.Padding = new System.Windows.Forms.Padding(3);
            this.tbResult.Size = new System.Drawing.Size(506, 278);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "Ответы";
            this.tbResult.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(334, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(149, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Показать результаты";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // cmbUserList
            // 
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(7, 5);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(320, 21);
            this.cmbUserList.TabIndex = 1;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numQuest,
            this.answer});
            this.dgvResult.Location = new System.Drawing.Point(6, 33);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(477, 208);
            this.dgvResult.TabIndex = 0;
            // 
            // tbQuestList
            // 
            this.tbQuestList.Controls.Add(this.btnAdd);
            this.tbQuestList.Controls.Add(this.btnDel);
            this.tbQuestList.Controls.Add(this.tbQuestion);
            this.tbQuestList.Controls.Add(this.dgvQList);
            this.tbQuestList.Location = new System.Drawing.Point(4, 22);
            this.tbQuestList.Name = "tbQuestList";
            this.tbQuestList.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuestList.Size = new System.Drawing.Size(506, 278);
            this.tbQuestList.TabIndex = 2;
            this.tbQuestList.Text = "Список вопросов";
            this.tbQuestList.UseVisualStyleBackColor = true;
            // 
            // dgvQList
            // 
            this.dgvQList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Question});
            this.dgvQList.Location = new System.Drawing.Point(6, 6);
            this.dgvQList.Name = "dgvQList";
            this.dgvQList.Size = new System.Drawing.Size(493, 197);
            this.dgvQList.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.Width = 50;
            // 
            // Question
            // 
            this.Question.HeaderText = "Вопрос";
            this.Question.Name = "Question";
            this.Question.Width = 400;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBack
            // 
            this.tsmiBack.Name = "tsmiBack";
            this.tsmiBack.Size = new System.Drawing.Size(51, 20);
            this.tsmiBack.Text = "Назад";
            this.tsmiBack.Click += new System.EventHandler(this.tsmiBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить вопрос";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(147, 235);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(134, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Удалить вопрос";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(7, 209);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(493, 20);
            this.tbQuestion.TabIndex = 4;
            // 
            // numQuest
            // 
            this.numQuest.HeaderText = "Номер вопроса";
            this.numQuest.Name = "numQuest";
            this.numQuest.Width = 200;
            // 
            // answer
            // 
            this.answer.HeaderText = "Ответ";
            this.answer.Name = "answer";
            this.answer.Width = 200;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(6, 247);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(175, 23);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Посмотреть результаты";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // AdminWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 343);
            this.Controls.Add(this.tcAdminPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminWin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.AdminWin_Load);
            this.tcAdminPanel.ResumeLayout(false);
            this.tpUsersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsList)).EndInit();
            this.tbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.tbQuestList.ResumeLayout(false);
            this.tbQuestList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdminPanel;
        private System.Windows.Forms.TabPage tpUsersList;
        private System.Windows.Forms.TabPage tbResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.DataGridView dgvUsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TabPage tbQuestList;
        private System.Windows.Forms.DataGridView dgvQList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numQuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.Button btnResults;
    }
}