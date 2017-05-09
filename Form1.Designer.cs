namespace MyFirstCSWinApplication
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMINotePad = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMITime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMISaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlSMIAboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.tCMain = new System.Windows.Forms.TabControl();
            this.tPSimpMults = new System.Windows.Forms.TabPage();
            this.chBNoRepets = new System.Windows.Forms.CheckBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNumber = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tPRandNum = new System.Windows.Forms.TabPage();
            this.chBRandNoRepets = new System.Windows.Forms.CheckBox();
            this.btnRandCopy = new System.Windows.Forms.Button();
            this.btnRandClear = new System.Windows.Forms.Button();
            this.tBRandom = new System.Windows.Forms.TextBox();
            this.btnGetRand = new System.Windows.Forms.Button();
            this.lbRandValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDMax = new System.Windows.Forms.NumericUpDown();
            this.nUDMin = new System.Windows.Forms.NumericUpDown();
            this.tPNotePad = new System.Windows.Forms.TabPage();
            this.rTBNotePad = new System.Windows.Forms.RichTextBox();
            this.tPPass = new System.Windows.Forms.TabPage();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nUDPass = new System.Windows.Forms.NumericUpDown();
            this.chLBPassSymb = new System.Windows.Forms.CheckedListBox();
            this.tPConw = new System.Windows.Forms.TabPage();
            this.cBMetrica = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cBTo = new System.Windows.Forms.ComboBox();
            this.cBFrom = new System.Windows.Forms.ComboBox();
            this.tBTo = new System.Windows.Forms.TextBox();
            this.tBFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIToNotePad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tCMain.SuspendLayout();
            this.tPSimpMults.SuspendLayout();
            this.tPRandNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMin)).BeginInit();
            this.tPNotePad.SuspendLayout();
            this.tPPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPass)).BeginInit();
            this.tPConw.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIFile,
            this.tSMINotePad,
            this.tSMIHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tSMIFile
            // 
            this.tSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIExit});
            this.tSMIFile.Name = "tSMIFile";
            this.tSMIFile.Size = new System.Drawing.Size(48, 20);
            this.tSMIFile.Text = "Файл";
            // 
            // tSMIExit
            // 
            this.tSMIExit.Name = "tSMIExit";
            this.tSMIExit.Size = new System.Drawing.Size(108, 22);
            this.tSMIExit.Text = "Выход";
            this.tSMIExit.Click += new System.EventHandler(this.tSMIExit_Click);
            // 
            // tSMINotePad
            // 
            this.tSMINotePad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIDate,
            this.tSMITime,
            this.toolStripMenuItem1,
            this.tSMISave,
            this.tSMISaveAs,
            this.tSMIOpen,
            this.toolStripMenuItem2,
            this.TSMIToNotePad});
            this.tSMINotePad.Name = "tSMINotePad";
            this.tSMINotePad.Size = new System.Drawing.Size(65, 20);
            this.tSMINotePad.Text = "Блокнот";
            // 
            // tSMIDate
            // 
            this.tSMIDate.Name = "tSMIDate";
            this.tSMIDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tSMIDate.Size = new System.Drawing.Size(236, 22);
            this.tSMIDate.Text = "Добавить дату";
            this.tSMIDate.Click += new System.EventHandler(this.tSMIDate_Click);
            // 
            // tSMITime
            // 
            this.tSMITime.Name = "tSMITime";
            this.tSMITime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tSMITime.Size = new System.Drawing.Size(236, 22);
            this.tSMITime.Text = "Добавить время";
            this.tSMITime.Click += new System.EventHandler(this.tSMITime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // tSMISave
            // 
            this.tSMISave.Name = "tSMISave";
            this.tSMISave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tSMISave.Size = new System.Drawing.Size(236, 22);
            this.tSMISave.Text = "Сохранить";
            this.tSMISave.Click += new System.EventHandler(this.tSMISave_Click);
            // 
            // tSMISaveAs
            // 
            this.tSMISaveAs.Name = "tSMISaveAs";
            this.tSMISaveAs.Size = new System.Drawing.Size(236, 22);
            this.tSMISaveAs.Text = "Сохранить как";
            this.tSMISaveAs.Click += new System.EventHandler(this.tSMISaveAs_Click);
            // 
            // tSMIOpen
            // 
            this.tSMIOpen.Name = "tSMIOpen";
            this.tSMIOpen.Size = new System.Drawing.Size(236, 22);
            this.tSMIOpen.Text = "Открыть";
            this.tSMIOpen.Click += new System.EventHandler(this.tSMIOpen_Click);
            // 
            // tSMIHelp
            // 
            this.tSMIHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlSMIAboutProgramm});
            this.tSMIHelp.Name = "tSMIHelp";
            this.tSMIHelp.Size = new System.Drawing.Size(68, 20);
            this.tSMIHelp.Text = "Помощь";
            // 
            // tlSMIAboutProgramm
            // 
            this.tlSMIAboutProgramm.Name = "tlSMIAboutProgramm";
            this.tlSMIAboutProgramm.Size = new System.Drawing.Size(149, 22);
            this.tlSMIAboutProgramm.Text = "О программе";
            this.tlSMIAboutProgramm.Click += new System.EventHandler(this.tlSMIAboutProgram_Click);
            // 
            // tCMain
            // 
            this.tCMain.Controls.Add(this.tPSimpMults);
            this.tCMain.Controls.Add(this.tPRandNum);
            this.tCMain.Controls.Add(this.tPNotePad);
            this.tCMain.Controls.Add(this.tPPass);
            this.tCMain.Controls.Add(this.tPConw);
            this.tCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCMain.Location = new System.Drawing.Point(0, 24);
            this.tCMain.Name = "tCMain";
            this.tCMain.SelectedIndex = 0;
            this.tCMain.Size = new System.Drawing.Size(508, 237);
            this.tCMain.TabIndex = 1;
            this.tCMain.SelectedIndexChanged += new System.EventHandler(this.tCMain_SelectedIndexChanged);
            // 
            // tPSimpMults
            // 
            this.tPSimpMults.Controls.Add(this.chBNoRepets);
            this.tPSimpMults.Controls.Add(this.lbAnswer);
            this.tPSimpMults.Controls.Add(this.label3);
            this.tPSimpMults.Controls.Add(this.tBNumber);
            this.tPSimpMults.Controls.Add(this.btnCalc);
            this.tPSimpMults.Controls.Add(this.label1);
            this.tPSimpMults.Location = new System.Drawing.Point(4, 22);
            this.tPSimpMults.Name = "tPSimpMults";
            this.tPSimpMults.Padding = new System.Windows.Forms.Padding(3);
            this.tPSimpMults.Size = new System.Drawing.Size(500, 211);
            this.tPSimpMults.TabIndex = 0;
            this.tPSimpMults.Text = "Разложить на простые множители";
            this.tPSimpMults.UseVisualStyleBackColor = true;
            // 
            // chBNoRepets
            // 
            this.chBNoRepets.AutoSize = true;
            this.chBNoRepets.Location = new System.Drawing.Point(20, 89);
            this.chBNoRepets.Name = "chBNoRepets";
            this.chBNoRepets.Size = new System.Drawing.Size(95, 17);
            this.chBNoRepets.TabIndex = 7;
            this.chBNoRepets.Text = "Без повторов";
            this.chBNoRepets.UseVisualStyleBackColor = true;
            this.chBNoRepets.CheckedChanged += new System.EventHandler(this.chBNoRepets_CheckedChanged);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(108, 139);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 13);
            this.lbAnswer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ответ:";
            // 
            // tBNumber
            // 
            this.tBNumber.Location = new System.Drawing.Point(107, 35);
            this.tBNumber.Name = "tBNumber";
            this.tBNumber.Size = new System.Drawing.Size(100, 20);
            this.tBNumber.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(155, 84);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число:";
            // 
            // tPRandNum
            // 
            this.tPRandNum.Controls.Add(this.chBRandNoRepets);
            this.tPRandNum.Controls.Add(this.btnRandCopy);
            this.tPRandNum.Controls.Add(this.btnRandClear);
            this.tPRandNum.Controls.Add(this.tBRandom);
            this.tPRandNum.Controls.Add(this.btnGetRand);
            this.tPRandNum.Controls.Add(this.lbRandValue);
            this.tPRandNum.Controls.Add(this.label4);
            this.tPRandNum.Controls.Add(this.label2);
            this.tPRandNum.Controls.Add(this.nUDMax);
            this.tPRandNum.Controls.Add(this.nUDMin);
            this.tPRandNum.Location = new System.Drawing.Point(4, 22);
            this.tPRandNum.Name = "tPRandNum";
            this.tPRandNum.Padding = new System.Windows.Forms.Padding(3);
            this.tPRandNum.Size = new System.Drawing.Size(500, 211);
            this.tPRandNum.TabIndex = 1;
            this.tPRandNum.Text = "Генератор случайных чисел";
            this.tPRandNum.UseVisualStyleBackColor = true;
            // 
            // chBRandNoRepets
            // 
            this.chBRandNoRepets.AutoSize = true;
            this.chBRandNoRepets.Location = new System.Drawing.Point(375, 86);
            this.chBRandNoRepets.Name = "chBRandNoRepets";
            this.chBRandNoRepets.Size = new System.Drawing.Size(106, 17);
            this.chBRandNoRepets.TabIndex = 9;
            this.chBRandNoRepets.Text = "без повторений";
            this.chBRandNoRepets.UseVisualStyleBackColor = true;
            this.chBRandNoRepets.CheckedChanged += new System.EventHandler(this.chBRandNoRepets_CheckedChanged);
            // 
            // btnRandCopy
            // 
            this.btnRandCopy.Location = new System.Drawing.Point(94, 104);
            this.btnRandCopy.Name = "btnRandCopy";
            this.btnRandCopy.Size = new System.Drawing.Size(75, 23);
            this.btnRandCopy.TabIndex = 8;
            this.btnRandCopy.Text = "Копировать";
            this.btnRandCopy.UseVisualStyleBackColor = true;
            this.btnRandCopy.Click += new System.EventHandler(this.btnRandCopy_Click);
            // 
            // btnRandClear
            // 
            this.btnRandClear.Location = new System.Drawing.Point(246, 180);
            this.btnRandClear.Name = "btnRandClear";
            this.btnRandClear.Size = new System.Drawing.Size(75, 23);
            this.btnRandClear.TabIndex = 7;
            this.btnRandClear.Text = "Очистить";
            this.btnRandClear.UseVisualStyleBackColor = true;
            this.btnRandClear.Click += new System.EventHandler(this.btnRandClear_Click);
            // 
            // tBRandom
            // 
            this.tBRandom.Location = new System.Drawing.Point(246, 84);
            this.tBRandom.Multiline = true;
            this.tBRandom.Name = "tBRandom";
            this.tBRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBRandom.Size = new System.Drawing.Size(86, 92);
            this.tBRandom.TabIndex = 6;
            // 
            // btnGetRand
            // 
            this.btnGetRand.Location = new System.Drawing.Point(246, 26);
            this.btnGetRand.Name = "btnGetRand";
            this.btnGetRand.Size = new System.Drawing.Size(86, 23);
            this.btnGetRand.TabIndex = 5;
            this.btnGetRand.Text = "Генерировать";
            this.btnGetRand.UseVisualStyleBackColor = true;
            this.btnGetRand.Click += new System.EventHandler(this.btnGetRand_Click);
            // 
            // lbRandValue
            // 
            this.lbRandValue.AutoSize = true;
            this.lbRandValue.Location = new System.Drawing.Point(254, 63);
            this.lbRandValue.Name = "lbRandValue";
            this.lbRandValue.Size = new System.Drawing.Size(0, 13);
            this.lbRandValue.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "От";
            // 
            // nUDMax
            // 
            this.nUDMax.Location = new System.Drawing.Point(92, 61);
            this.nUDMax.Name = "nUDMax";
            this.nUDMax.Size = new System.Drawing.Size(77, 20);
            this.nUDMax.TabIndex = 1;
            this.nUDMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nUDMin
            // 
            this.nUDMin.Location = new System.Drawing.Point(92, 24);
            this.nUDMin.Name = "nUDMin";
            this.nUDMin.Size = new System.Drawing.Size(77, 20);
            this.nUDMin.TabIndex = 0;
            this.nUDMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tPNotePad
            // 
            this.tPNotePad.Controls.Add(this.rTBNotePad);
            this.tPNotePad.Location = new System.Drawing.Point(4, 22);
            this.tPNotePad.Name = "tPNotePad";
            this.tPNotePad.Size = new System.Drawing.Size(500, 211);
            this.tPNotePad.TabIndex = 2;
            this.tPNotePad.Text = "Блокнот";
            this.tPNotePad.UseVisualStyleBackColor = true;
            // 
            // rTBNotePad
            // 
            this.rTBNotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBNotePad.Location = new System.Drawing.Point(0, 0);
            this.rTBNotePad.Name = "rTBNotePad";
            this.rTBNotePad.Size = new System.Drawing.Size(500, 211);
            this.rTBNotePad.TabIndex = 0;
            this.rTBNotePad.Text = "";
            this.rTBNotePad.TextChanged += new System.EventHandler(this.rTBNotePad_TextChanged);
            // 
            // tPPass
            // 
            this.tPPass.Controls.Add(this.btnGenPass);
            this.tPPass.Controls.Add(this.tBPass);
            this.tPPass.Controls.Add(this.label5);
            this.tPPass.Controls.Add(this.nUDPass);
            this.tPPass.Controls.Add(this.chLBPassSymb);
            this.tPPass.Location = new System.Drawing.Point(4, 22);
            this.tPPass.Name = "tPPass";
            this.tPPass.Size = new System.Drawing.Size(500, 211);
            this.tPPass.TabIndex = 3;
            this.tPPass.Text = "Пароли";
            this.tPPass.UseVisualStyleBackColor = true;
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(52, 156);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(88, 23);
            this.btnGenPass.TabIndex = 4;
            this.btnGenPass.Text = "Генерировать";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(161, 159);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(100, 20);
            this.tBPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Количество символов";
            // 
            // nUDPass
            // 
            this.nUDPass.Location = new System.Drawing.Point(133, 102);
            this.nUDPass.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUDPass.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDPass.Name = "nUDPass";
            this.nUDPass.Size = new System.Drawing.Size(54, 20);
            this.nUDPass.TabIndex = 1;
            this.nUDPass.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chLBPassSymb
            // 
            this.chLBPassSymb.CheckOnClick = true;
            this.chLBPassSymb.FormattingEnabled = true;
            this.chLBPassSymb.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы (_, @, (, #, *, &, $, ?, ^, ~) "});
            this.chLBPassSymb.Location = new System.Drawing.Point(8, 16);
            this.chLBPassSymb.Name = "chLBPassSymb";
            this.chLBPassSymb.Size = new System.Drawing.Size(233, 64);
            this.chLBPassSymb.TabIndex = 0;
            // 
            // tPConw
            // 
            this.tPConw.Controls.Add(this.cBMetrica);
            this.tPConw.Controls.Add(this.btnSwap);
            this.tPConw.Controls.Add(this.cBTo);
            this.tPConw.Controls.Add(this.cBFrom);
            this.tPConw.Controls.Add(this.tBTo);
            this.tPConw.Controls.Add(this.tBFrom);
            this.tPConw.Controls.Add(this.btnConvert);
            this.tPConw.Location = new System.Drawing.Point(4, 22);
            this.tPConw.Name = "tPConw";
            this.tPConw.Padding = new System.Windows.Forms.Padding(3);
            this.tPConw.Size = new System.Drawing.Size(500, 211);
            this.tPConw.TabIndex = 4;
            this.tPConw.Text = "Конвертер";
            this.tPConw.UseVisualStyleBackColor = true;
            // 
            // cBMetrica
            // 
            this.cBMetrica.FormattingEnabled = true;
            this.cBMetrica.Items.AddRange(new object[] {
            "Энергия",
            "Длина",
            "Масса",
            "Индукция магнитного поля"});
            this.cBMetrica.Location = new System.Drawing.Point(180, 19);
            this.cBMetrica.Name = "cBMetrica";
            this.cBMetrica.Size = new System.Drawing.Size(126, 21);
            this.cBMetrica.TabIndex = 6;
            this.cBMetrica.Text = "Энергия";
            this.cBMetrica.TextChanged += new System.EventHandler(this.cBMetrica_TextChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(222, 57);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cBTo
            // 
            this.cBTo.FormattingEnabled = true;
            this.cBTo.Location = new System.Drawing.Point(321, 59);
            this.cBTo.Name = "cBTo";
            this.cBTo.Size = new System.Drawing.Size(100, 21);
            this.cBTo.TabIndex = 4;
            // 
            // cBFrom
            // 
            this.cBFrom.FormattingEnabled = true;
            this.cBFrom.Location = new System.Drawing.Point(78, 59);
            this.cBFrom.Name = "cBFrom";
            this.cBFrom.Size = new System.Drawing.Size(100, 21);
            this.cBFrom.TabIndex = 3;
            // 
            // tBTo
            // 
            this.tBTo.Location = new System.Drawing.Point(321, 104);
            this.tBTo.Name = "tBTo";
            this.tBTo.ReadOnly = true;
            this.tBTo.Size = new System.Drawing.Size(100, 20);
            this.tBTo.TabIndex = 2;
            // 
            // tBFrom
            // 
            this.tBFrom.Location = new System.Drawing.Point(78, 104);
            this.tBFrom.Name = "tBFrom";
            this.tBFrom.Size = new System.Drawing.Size(100, 20);
            this.tBFrom.TabIndex = 1;
            this.tBFrom.Text = "1";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(207, 102);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 6);
            // 
            // TSMIToNotePad
            // 
            this.TSMIToNotePad.Name = "TSMIToNotePad";
            this.TSMIToNotePad.Size = new System.Drawing.Size(236, 22);
            this.TSMIToNotePad.Text = "Записать в блокнот";
            this.TSMIToNotePad.Click += new System.EventHandler(this.TSMIToNotePad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 261);
            this.Controls.Add(this.tCMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My Utils";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tCMain.ResumeLayout(false);
            this.tPSimpMults.ResumeLayout(false);
            this.tPSimpMults.PerformLayout();
            this.tPRandNum.ResumeLayout(false);
            this.tPRandNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMin)).EndInit();
            this.tPNotePad.ResumeLayout(false);
            this.tPPass.ResumeLayout(false);
            this.tPPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPass)).EndInit();
            this.tPConw.ResumeLayout(false);
            this.tPConw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMIFile;
        private System.Windows.Forms.ToolStripMenuItem tSMIHelp;
        private System.Windows.Forms.ToolStripMenuItem tSMIExit;
        private System.Windows.Forms.ToolStripMenuItem tlSMIAboutProgramm;
        private System.Windows.Forms.TabControl tCMain;
        private System.Windows.Forms.TabPage tPSimpMults;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tPRandNum;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBNoRepets;
        private System.Windows.Forms.Button btnGetRand;
        private System.Windows.Forms.Label lbRandValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDMax;
        private System.Windows.Forms.NumericUpDown nUDMin;
        private System.Windows.Forms.TextBox tBRandom;
        private System.Windows.Forms.Button btnRandClear;
        private System.Windows.Forms.Button btnRandCopy;
        private System.Windows.Forms.CheckBox chBRandNoRepets;
        private System.Windows.Forms.ToolStripMenuItem tSMINotePad;
        private System.Windows.Forms.ToolStripMenuItem tSMIDate;
        private System.Windows.Forms.ToolStripMenuItem tSMITime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tSMISave;
        private System.Windows.Forms.ToolStripMenuItem tSMISaveAs;
        private System.Windows.Forms.ToolStripMenuItem tSMIOpen;
        private System.Windows.Forms.TabPage tPNotePad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rTBNotePad;
        private System.Windows.Forms.TabPage tPPass;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDPass;
        private System.Windows.Forms.CheckedListBox chLBPassSymb;
        private System.Windows.Forms.TabPage tPConw;
        private System.Windows.Forms.ComboBox cBTo;
        private System.Windows.Forms.ComboBox cBFrom;
        private System.Windows.Forms.TextBox tBTo;
        private System.Windows.Forms.TextBox tBFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cBMetrica;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMIToNotePad;
    }
}

