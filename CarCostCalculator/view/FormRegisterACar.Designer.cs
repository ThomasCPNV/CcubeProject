namespace view
{
    partial class FormRegisterACar
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxReleaseYear = new System.Windows.Forms.ComboBox();
            this.btnRegisterACarCancel = new System.Windows.Forms.Button();
            this.btnRegisterCar = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(39, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand*";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 41);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(40, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model*";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version*";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(64, 12);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(64, 38);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(64, 64);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 121);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(12, 159);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(69, 13);
            this.lblReleaseYear.TabIndex = 7;
            this.lblReleaseYear.Text = "Release year";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan",
            "MPV",
            "SUV",
            "Crossover",
            "Coupe",
            "Convertible"});
            this.cbxType.Location = new System.Drawing.Point(64, 118);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(100, 21);
            this.cbxType.TabIndex = 6;
            // 
            // cbxReleaseYear
            // 
            this.cbxReleaseYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReleaseYear.FormattingEnabled = true;
            this.cbxReleaseYear.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.cbxReleaseYear.Location = new System.Drawing.Point(87, 156);
            this.cbxReleaseYear.Name = "cbxReleaseYear";
            this.cbxReleaseYear.Size = new System.Drawing.Size(77, 21);
            this.cbxReleaseYear.TabIndex = 1;
            // 
            // btnRegisterACarCancel
            // 
            this.btnRegisterACarCancel.Location = new System.Drawing.Point(22, 191);
            this.btnRegisterACarCancel.Name = "btnRegisterACarCancel";
            this.btnRegisterACarCancel.Size = new System.Drawing.Size(50, 23);
            this.btnRegisterACarCancel.TabIndex = 10;
            this.btnRegisterACarCancel.Text = "Cancel";
            this.btnRegisterACarCancel.UseVisualStyleBackColor = true;
            this.btnRegisterACarCancel.Click += new System.EventHandler(this.btnRegisterACarCancel_Click);
            // 
            // btnRegisterCar
            // 
            this.btnRegisterCar.Location = new System.Drawing.Point(78, 191);
            this.btnRegisterCar.Name = "btnRegisterCar";
            this.btnRegisterCar.Size = new System.Drawing.Size(72, 23);
            this.btnRegisterCar.TabIndex = 11;
            this.btnRegisterCar.Text = "Register car";
            this.btnRegisterCar.UseVisualStyleBackColor = true;
            this.btnRegisterCar.Click += new System.EventHandler(this.btnRegisterCar_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 300;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // FormRegisterACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 226);
            this.Controls.Add(this.btnRegisterCar);
            this.Controls.Add(this.btnRegisterACarCancel);
            this.Controls.Add(this.cbxReleaseYear);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRegisterACar";
            this.Text = "Car register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxReleaseYear;
        private System.Windows.Forms.Button btnRegisterACarCancel;
        private System.Windows.Forms.Button btnRegisterCar;
        private System.Windows.Forms.Timer tmr;
    }
}