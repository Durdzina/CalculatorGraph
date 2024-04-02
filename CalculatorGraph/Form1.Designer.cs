namespace CalculatorGraph
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnBS = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPi = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnSom = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnTg = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnLnX = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.GraphPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GraphPictureBox1 = new System.Windows.Forms.PictureBox();
            this.GraphPictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBS
            // 
            this.BtnBS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnBS.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBS.Location = new System.Drawing.Point(12, 113);
            this.BtnBS.Name = "BtnBS";
            this.BtnBS.Size = new System.Drawing.Size(65, 65);
            this.BtnBS.TabIndex = 0;
            this.BtnBS.Text = "⌫";
            this.BtnBS.UseVisualStyleBackColor = false;
            this.BtnBS.Click += new System.EventHandler(this.BtnBS_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCE.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.Location = new System.Drawing.Point(83, 113);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(65, 65);
            this.BtnCE.TabIndex = 1;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnClearEntry);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(154, 113);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(65, 65);
            this.BtnC.TabIndex = 2;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnClear);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnPM.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(225, 113);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(65, 65);
            this.BtnPM.TabIndex = 3;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnPlusMinus);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Blue;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn7.Location = new System.Drawing.Point(12, 184);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(65, 65);
            this.Btn7.TabIndex = 4;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Blue;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn8.Location = new System.Drawing.Point(83, 184);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(65, 65);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Blue;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn9.Location = new System.Drawing.Point(154, 184);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(65, 65);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnAddition
            // 
            this.BtnAddition.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAddition.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddition.Location = new System.Drawing.Point(225, 184);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(65, 65);
            this.BtnAddition.TabIndex = 7;
            this.BtnAddition.Text = "+";
            this.BtnAddition.UseVisualStyleBackColor = false;
            this.BtnAddition.Click += new System.EventHandler(this.NumberOper);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Blue;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn4.Location = new System.Drawing.Point(12, 255);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(65, 65);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Blue;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn5.Location = new System.Drawing.Point(83, 255);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(65, 65);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Blue;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn6.Location = new System.Drawing.Point(154, 255);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(65, 65);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.Location = new System.Drawing.Point(225, 255);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(65, 65);
            this.BtnDivision.TabIndex = 11;
            this.BtnDivision.Text = "-";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.NumberOper);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Blue;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn1.Location = new System.Drawing.Point(12, 326);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(65, 65);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Blue;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn2.Location = new System.Drawing.Point(83, 326);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(65, 65);
            this.Btn2.TabIndex = 13;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Blue;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn3.Location = new System.Drawing.Point(154, 326);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(65, 65);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(225, 326);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(65, 65);
            this.BtnMultiply.TabIndex = 15;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.NumberOper);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.Blue;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn0.Location = new System.Drawing.Point(83, 397);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(65, 65);
            this.Btn0.TabIndex = 16;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.Location = new System.Drawing.Point(12, 397);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(65, 65);
            this.BtnDot.TabIndex = 17;
            this.BtnDot.Text = ",";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.Location = new System.Drawing.Point(154, 397);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(65, 65);
            this.BtnEqual.TabIndex = 18;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEquals);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(225, 397);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(65, 65);
            this.BtnDivide.TabIndex = 19;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.NumberOper);
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.Location = new System.Drawing.Point(12, 61);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(584, 32);
            this.TxtResult.TabIndex = 20;
            this.TxtResult.Text = "0";
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BtnPi
            // 
            this.BtnPi.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnPi.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPi.Location = new System.Drawing.Point(318, 113);
            this.BtnPi.Name = "BtnPi";
            this.BtnPi.Size = new System.Drawing.Size(65, 65);
            this.BtnPi.TabIndex = 3;
            this.BtnPi.Text = "π";
            this.BtnPi.UseVisualStyleBackColor = false;
            this.BtnPi.Click += new System.EventHandler(this.BtnPi_Click);
            // 
            // BtnSin
            // 
            this.BtnSin.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSin.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSin.Location = new System.Drawing.Point(318, 184);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(65, 65);
            this.BtnSin.TabIndex = 3;
            this.BtnSin.Text = "Sin";
            this.BtnSin.UseVisualStyleBackColor = false;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnSom
            // 
            this.BtnSom.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSom.Location = new System.Drawing.Point(389, 113);
            this.BtnSom.Name = "BtnSom";
            this.BtnSom.Size = new System.Drawing.Size(65, 65);
            this.BtnSom.TabIndex = 3;
            this.BtnSom.Text = "x²";
            this.BtnSom.UseVisualStyleBackColor = false;
            this.BtnSom.Click += new System.EventHandler(this.BtnSom_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnCos.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCos.Location = new System.Drawing.Point(389, 184);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(65, 65);
            this.BtnCos.TabIndex = 3;
            this.BtnCos.Text = "Cos";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSqrt.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSqrt.Location = new System.Drawing.Point(460, 113);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(65, 65);
            this.BtnSqrt.TabIndex = 3;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = false;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // BtnTg
            // 
            this.BtnTg.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnTg.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTg.Location = new System.Drawing.Point(460, 184);
            this.BtnTg.Name = "BtnTg";
            this.BtnTg.Size = new System.Drawing.Size(65, 65);
            this.BtnTg.TabIndex = 3;
            this.BtnTg.Text = "Tg";
            this.BtnTg.UseVisualStyleBackColor = false;
            this.BtnTg.Click += new System.EventHandler(this.BtnTg_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(531, 113);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(65, 65);
            this.btnPercent.TabIndex = 3;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnLog.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.Location = new System.Drawing.Point(318, 255);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(65, 65);
            this.BtnLog.TabIndex = 3;
            this.BtnLog.Text = "Log";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnLnX
            // 
            this.BtnLnX.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnLnX.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLnX.Location = new System.Drawing.Point(389, 255);
            this.BtnLnX.Name = "BtnLnX";
            this.BtnLnX.Size = new System.Drawing.Size(65, 65);
            this.BtnLnX.TabIndex = 3;
            this.BtnLnX.Text = "Ln x";
            this.BtnLnX.UseVisualStyleBackColor = false;
            this.BtnLnX.Click += new System.EventHandler(this.BtnLnX_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.LimeGreen;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1x.Location = new System.Drawing.Point(531, 184);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(65, 65);
            this.btn1x.TabIndex = 3;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // GraphPictureBox
            // 
            this.GraphPictureBox.Location = new System.Drawing.Point(602, 51);
            this.GraphPictureBox.Name = "GraphPictureBox";
            this.GraphPictureBox.Size = new System.Drawing.Size(453, 255);
            this.GraphPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GraphPictureBox.TabIndex = 23;
            this.GraphPictureBox.TabStop = false;
            this.GraphPictureBox.Click += new System.EventHandler(this.GraphPictureBox_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1443, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GraphPictureBox1
            // 
            this.GraphPictureBox1.Location = new System.Drawing.Point(602, 312);
            this.GraphPictureBox1.Name = "GraphPictureBox1";
            this.GraphPictureBox1.Size = new System.Drawing.Size(453, 255);
            this.GraphPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GraphPictureBox1.TabIndex = 25;
            this.GraphPictureBox1.TabStop = false;
            this.GraphPictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GraphPictureBox2
            // 
            this.GraphPictureBox2.Location = new System.Drawing.Point(1061, 51);
            this.GraphPictureBox2.Name = "GraphPictureBox2";
            this.GraphPictureBox2.Size = new System.Drawing.Size(370, 516);
            this.GraphPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GraphPictureBox2.TabIndex = 26;
            this.GraphPictureBox2.TabStop = false;
            this.GraphPictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 570);
            this.Controls.Add(this.GraphPictureBox2);
            this.Controls.Add(this.GraphPictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GraphPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnAddition);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.BtnLnX);
            this.Controls.Add(this.BtnTg);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnSom);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnPi);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnBS);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBS;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnAddition;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.TextBox TxtResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button BtnPi;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button BtnSom;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnTg;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnLnX;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.PictureBox GraphPictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox GraphPictureBox1;
        private System.Windows.Forms.PictureBox GraphPictureBox2;
    }
}

