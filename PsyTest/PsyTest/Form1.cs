using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PsyTest
{
    public partial class Form1 : Form
    {
        public Form1(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        int idUser = 0;
        int idQuest = 0;
        int Answ = 0;//хранит номер ответа

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNext.Text = "Начать";
            btnBack.Visible = false;
            lblQuestion.Text = "Начните тестирование";

            int questCount = 0;
            int ansCount = 0;

            string req = "SELECT COUNT(*) FROM questions";
            DB db = new DB();
            questCount = Convert.ToInt16(db.sqlRequestSELECT(req));
            db.Close();

            string req1 = "SELECT COUNT(*) FROM answer WHERE id_user = " + idUser + ";";
            DB db1 = new DB();
            ansCount = Convert.ToInt16(db1.sqlRequestSELECT(req1));
            db1.Close();

            if (ansCount < questCount)
            {
                string req3 = "DELETE FROM answer WHERE id_user = " + idUser + ";";
                DB db3 = new DB();
                db3.sqlRequestDELETE(req3);
                db3.Close();
            }

            //проверка на прохождение теста
            if (ansCount == questCount)
            {
                DialogResult result = MessageBox.Show("Вы прошли тест полностью. Желаете пройти его сначала?", "Внимание!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string req2 = "DELETE FROM answer WHERE id_user = " + idUser + ";";
                    DB db2 = new DB();
                    db2.sqlRequestDELETE(req2);
                    db2.Close();
                }
                else 
                {
                    Authorization auth = new Authorization();
                    auth.Show();
                    this.Close();
                }
            }
        }

        #region buttons

        public int numQuest = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                
                Answ = checkRbtn();
                btnNext.Text = "След.";

                if (idQuest > 0 && rbtn1.Checked == false && rbtn2.Checked == false && rbtn3.Checked == false && rbtn4.Checked == false && rbtn5.Checked == false)
                {
                    MessageBox.Show("Выбирете один из вариантов ответа", "Ошибка");
                }
                else
                {
                    idQuest += 1;
                    lblNumQuest.Text = "Вопрос " + idQuest.ToString() + "/109";
                    string req = "SELECT content FROM questions WHERE id = " + idQuest.ToString();

                    

                    DB db = new DB();
                    lblQuestion.Text = db.sqlRequestSELECT(req);
                    db.Close();
                    if (idQuest > 1)
                    {
                        req = "INSERT INTO answer (id_user, questId, quest) VALUES (" + idUser + ", " + numQuest + "," + Answ + ")";
                        db.sqlRequestINSERT(req);
                        db.Close();
                    }
                    cleanRbtn();
                    numQuest += 1;
                }
            }
            catch
            {
                if (MessageBox.Show("Тест успешно пройден", "Сообщение") == DialogResult.OK)
                {
                    DB db = new DB();
                    string req = "INSERT INTO answer (id_user, quest) VALUES (" + idUser + ", " + Answ + ")";
                    db.sqlRequestINSERT(req);
                    db.Close();

                    Authorization auth = new Authorization();
                    auth.Show();
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*if (idQuest > 1)
            {
                idQuest -= 1;
                cleanRbtn();
                string req = "SELECT content FROM questions WHERE id = " + idQuest.ToString();
                sqlRequestSELECT(req);
            }
            else
            {
                btnNext.Text = "Начать";
                btnBack.Visible = false;
                idQuest = 0;
                cleanRbtn();
                lblQuestion.Text = "Начните тестирование";
            }
             */
        }

        private void tsmiFullInf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция: Пожалуйста, определите, в какой мере Вам свойственны перечисленные ниже психологические особенности.\nВыбирайте свой ответ по Шкале возможных ответов:\n1 – в очень малой степени;\n2 – в малой степени;\n3 – в средней степени;\n4 – в большой степени;\n5 – в очень большой степени.\n\nНе пропускайте ни одного пункта!  Тайна Ваших ответов гарантируется.", "Информация о шкалах");
        }

        private void tsmiCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion buttons

        #region methods
        int checkRbtn()
        {
            int answ = 0;
            RadioButton[] rbtn = new RadioButton[5];
            rbtn[0] = rbtn1;
            rbtn[1] = rbtn2;
            rbtn[2] = rbtn3;
            rbtn[3] = rbtn4;
            rbtn[4] = rbtn5;

            for (int i = 0; i < rbtn.Length; i++)
            {
                if (rbtn[i].Checked == true)
                {
                    answ = Convert.ToInt16(rbtn[i].Text);
                    break;
                }
            }
            return answ;
        }
        void cleanRbtn()
        {
            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            rbtn4.Checked = false;
            rbtn5.Checked = false;
        }
        #endregion methods

    }
}
