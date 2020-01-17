namespace view
{
    partial class FormCalculator
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
            this.components = new System.ComponentModel.Container();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDisconnection = new System.Windows.Forms.Button();
            this.lblEmailView = new System.Windows.Forms.Label();
            this.gpbConsommation = new System.Windows.Forms.GroupBox();
            this.ckbUseConsommation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConsommationCpM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsommationCpY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDpM = new System.Windows.Forms.TextBox();
            this.lblDpM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarSCp100km = new System.Windows.Forms.Label();
            this.txtCarSCp100km = new System.Windows.Forms.TextBox();
            this.lblChf = new System.Windows.Forms.Label();
            this.txtAverageFuelPricePerLiter = new System.Windows.Forms.TextBox();
            this.lblAverageFuelPricePerLiter = new System.Windows.Forms.Label();
            this.cbxFuel = new System.Windows.Forms.ComboBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbUseInitialCarSPrice = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInitialCarSPriceCpM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInitialCarSPriceCpY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCarSLifetimeEstimation = new System.Windows.Forms.Label();
            this.txtCarSLifetimeEstimation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCarPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblCarPurchasePrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbUseEssentialSupports = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRevisionpY = new System.Windows.Forms.TextBox();
            this.lblRevisionpY = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTirespY = new System.Windows.Forms.TextBox();
            this.lblTirespY = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEssentialsMaintainsCpM = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEssentialsMaintainsCpY = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtInsurancepY = new System.Windows.Forms.TextBox();
            this.lblInsurancepY = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbUseLicencePlate = new System.Windows.Forms.CheckBox();
            this.txtCO2Emission = new System.Windows.Forms.TextBox();
            this.lblCO2Emission = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cbxPower = new System.Windows.Forms.ComboBox();
            this.cbxCantonRegistration = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtLicensePlateCpM = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtLicensePlateCpY = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtResultCpM = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtResultCpY = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tmrCalculator = new System.Windows.Forms.Timer(this.components);
            this.btnRegisterACar = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.gpbConsommation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(8, 376);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDisconnection
            // 
            this.btnDisconnection.Location = new System.Drawing.Point(596, 25);
            this.btnDisconnection.Name = "btnDisconnection";
            this.btnDisconnection.Size = new System.Drawing.Size(83, 23);
            this.btnDisconnection.TabIndex = 1;
            this.btnDisconnection.Text = "Disconnection";
            this.btnDisconnection.UseVisualStyleBackColor = true;
            this.btnDisconnection.Click += new System.EventHandler(this.btnDisconnection_Click);
            // 
            // lblEmailView
            // 
            this.lblEmailView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmailView.Location = new System.Drawing.Point(488, 9);
            this.lblEmailView.Name = "lblEmailView";
            this.lblEmailView.Size = new System.Drawing.Size(191, 13);
            this.lblEmailView.TabIndex = 2;
            this.lblEmailView.Text = "...";
            this.lblEmailView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpbConsommation
            // 
            this.gpbConsommation.Controls.Add(this.ckbUseConsommation);
            this.gpbConsommation.Controls.Add(this.label8);
            this.gpbConsommation.Controls.Add(this.txtConsommationCpM);
            this.gpbConsommation.Controls.Add(this.label7);
            this.gpbConsommation.Controls.Add(this.txtConsommationCpY);
            this.gpbConsommation.Controls.Add(this.label6);
            this.gpbConsommation.Controls.Add(this.label5);
            this.gpbConsommation.Controls.Add(this.label4);
            this.gpbConsommation.Controls.Add(this.txtDpM);
            this.gpbConsommation.Controls.Add(this.lblDpM);
            this.gpbConsommation.Controls.Add(this.label2);
            this.gpbConsommation.Controls.Add(this.lblCarSCp100km);
            this.gpbConsommation.Controls.Add(this.txtCarSCp100km);
            this.gpbConsommation.Controls.Add(this.lblChf);
            this.gpbConsommation.Controls.Add(this.txtAverageFuelPricePerLiter);
            this.gpbConsommation.Controls.Add(this.lblAverageFuelPricePerLiter);
            this.gpbConsommation.Controls.Add(this.cbxFuel);
            this.gpbConsommation.Controls.Add(this.lblFuel);
            this.gpbConsommation.Location = new System.Drawing.Point(512, 54);
            this.gpbConsommation.Name = "gpbConsommation";
            this.gpbConsommation.Size = new System.Drawing.Size(167, 242);
            this.gpbConsommation.TabIndex = 3;
            this.gpbConsommation.TabStop = false;
            this.gpbConsommation.Text = "Consommation";
            // 
            // ckbUseConsommation
            // 
            this.ckbUseConsommation.Checked = true;
            this.ckbUseConsommation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseConsommation.Location = new System.Drawing.Point(7, 219);
            this.ckbUseConsommation.Name = "ckbUseConsommation";
            this.ckbUseConsommation.Size = new System.Drawing.Size(128, 17);
            this.ckbUseConsommation.TabIndex = 23;
            this.ckbUseConsommation.Text = "Use in the final result";
            this.ckbUseConsommation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "chf";
            // 
            // txtConsommationCpM
            // 
            this.txtConsommationCpM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtConsommationCpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsommationCpM.Location = new System.Drawing.Point(77, 190);
            this.txtConsommationCpM.Name = "txtConsommationCpM";
            this.txtConsommationCpM.ReadOnly = true;
            this.txtConsommationCpM.Size = new System.Drawing.Size(56, 13);
            this.txtConsommationCpM.TabIndex = 14;
            this.txtConsommationCpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "chf";
            // 
            // txtConsommationCpY
            // 
            this.txtConsommationCpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtConsommationCpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsommationCpY.Location = new System.Drawing.Point(77, 171);
            this.txtConsommationCpY.Name = "txtConsommationCpY";
            this.txtConsommationCpY.ReadOnly = true;
            this.txtConsommationCpY.Size = new System.Drawing.Size(56, 13);
            this.txtConsommationCpY.TabIndex = 12;
            this.txtConsommationCpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Costs/month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costs/year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "km";
            // 
            // txtDpM
            // 
            this.txtDpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDpM.Location = new System.Drawing.Point(94, 137);
            this.txtDpM.Name = "txtDpM";
            this.txtDpM.Size = new System.Drawing.Size(35, 13);
            this.txtDpM.TabIndex = 9;
            this.txtDpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDpM
            // 
            this.lblDpM.AutoSize = true;
            this.lblDpM.Location = new System.Drawing.Point(4, 137);
            this.lblDpM.Name = "lblDpM";
            this.lblDpM.Size = new System.Drawing.Size(83, 13);
            this.lblDpM.TabIndex = 8;
            this.lblDpM.Text = "Distance/month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "l";
            // 
            // lblCarSCp100km
            // 
            this.lblCarSCp100km.AutoSize = true;
            this.lblCarSCp100km.Location = new System.Drawing.Point(4, 92);
            this.lblCarSCp100km.Name = "lblCarSCp100km";
            this.lblCarSCp100km.Size = new System.Drawing.Size(138, 13);
            this.lblCarSCp100km.TabIndex = 6;
            this.lblCarSCp100km.Text = "Car\'s consommation/100km";
            // 
            // txtCarSCp100km
            // 
            this.txtCarSCp100km.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarSCp100km.Location = new System.Drawing.Point(94, 111);
            this.txtCarSCp100km.Name = "txtCarSCp100km";
            this.txtCarSCp100km.Size = new System.Drawing.Size(35, 13);
            this.txtCarSCp100km.TabIndex = 5;
            this.txtCarSCp100km.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblChf
            // 
            this.lblChf.AutoSize = true;
            this.lblChf.Location = new System.Drawing.Point(49, 71);
            this.lblChf.Name = "lblChf";
            this.lblChf.Size = new System.Drawing.Size(22, 13);
            this.lblChf.TabIndex = 4;
            this.lblChf.Text = "chf";
            // 
            // txtAverageFuelPricePerLiter
            // 
            this.txtAverageFuelPricePerLiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAverageFuelPricePerLiter.Location = new System.Drawing.Point(7, 71);
            this.txtAverageFuelPricePerLiter.Name = "txtAverageFuelPricePerLiter";
            this.txtAverageFuelPricePerLiter.ReadOnly = true;
            this.txtAverageFuelPricePerLiter.Size = new System.Drawing.Size(36, 13);
            this.txtAverageFuelPricePerLiter.TabIndex = 3;
            this.txtAverageFuelPricePerLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAverageFuelPricePerLiter
            // 
            this.lblAverageFuelPricePerLiter.AutoSize = true;
            this.lblAverageFuelPricePerLiter.Location = new System.Drawing.Point(4, 52);
            this.lblAverageFuelPricePerLiter.Name = "lblAverageFuelPricePerLiter";
            this.lblAverageFuelPricePerLiter.Size = new System.Drawing.Size(114, 13);
            this.lblAverageFuelPricePerLiter.TabIndex = 2;
            this.lblAverageFuelPricePerLiter.Text = "Average fuel price/liter";
            // 
            // cbxFuel
            // 
            this.cbxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuel.FormattingEnabled = true;
            this.cbxFuel.Items.AddRange(new object[] {
            "95",
            "98",
            "Diesel"});
            this.cbxFuel.Location = new System.Drawing.Point(37, 19);
            this.cbxFuel.Name = "cbxFuel";
            this.cbxFuel.Size = new System.Drawing.Size(107, 21);
            this.cbxFuel.TabIndex = 1;
            this.cbxFuel.SelectedIndexChanged += new System.EventHandler(this.cbxFuel_SelectedIndexChanged);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(4, 22);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbUseInitialCarSPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtInitialCarSPriceCpM);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtInitialCarSPriceCpY);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblCarSLifetimeEstimation);
            this.groupBox1.Controls.Add(this.txtCarSLifetimeEstimation);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtCarPurchasePrice);
            this.groupBox1.Controls.Add(this.lblCarPurchasePrice);
            this.groupBox1.Location = new System.Drawing.Point(346, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial car price";
            // 
            // ckbUseInitialCarSPrice
            // 
            this.ckbUseInitialCarSPrice.Checked = true;
            this.ckbUseInitialCarSPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseInitialCarSPrice.Location = new System.Drawing.Point(8, 219);
            this.ckbUseInitialCarSPrice.Name = "ckbUseInitialCarSPrice";
            this.ckbUseInitialCarSPrice.Size = new System.Drawing.Size(128, 17);
            this.ckbUseInitialCarSPrice.TabIndex = 22;
            this.ckbUseInitialCarSPrice.Text = "Use in the final result";
            this.ckbUseInitialCarSPrice.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "chf";
            // 
            // txtInitialCarSPriceCpM
            // 
            this.txtInitialCarSPriceCpM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtInitialCarSPriceCpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInitialCarSPriceCpM.Location = new System.Drawing.Point(77, 190);
            this.txtInitialCarSPriceCpM.Name = "txtInitialCarSPriceCpM";
            this.txtInitialCarSPriceCpM.ReadOnly = true;
            this.txtInitialCarSPriceCpM.Size = new System.Drawing.Size(56, 13);
            this.txtInitialCarSPriceCpM.TabIndex = 14;
            this.txtInitialCarSPriceCpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "chf";
            // 
            // txtInitialCarSPriceCpY
            // 
            this.txtInitialCarSPriceCpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtInitialCarSPriceCpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInitialCarSPriceCpY.Location = new System.Drawing.Point(77, 171);
            this.txtInitialCarSPriceCpY.Name = "txtInitialCarSPriceCpY";
            this.txtInitialCarSPriceCpY.ReadOnly = true;
            this.txtInitialCarSPriceCpY.Size = new System.Drawing.Size(56, 13);
            this.txtInitialCarSPriceCpY.TabIndex = 12;
            this.txtInitialCarSPriceCpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Costs/month";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Costs/year";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "years";
            // 
            // lblCarSLifetimeEstimation
            // 
            this.lblCarSLifetimeEstimation.AutoSize = true;
            this.lblCarSLifetimeEstimation.Location = new System.Drawing.Point(4, 92);
            this.lblCarSLifetimeEstimation.Name = "lblCarSLifetimeEstimation";
            this.lblCarSLifetimeEstimation.Size = new System.Drawing.Size(108, 13);
            this.lblCarSLifetimeEstimation.TabIndex = 6;
            this.lblCarSLifetimeEstimation.Text = "Car lifetime estimation";
            // 
            // txtCarSLifetimeEstimation
            // 
            this.txtCarSLifetimeEstimation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarSLifetimeEstimation.Location = new System.Drawing.Point(8, 111);
            this.txtCarSLifetimeEstimation.Name = "txtCarSLifetimeEstimation";
            this.txtCarSLifetimeEstimation.Size = new System.Drawing.Size(35, 13);
            this.txtCarSLifetimeEstimation.TabIndex = 5;
            this.txtCarSLifetimeEstimation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "chf";
            // 
            // txtCarPurchasePrice
            // 
            this.txtCarPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarPurchasePrice.Location = new System.Drawing.Point(8, 38);
            this.txtCarPurchasePrice.Name = "txtCarPurchasePrice";
            this.txtCarPurchasePrice.Size = new System.Drawing.Size(63, 13);
            this.txtCarPurchasePrice.TabIndex = 3;
            this.txtCarPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCarPurchasePrice
            // 
            this.lblCarPurchasePrice.AutoSize = true;
            this.lblCarPurchasePrice.Location = new System.Drawing.Point(4, 19);
            this.lblCarPurchasePrice.Name = "lblCarPurchasePrice";
            this.lblCarPurchasePrice.Size = new System.Drawing.Size(96, 13);
            this.lblCarPurchasePrice.TabIndex = 2;
            this.lblCarPurchasePrice.Text = "Car purchase price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbUseEssentialSupports);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtRevisionpY);
            this.groupBox2.Controls.Add(this.lblRevisionpY);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtTirespY);
            this.groupBox2.Controls.Add(this.lblTirespY);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEssentialsMaintainsCpM);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtEssentialsMaintainsCpY);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtInsurancepY);
            this.groupBox2.Controls.Add(this.lblInsurancepY);
            this.groupBox2.Location = new System.Drawing.Point(177, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 242);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Essential supports";
            // 
            // ckbUseEssentialSupports
            // 
            this.ckbUseEssentialSupports.Checked = true;
            this.ckbUseEssentialSupports.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseEssentialSupports.Location = new System.Drawing.Point(4, 219);
            this.ckbUseEssentialSupports.Name = "ckbUseEssentialSupports";
            this.ckbUseEssentialSupports.Size = new System.Drawing.Size(128, 17);
            this.ckbUseEssentialSupports.TabIndex = 21;
            this.ckbUseEssentialSupports.Text = "Use in the final result";
            this.ckbUseEssentialSupports.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(131, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "chf";
            // 
            // txtRevisionpY
            // 
            this.txtRevisionpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRevisionpY.Location = new System.Drawing.Point(89, 115);
            this.txtRevisionpY.Name = "txtRevisionpY";
            this.txtRevisionpY.Size = new System.Drawing.Size(36, 13);
            this.txtRevisionpY.TabIndex = 20;
            this.txtRevisionpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRevisionpY
            // 
            this.lblRevisionpY.AutoSize = true;
            this.lblRevisionpY.Location = new System.Drawing.Point(4, 115);
            this.lblRevisionpY.Name = "lblRevisionpY";
            this.lblRevisionpY.Size = new System.Drawing.Size(73, 13);
            this.lblRevisionpY.TabIndex = 19;
            this.lblRevisionpY.Text = "Revision/year";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(131, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "chf";
            // 
            // txtTirespY
            // 
            this.txtTirespY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTirespY.Location = new System.Drawing.Point(89, 68);
            this.txtTirespY.Name = "txtTirespY";
            this.txtTirespY.Size = new System.Drawing.Size(36, 13);
            this.txtTirespY.TabIndex = 17;
            this.txtTirespY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTirespY
            // 
            this.lblTirespY.AutoSize = true;
            this.lblTirespY.Location = new System.Drawing.Point(4, 68);
            this.lblTirespY.Name = "lblTirespY";
            this.lblTirespY.Size = new System.Drawing.Size(55, 13);
            this.lblTirespY.TabIndex = 16;
            this.lblTirespY.Text = "Tires/year";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "chf";
            // 
            // txtEssentialsMaintainsCpM
            // 
            this.txtEssentialsMaintainsCpM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEssentialsMaintainsCpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEssentialsMaintainsCpM.Location = new System.Drawing.Point(77, 190);
            this.txtEssentialsMaintainsCpM.Name = "txtEssentialsMaintainsCpM";
            this.txtEssentialsMaintainsCpM.ReadOnly = true;
            this.txtEssentialsMaintainsCpM.Size = new System.Drawing.Size(56, 13);
            this.txtEssentialsMaintainsCpM.TabIndex = 14;
            this.txtEssentialsMaintainsCpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "chf";
            // 
            // txtEssentialsMaintainsCpY
            // 
            this.txtEssentialsMaintainsCpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEssentialsMaintainsCpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEssentialsMaintainsCpY.Location = new System.Drawing.Point(77, 171);
            this.txtEssentialsMaintainsCpY.Name = "txtEssentialsMaintainsCpY";
            this.txtEssentialsMaintainsCpY.ReadOnly = true;
            this.txtEssentialsMaintainsCpY.Size = new System.Drawing.Size(56, 13);
            this.txtEssentialsMaintainsCpY.TabIndex = 12;
            this.txtEssentialsMaintainsCpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Costs/month";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Costs/year";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(131, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "chf";
            // 
            // txtInsurancepY
            // 
            this.txtInsurancepY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsurancepY.Location = new System.Drawing.Point(89, 19);
            this.txtInsurancepY.Name = "txtInsurancepY";
            this.txtInsurancepY.Size = new System.Drawing.Size(36, 13);
            this.txtInsurancepY.TabIndex = 3;
            this.txtInsurancepY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInsurancepY
            // 
            this.lblInsurancepY.AutoSize = true;
            this.lblInsurancepY.Location = new System.Drawing.Point(4, 19);
            this.lblInsurancepY.Name = "lblInsurancepY";
            this.lblInsurancepY.Size = new System.Drawing.Size(79, 13);
            this.lblInsurancepY.TabIndex = 2;
            this.lblInsurancepY.Text = "Insurance/year";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbUseLicencePlate);
            this.groupBox3.Controls.Add(this.txtCO2Emission);
            this.groupBox3.Controls.Add(this.lblCO2Emission);
            this.groupBox3.Controls.Add(this.lblWeight);
            this.groupBox3.Controls.Add(this.cbxPower);
            this.groupBox3.Controls.Add(this.cbxCantonRegistration);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtLicensePlateCpM);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.txtLicensePlateCpY);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.lblPower);
            this.groupBox3.Controls.Add(this.txtWeight);
            this.groupBox3.Controls.Add(this.txtPower);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 242);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "License plate";
            // 
            // ckbUseLicencePlate
            // 
            this.ckbUseLicencePlate.Checked = true;
            this.ckbUseLicencePlate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseLicencePlate.Location = new System.Drawing.Point(3, 219);
            this.ckbUseLicencePlate.Name = "ckbUseLicencePlate";
            this.ckbUseLicencePlate.Size = new System.Drawing.Size(128, 17);
            this.ckbUseLicencePlate.TabIndex = 0;
            this.ckbUseLicencePlate.Text = "Use in the final result";
            this.ckbUseLicencePlate.UseVisualStyleBackColor = true;
            // 
            // txtCO2Emission
            // 
            this.txtCO2Emission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCO2Emission.Location = new System.Drawing.Point(82, 135);
            this.txtCO2Emission.Name = "txtCO2Emission";
            this.txtCO2Emission.Size = new System.Drawing.Size(52, 13);
            this.txtCO2Emission.TabIndex = 20;
            this.txtCO2Emission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCO2Emission
            // 
            this.lblCO2Emission.AutoSize = true;
            this.lblCO2Emission.Location = new System.Drawing.Point(4, 134);
            this.lblCO2Emission.Name = "lblCO2Emission";
            this.lblCO2Emission.Size = new System.Drawing.Size(72, 13);
            this.lblCO2Emission.TabIndex = 19;
            this.lblCO2Emission.Text = "CO2 Emission";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(4, 111);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Weight";
            // 
            // cbxPower
            // 
            this.cbxPower.DisplayMember = "kW";
            this.cbxPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPower.FormattingEnabled = true;
            this.cbxPower.Items.AddRange(new object[] {
            "kW",
            "hp"});
            this.cbxPower.Location = new System.Drawing.Point(89, 64);
            this.cbxPower.Name = "cbxPower";
            this.cbxPower.Size = new System.Drawing.Size(42, 21);
            this.cbxPower.TabIndex = 17;
            this.cbxPower.ValueMember = " ";
            // 
            // cbxCantonRegistration
            // 
            this.cbxCantonRegistration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCantonRegistration.FormattingEnabled = true;
            this.cbxCantonRegistration.Items.AddRange(new object[] {
            "Aargau",
            "Appenzell Inner-Rhodes",
            "Appenzell Outer-Rhodes",
            "Basel",
            "Basel District",
            "Bern",
            "Fribourg",
            "Geneva",
            "Glarus",
            "Grisons",
            "Jura",
            "Lucerne",
            "Neuchâtel",
            "Nidwalden",
            "Obwalden",
            "Schaffhausen",
            "Schwyz",
            "Solothurn",
            "St Gallen",
            "Thurgau",
            "Ticino",
            "Uri",
            "Valais",
            "Vaud",
            "Zug",
            "Zurich"});
            this.cbxCantonRegistration.Location = new System.Drawing.Point(7, 35);
            this.cbxCantonRegistration.Name = "cbxCantonRegistration";
            this.cbxCantonRegistration.Size = new System.Drawing.Size(154, 21);
            this.cbxCantonRegistration.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(139, 190);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "chf";
            // 
            // txtLicensePlateCpM
            // 
            this.txtLicensePlateCpM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLicensePlateCpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicensePlateCpM.Location = new System.Drawing.Point(77, 190);
            this.txtLicensePlateCpM.Name = "txtLicensePlateCpM";
            this.txtLicensePlateCpM.ReadOnly = true;
            this.txtLicensePlateCpM.Size = new System.Drawing.Size(56, 13);
            this.txtLicensePlateCpM.TabIndex = 14;
            this.txtLicensePlateCpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(139, 171);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(22, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "chf";
            // 
            // txtLicensePlateCpY
            // 
            this.txtLicensePlateCpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtLicensePlateCpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicensePlateCpY.Location = new System.Drawing.Point(77, 171);
            this.txtLicensePlateCpY.Name = "txtLicensePlateCpY";
            this.txtLicensePlateCpY.ReadOnly = true;
            this.txtLicensePlateCpY.Size = new System.Drawing.Size(56, 13);
            this.txtLicensePlateCpY.TabIndex = 12;
            this.txtLicensePlateCpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 190);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "Costs/month";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 171);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Costs/year";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(140, 112);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "kg";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(4, 68);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(37, 13);
            this.lblPower.TabIndex = 6;
            this.lblPower.Text = "Power";
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Location = new System.Drawing.Point(82, 112);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(52, 13);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPower
            // 
            this.txtPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPower.Location = new System.Drawing.Point(47, 68);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(36, 13);
            this.txtPower.TabIndex = 3;
            this.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Canton registration";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(452, 370);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 25);
            this.label36.TabIndex = 21;
            this.label36.Text = "chf";
            // 
            // txtResultCpM
            // 
            this.txtResultCpM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtResultCpM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultCpM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultCpM.Location = new System.Drawing.Point(343, 370);
            this.txtResultCpM.Name = "txtResultCpM";
            this.txtResultCpM.ReadOnly = true;
            this.txtResultCpM.Size = new System.Drawing.Size(103, 24);
            this.txtResultCpM.TabIndex = 20;
            this.txtResultCpM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(452, 333);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 25);
            this.label37.TabIndex = 19;
            this.label37.Text = "chf";
            // 
            // txtResultCpY
            // 
            this.txtResultCpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtResultCpY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultCpY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultCpY.Location = new System.Drawing.Point(343, 334);
            this.txtResultCpY.Name = "txtResultCpY";
            this.txtResultCpY.ReadOnly = true;
            this.txtResultCpY.Size = new System.Drawing.Size(103, 24);
            this.txtResultCpY.TabIndex = 18;
            this.txtResultCpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(205, 370);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(132, 25);
            this.label38.TabIndex = 17;
            this.label38.Text = "Costs/month";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(206, 333);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(115, 25);
            this.label39.TabIndex = 16;
            this.label39.Text = "Costs/year";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(302, 299);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 29);
            this.label40.TabIndex = 22;
            this.label40.Text = "Result";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(12, 9);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(131, 29);
            this.label41.TabIndex = 23;
            this.label41.Text = "Calculator";
            // 
            // tmrCalculator
            // 
            this.tmrCalculator.Enabled = true;
            this.tmrCalculator.Interval = 300;
            this.tmrCalculator.Tick += new System.EventHandler(this.tmrCalculator_Tick);
            // 
            // btnRegisterACar
            // 
            this.btnRegisterACar.Location = new System.Drawing.Point(589, 376);
            this.btnRegisterACar.Name = "btnRegisterACar";
            this.btnRegisterACar.Size = new System.Drawing.Size(92, 23);
            this.btnRegisterACar.TabIndex = 24;
            this.btnRegisterACar.Text = "Register a car";
            this.btnRegisterACar.UseVisualStyleBackColor = true;
            this.btnRegisterACar.Click += new System.EventHandler(this.btnRegisterACar_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.Location = new System.Drawing.Point(624, 302);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(57, 23);
            this.btnCarList.TabIndex = 25;
            this.btnCarList.Text = "Car list";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(624, 331);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(57, 23);
            this.btnHistory.TabIndex = 26;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.btnRegisterACar);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtResultCpM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultCpY);
            this.Controls.Add(this.gpbConsommation);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.lblEmailView);
            this.Controls.Add(this.btnDisconnection);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculator";
            this.Text = "Car Cost Calculator - Calculator";
            this.gpbConsommation.ResumeLayout(false);
            this.gpbConsommation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDisconnection;
        private System.Windows.Forms.GroupBox gpbConsommation;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblAverageFuelPricePerLiter;
        private System.Windows.Forms.Label lblChf;
        private System.Windows.Forms.TextBox txtAverageFuelPricePerLiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDpM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarSCp100km;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConsommationCpM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsommationCpY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInitialCarSPriceCpM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInitialCarSPriceCpY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCarSLifetimeEstimation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCarPurchasePrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblRevisionpY;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTirespY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEssentialsMaintainsCpM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEssentialsMaintainsCpY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblInsurancepY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtLicensePlateCpM;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtLicensePlateCpY;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblCO2Emission;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtResultCpM;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtResultCpY;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Timer tmrCalculator;
        private System.Windows.Forms.Button btnRegisterACar;
        private System.Windows.Forms.CheckBox ckbUseLicencePlate;
        private System.Windows.Forms.CheckBox ckbUseConsommation;
        private System.Windows.Forms.CheckBox ckbUseInitialCarSPrice;
        private System.Windows.Forms.CheckBox ckbUseEssentialSupports;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label lblEmailView;
        private System.Windows.Forms.ComboBox cbxFuel;
        private System.Windows.Forms.TextBox txtDpM;
        private System.Windows.Forms.TextBox txtCarSCp100km;
        private System.Windows.Forms.TextBox txtCarSLifetimeEstimation;
        private System.Windows.Forms.TextBox txtCarPurchasePrice;
        private System.Windows.Forms.TextBox txtRevisionpY;
        private System.Windows.Forms.TextBox txtTirespY;
        private System.Windows.Forms.TextBox txtInsurancepY;
        private System.Windows.Forms.ComboBox cbxCantonRegistration;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.ComboBox cbxPower;
        private System.Windows.Forms.TextBox txtCO2Emission;
        private System.Windows.Forms.Button btnHistory;
    }
}