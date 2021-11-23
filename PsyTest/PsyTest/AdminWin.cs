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
    public partial class AdminWin : Form
    {
        public AdminWin()
        {
            InitializeComponent();
        }

        private void tsmiBack_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.Show();
            this.Close();
        }

        private void AdminWin_Load(object sender, EventArgs e)
        {

            DB db = new DB();
            db.Connection();
            MySqlCommand command = new MySqlCommand("SELECT firstname, lastname FROM users", db.conn);
            command.ExecuteNonQuery();
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                dgvUsList.Rows.Add(read[0], read[1]);
                cmbUserList.Items.Add(Convert.ToString(read["lastname"]));
            }
            db.Close();

            DB db1 = new DB();
            db.Connection();

            MySqlCommand command1 = new MySqlCommand("SELECT id, content FROM questions", db.conn);

            command.ExecuteNonQuery();
            MySqlDataReader read1 = command1.ExecuteReader();

            while(read1.Read())
            {
                dgvQList.Rows.Add(read1[0], read1[1]);
            }

            read1.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Connection();
            MySqlCommand command = new MySqlCommand("INSERT INTO questions (content) VALUES(@content)", db.conn);
            command.Parameters.AddWithValue("content", Convert.ToString(tbQuestion.Text)); 
            command.ExecuteNonQuery();

            tbQuestion.Text = "";
            dgvQList.Rows.Clear();
            MySqlCommand command2 = new MySqlCommand("SELECT id, content FROM questions", db.conn);
            command.ExecuteNonQuery();
            MySqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                dgvQList.Rows.Add(read2[0], read2[1]);
            }
            read2.Close();
            db.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Connection();
            MySqlCommand com = new MySqlCommand("DELETE FROM questions WHERE id=@id", db.conn);

            int id = int.Parse(dgvQList.CurrentRow.Cells[0].Value.ToString()); 
            com.Parameters.AddWithValue("@id", id);
            com.ExecuteNonQuery();
            dgvQList.Rows.Clear();
            MySqlCommand command = new MySqlCommand("SELECT id, content FROM questions", db.conn);
            command.ExecuteNonQuery();
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                dgvQList.Rows.Add(read[0], read[1]);
            }
            db.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            int userId;
            string reqIdUser = @"SELECT id FROM users WHERE lastname = '" + cmbUserList.SelectedItem + "';";
           
            DB dbID = new DB();
            userId = Convert.ToInt16(dbID.sqlRequestSELECT(reqIdUser));
            dbID.Close();

            string reqAns = "SELECT quest FROM answer WHERE id_user = " + userId.ToString() + ";";
            
            DB dbAnsw = new DB();

            dbAnsw.sqlRequestSELECT(reqAns);

            MySqlCommand command = new MySqlCommand(reqAns, dbAnsw.conn);
            MySqlDataReader reader = command.ExecuteReader();
            int countFlag = 1;
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = "№ " + countFlag++.ToString();
                data[data.Count - 1][1] = reader[0].ToString();
            }

            reader.Close();
            dbAnsw.Close();

            foreach (string[] s in data)
            dgvResult.Rows.Add(s);

        }

        public double checkAns(double n)
        {
            switch (Convert.ToInt16(n))
            {
                case 1: n = 5;
                    break;
                case 2: n = 4;
                    break;
                case 3: n = 3;
                    break;
                case 4: n = 2;
                    break;
                case 5: n = 1;
                    break;
            }
            return n;
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            string mess = "";
            #region middleCrit
            //Шкала лжи
            double l = (Convert.ToDouble(dgvResult.Rows[5].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[17].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[38].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[49].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[70].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[91].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[102].Cells[1].Value)) / 7;

            if (l > 4)
            {
                mess += "Данные не достоверные\n\n";
            }
            else mess += "Данные достоверны\n\n";

            //Ценности личностной гармонии ЦГЛ 
            double cgl = (Convert.ToDouble(dgvResult.Rows[0].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[13].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[26].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[39].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[52].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[64].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[75].Cells[1].Value)) / 7;

            if (cgl <= 3.83) mess += "Ценности личностной гармонии ниже уровня нормы\n\n";
            else mess += "Ценности личностной гармонии в норме\n\n";

            //Ценности духовные ЦД
            double cd = (Convert.ToDouble(dgvResult.Rows[1].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[14].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[27].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[40].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[53].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[65].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[76].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[77].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[82].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[86].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[95].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[96].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[98].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[104].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[105].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[106].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[107].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[108].Cells[1].Value))/18;

            if (cd <= 3.8) mess += "Духовные ценности ниже уровня нормы\n\n";
            else mess += "Духовные ценности в норме\n\n";

            //Образ жизни (его оптимальность) ОЖ
            double ozh = (Convert.ToDouble(dgvResult.Rows[2].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[15].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[28].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[41].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[54].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[1].Cells[1].Value)))/6;

            if (ozh <= 3.77) mess += "Оптимальный образ жизни ниже уровня нормы\n\n";
            else mess += "Оптимальный образ жизни в норме\n\n";

            //Саморегуляция эмоций и др. СР 
            double sr = (Convert.ToDouble(dgvResult.Rows[3].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[16].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[29].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[42].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[55].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[67].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[78].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[85].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[89].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[92].Cells[1].Value))/10;

            if (sr <= 3.65) mess += "Плохая саморегуляция\n\n";
            else mess += "Хорошая саморегуляция\n\n";

            //Конструктивность общения КО 
            double ko = (Convert.ToDouble(dgvResult.Rows[4].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[18].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[30].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[43].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[56].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[68].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[88].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[90].Cells[1].Value))/8;

            if (ko <= 3.79) mess += "Конструктивность общения ниже уровня нормы\n\n";
            else mess += "Конструктивность общения в норме\n\n";

            //Самогармонизация личности СГ 
            double sg = (Convert.ToDouble(dgvResult.Rows[6].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[19].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[31].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[44].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[57].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[69].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[79].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[80].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[84].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[87].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[94].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[97].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[99].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[103].Cells[1].Value))/14;

            if (sg <= 3.66) mess += "Плохая самоорганизация\n\n";
            else mess += "Хорошая самоорганизация\n\n";

            //Умеренность силы желаний и достижений Ум
            double um = (Convert.ToDouble(dgvResult.Rows[7].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[20].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[32].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[45].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[58].Cells[1].Value)) / 5;

            if (um <= 3.57) mess += "Умеренность силы желаний и достижений ниже уровня нормы\n\n";
            else mess += "Умеренность силы желаний и достижений в норме\n\n";

            //Самостоятельность (опора на себя, внутренний локус контроля) Сам 
            double sam = (Convert.ToDouble(dgvResult.Rows[8].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[21].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[33].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[46].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[59].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[71].Cells[1].Value)) / 6;

            if (sam <= 3.72) mess += "Плохая самостоятельность\n\n";
            else mess += "Хорошая самостоятельность\n\n";

            //Удовлетворённость жизнью и отношениями с людьми Уд 
            double ud = (Convert.ToDouble(dgvResult.Rows[9].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[22].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[34].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[47].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[60].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[72].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[81].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[83].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[100].Cells[1].Value))) / 9;

            if (ud <= 3.74) mess += "Плохая удовлетворённость жизнью и отношениями с людьми\n\n";
            else mess += "Хорошая удовлетворённость жизнью и отношениями с людьми\n\n";

            //Жизненное самоопределение ЖСО 
            double zhso = (Convert.ToDouble(dgvResult.Rows[10].Cells[1].Value) + checkAns(Convert.ToDouble(dgvResult.Rows[23].Cells[1].Value)) + Convert.ToDouble(dgvResult.Rows[35].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[61].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[73].Cells[1].Value)) / 5;

            if (zhso <= 3.48) mess += "Жизненное самоопределение ниже уровня нормы\n\n";
            else mess += "Жизненное самоопределение в норме\n\n";

            //Жизненная самореализация ЖСР 
            double zhsr = (Convert.ToDouble(dgvResult.Rows[11].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[24].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[36].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[50].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[62].Cells[1].Value)) / 5;

            if (zhsr <= 3.35) mess += "Жизненная самореализация ниже уровня нормы\n\n";
            else mess += "Жизненная самореализация в норме\n\n";

            //Позитивность самооценки ПС 
            double ps = (Convert.ToDouble(dgvResult.Rows[12].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[25].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[37].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[48].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[51].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[63].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[74].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[93].Cells[1].Value) + Convert.ToDouble(dgvResult.Rows[101].Cells[1].Value)) / 9;

            if (ps <= 3.87) mess += "Позитивность самооценки ниже уровня нормы\n\n";
            else mess += "Позитивность самооценки в норме\n\n";

            //Интегральная гармоничность личности ИГЛ
            double igl = 0;
            for (int i = 0; i < 109; i++)
            {
                if (i == 5 || i == 17 || i == 38 || i == 49 || i == 70 || i == 91 || i == 102)
                {
                    
                }
                else
                {
                    igl += Convert.ToDouble(dgvResult.Rows[i].Cells[1].Value);
                }
            }
            igl = igl / 102;

            if (igl <= 3.69) mess += "Интегральная гармоничность личности ниже уровня нормы\n\n";
            else mess += "Интегральная гармоничность личности в норме\n\n";

            #endregion middleCrit

            MessageBox.Show(mess, "Личностные харакетиристики");
        }

    }
}
