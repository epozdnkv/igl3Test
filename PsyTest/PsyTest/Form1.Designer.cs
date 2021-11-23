namespace PsyTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.tsmiMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFullInf = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumQuest = new System.Windows.Forms.Label();
            this.tsmiCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAnswer.SuspendLayout();
            this.tsmiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn1.Location = new System.Drawing.Point(102, 25);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(31, 17);
            this.rbtn1.TabIndex = 3;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "1";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2.Location = new System.Drawing.Point(161, 25);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(31, 17);
            this.rbtn2.TabIndex = 4;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "2";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3.Location = new System.Drawing.Point(220, 25);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(31, 17);
            this.rbtn3.TabIndex = 5;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "3";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn4.Location = new System.Drawing.Point(279, 25);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(31, 17);
            this.rbtn4.TabIndex = 6;
            this.rbtn4.TabStop = true;
            this.rbtn4.Text = "4";
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn5.Location = new System.Drawing.Point(338, 25);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(31, 17);
            this.rbtn5.TabIndex = 7;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "5";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(13, 34);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(459, 149);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(396, 276);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "След.";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(13, 276);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Пред.";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.rbtn4);
            this.gbAnswer.Controls.Add(this.rbtn1);
            this.gbAnswer.Controls.Add(this.rbtn2);
            this.gbAnswer.Controls.Add(this.rbtn3);
            this.gbAnswer.Controls.Add(this.rbtn5);
            this.gbAnswer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAnswer.Location = new System.Drawing.Point(14, 198);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(458, 61);
            this.gbAnswer.TabIndex = 11;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Выберите ответ";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiM,
            this.tsmiCloseApp});
            this.tsmiMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(484, 24);
            this.tsmiMenu.TabIndex = 12;
            this.tsmiMenu.Text = "menuStrip1";
            // 
            // tsmiM
            // 
            this.tsmiM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFullInf});
            this.tsmiM.Name = "tsmiM";
            this.tsmiM.Size = new System.Drawing.Size(53, 20);
            this.tsmiM.Text = "Меню";
            // 
            // tsmiFullInf
            // 
            this.tsmiFullInf.Name = "tsmiFullInf";
            this.tsmiFullInf.Size = new System.Drawing.Size(191, 22);
            this.tsmiFullInf.Text = "Подробнее о шкалах";
            this.tsmiFullInf.Click += new System.EventHandler(this.tsmiFullInf_Click);
            // 
            // lblNumQuest
            // 
            this.lblNumQuest.AutoSize = true;
            this.lblNumQuest.Location = new System.Drawing.Point(17, 281);
            this.lblNumQuest.Name = "lblNumQuest";
            this.lblNumQuest.Size = new System.Drawing.Size(0, 13);
            this.lblNumQuest.TabIndex = 13;
            // 
            // tsmiCloseApp
            // 
            this.tsmiCloseApp.Name = "tsmiCloseApp";
            this.tsmiCloseApp.Size = new System.Drawing.Size(65, 20);
            this.tsmiCloseApp.Text = "Закрыть";
            this.tsmiCloseApp.Click += new System.EventHandler(this.tsmiCloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lblNumQuest);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tsmiMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.tsmiMenu;
            this.Name = "Form1";
            this.Opacity = 0.995D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.tsmiMenu.ResumeLayout(false);
            this.tsmiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.MenuStrip tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiM;
        private System.Windows.Forms.ToolStripMenuItem tsmiFullInf;
        private System.Windows.Forms.Label lblNumQuest;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseApp;
    }
}

