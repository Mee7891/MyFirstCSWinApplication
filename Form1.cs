using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyFirstCSWinApplication
{
    public partial class MainForm : Form
    {
        //Простые множители
        PrinterEnumToStr<int> printer = new PrinterEnumToStr<int>();
        //--------------------------------------------------------------------
        //Генератор сл. чисел и пароли
        Random rand = new Random();
        string specSym = "_@(#*&$?^~";
        //--------------------------------------------------------------------
        //Блокнот
        string filename;
        bool unsaved = false;
        //--------------------------------------------------------------------
        //Конвертер
        Dictionary<string, double> metrica = new Dictionary<string, double>();
        string[] energyUnits   = { "J", "erg",          "eV" };
        double[] energyMetrics = {   1,  1e-7, 1.6021766e-19 };
        string[] lengthUnits   = { "cm", "m", "ft", "inch", "mile"   };
        double[] lengthMetrics = {   1, 100, 30.48,   2.54, 160934.4 };
        string[] bUnits        = { "T", "G" };
        double[] bMetrics      = {   1, 1e-4 };
        string[] massUnits     = {"g", "kg", "pond", "uncia" };
        double[] massMetrics   = {  1, 1000, 453.59,  28.35  };
        //--------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Doc files(*.doc)|*.doc|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Doc files(*.doc)|*.doc|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.*";
        }

        //Из меню, справка и закрытие, события формы
        private void tSMIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlSMIAboutProgram_Click(object sender, EventArgs e)
        {
            const string inf = "Программа, разработанная в рамках прохождения видеокурса\n\"C# Мини-программы\" на GeekBrains.\nСтудент: Дубовик М.Н.";
            MessageBox.Show(inf, "О программе:");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chLBPassSymb.SetItemChecked(0, true);
            chLBPassSymb.SetItemChecked(1, true);

            cBMetrica_TextChanged(this, new EventArgs());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsaved && rTBNotePad.TextLength != 0)
            {
                DialogResult result =
                    MessageBox.Show("В блокноте имеются несохраненные записи. Выполнить сохранение?", "Закрытие программы", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            tSMISave_Click(this, new EventArgs());
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
            }
        }

        private void tCMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tCMain.SelectedIndex)
            {
                case 2:           //Блокнот
                    {
                        TSMIToNotePad.Enabled = false;
                        break;
                    }
                case 4:           //Конвертер
                    {
                        TSMIToNotePad.Enabled = false;
                        break;
                    }
                default:
                    {
                        TSMIToNotePad.Enabled = true;
                        break;
                    }
            }
        }
        //--------------------------------------------------------------------------

        //Простые множители
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(tBNumber.Text);
            }
            catch
            {
                n = 2;
                tBNumber.Text = n.ToString();
            }

            MathUtils.SimpleFactors(n, !(chBNoRepets.Checked), printer);

            lbAnswer.Text = printer.ResultStr;
        }

        private void chBNoRepets_CheckedChanged(object sender, EventArgs e)
        {
            if (chBNoRepets.Checked)
            {
                string[] temp = StringUtils.RemoveRepetsArr(lbAnswer.Text, ' ');

                lbAnswer.Text = "";

                foreach (string t in temp)
                    lbAnswer.Text += t;
            }
            else
            {
                btnCalc_Click(this, new EventArgs());
            }
        }
        //-------------------------------------------------------------------------

        //Генератор случайных чисел
        private void btnGetRand_Click(object sender, EventArgs e)
        {
            int n;
            int min = (int)nUDMin.Value;
            int max = (int)nUDMax.Value;

            if(min > max)
            {
                MathUtils.Swap<int>(ref min, ref max);
                nUDMin.Value = min;
                nUDMax.Value = max;
            }

            n = rand.Next(min, max + 1);
            lbRandValue.Text = n.ToString();

            if(!chBRandNoRepets.Checked)
                tBRandom.AppendText(string.Format("{0}\n", n));
            else
            {
                int m = tBRandom.Text.Select(c => c).Where(c => c == '\n').Count();
                if (m != max - min + 1) //если все возможные еще не были
                { 
                    while (tBRandom.Text.IndexOf(n.ToString()) != -1 )
                        n = rand.Next(min, max + 1);

                    tBRandom.AppendText(string.Format("{0}\n", n));
                }
            }
        }

        private void btnRandClear_Click(object sender, EventArgs e)
        {
            tBRandom.Clear();
        }

        private void btnRandCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tBRandom.Text);
        }

        private void chBRandNoRepets_CheckedChanged(object sender, EventArgs e)
        {
            if (chBRandNoRepets.Checked)
            {
                string[] temp = StringUtils.RemoveRepetsArr(tBRandom.Text, '\n');

                tBRandom.Clear();

                foreach (string t in temp)
                    tBRandom.AppendText(t);
            }
        }
        //---------------------------------------------------------------------------

        //Блокнот
        private void tSMIDate_Click(object sender, EventArgs e)
        {
            rTBNotePad.AppendText(DateTime.Now.ToShortDateString() + '\n');
        }

        private void tSMITime_Click(object sender, EventArgs e)
        {
            rTBNotePad.AppendText(DateTime.Now.ToShortTimeString() + '\n');
        }

        private bool GetFileNameToSave()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return false;

            filename = saveFileDialog1.FileName;
            return true;
        }

        private void tSMISave_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename != null || GetFileNameToSave())
                {
                    File.WriteAllText(filename, rTBNotePad.Text);
                    unsaved = false;
                }

            }
            catch
            {
                throw new Exception("Ошибка сохранения!");
            }
        }

        private void tSMISaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetFileNameToSave())
                {
                    File.WriteAllText(filename, rTBNotePad.Text);
                    unsaved = false;
                }
            }
            catch
            {
                throw new Exception("Ошибка сохранения!");
            }
        }

        private void tSMIOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

                filename = openFileDialog1.FileName;
                rTBNotePad.Text = File.ReadAllText(filename);
            }
            catch
            {
                throw new Exception("Ошибка при открытии файла!");
            }
        }

        private void rTBNotePad_TextChanged(object sender, EventArgs e)
        {
            unsaved = true;
        }

        private void TSMIToNotePad_Click(object sender, EventArgs e)
        {
            switch (tCMain.SelectedIndex)
            {
                case 0:       //Простые множители
                    {
                        rTBNotePad.AppendText(lbAnswer.Text);
                        break;
                    }
                case 1:      //Случайные числа
                    {
                        rTBNotePad.AppendText(tBRandom.Text);
                        break;
                    }
                case 3:           //Пароли
                    {
                        rTBNotePad.AppendText(tBPass.Text);
                        break;
                    }
            }
        }
        //--------------------------------------------------------------------

        //Генератор паролей
        private void btnGenPass_Click(object sender, EventArgs e)
        {
            if (chLBPassSymb.CheckedItems.Count == 0) return;

            StringBuilder password = new StringBuilder();
            int n;
            string s;

            for(int i=0; i<nUDPass.Value; i++)
            {
                n = rand.Next(chLBPassSymb.CheckedItems.Count);
                s = chLBPassSymb.CheckedItems[n].ToString();
                switch(s)
                {
                    case "Цифры":
                        {
                            password.Append(rand.Next(10));
                            break;
                        }
                    case "Прописные буквы":
                        {
                            password.Append(Convert.ToChar(rand.Next(65, 88)));
                            break;
                        }
                    case "Строчные буквы":
                        {
                            password.Append(Convert.ToChar(rand.Next(97, 122)));
                            break;
                        }
                    default:
                        {
                            password.Append(specSym[rand.Next(specSym.Length)]);
                            break;
                        }
                }    
            }

            tBPass.Clear();
            tBPass.AppendText(password.ToString());
            Clipboard.SetText(tBPass.Text);
        }
        //---------------------------------------------------------------------

        //Конвертер
        private void cBMetrica_TextChanged(object sender, EventArgs e)
        {
            cBFrom.Items.Clear();
            cBTo.Items.Clear();
            switch (cBMetrica.Text)
            {
                case "Энергия":
                    {
                        cBFrom.Items.AddRange(energyUnits);
                        cBTo.Items.AddRange(energyUnits);
                        ConvertorCollectionsUtils.FillDictionary(metrica, energyMetrics, energyUnits);
                        break;
                    }
                case "Длина":
                    {
                        cBFrom.Items.AddRange(lengthUnits);
                        cBTo.Items.AddRange(lengthUnits);
                        ConvertorCollectionsUtils.FillDictionary(metrica, lengthMetrics, lengthUnits);
                        break;
                    }
                case "Масса":
                    {
                        cBFrom.Items.AddRange(massUnits);
                        cBTo.Items.AddRange(massUnits);
                        ConvertorCollectionsUtils.FillDictionary(metrica, massMetrics, massUnits);
                        break;
                    }
                case "Индукция магнитного поля":
                    {
                        cBFrom.Items.AddRange(bUnits);
                        cBTo.Items.AddRange(bUnits);
                        ConvertorCollectionsUtils.FillDictionary(metrica, bMetrics, bUnits);
                        break;
                    }
            }

            cBFrom.Text = cBFrom.Items[0].ToString();
            cBTo.Text = cBTo.Items[0].ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = cBFrom.Text;
            cBFrom.Text = cBTo.Text;
            cBTo.Text = temp;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double m1 = metrica[cBFrom.Text];
                double m2 = metrica[cBTo.Text];
                double n = double.Parse(tBFrom.Text);
                tBTo.Text = (n * m1 / m2).ToString();
            }
            catch
            {
                cBFrom.Text = cBFrom.Items[0].ToString();
                cBTo.Text = cBTo.Items[0].ToString();
                tBFrom.Text = "1";
                btnConvert_Click(this, new EventArgs());
            }
        }
        //---------------------------------------------------------------------
    }
}
