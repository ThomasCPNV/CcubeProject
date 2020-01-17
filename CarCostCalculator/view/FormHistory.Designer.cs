namespace view
{
    partial class FormHistory
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
            this.lstLicense = new System.Windows.Forms.ListView();
            this.clmcantonRegistration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCO2Emission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLicenseResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstEssentials = new System.Windows.Forms.ListView();
            this.clmInsurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTires = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRevision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSupportResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstInitialPurchase = new System.Windows.Forms.ListView();
            this.lstConsommation = new System.Windows.Forms.ListView();
            this.clmPurchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLifetimeEstimation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInitialPriceResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCp100km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDpM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmConsommationResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLicense
            // 
            this.lstLicense.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmcantonRegistration,
            this.clmPower,
            this.clmWeight,
            this.clmCO2Emission,
            this.clmLicenseResult});
            this.lstLicense.Location = new System.Drawing.Point(12, 29);
            this.lstLicense.Name = "lstLicense";
            this.lstLicense.Size = new System.Drawing.Size(377, 54);
            this.lstLicense.TabIndex = 0;
            this.lstLicense.UseCompatibleStateImageBehavior = false;
            // 
            // clmcantonRegistration
            // 
            this.clmcantonRegistration.Text = "Canton registration";
            // 
            // clmPower
            // 
            this.clmPower.Text = "Power";
            // 
            // clmWeight
            // 
            this.clmWeight.Text = "Weight";
            // 
            // clmCO2Emission
            // 
            this.clmCO2Emission.Text = "Co2 emission";
            // 
            // clmLicenseResult
            // 
            this.clmLicenseResult.Text = "Result";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(314, 335);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lstEssentials
            // 
            this.lstEssentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmInsurance,
            this.clmTires,
            this.clmRevision,
            this.clmSupportResult});
            this.lstEssentials.Location = new System.Drawing.Point(12, 111);
            this.lstEssentials.Name = "lstEssentials";
            this.lstEssentials.Size = new System.Drawing.Size(377, 54);
            this.lstEssentials.TabIndex = 2;
            this.lstEssentials.UseCompatibleStateImageBehavior = false;
            // 
            // clmInsurance
            // 
            this.clmInsurance.Text = "Insurance";
            // 
            // clmTires
            // 
            this.clmTires.Text = "Tires";
            // 
            // clmRevision
            // 
            this.clmRevision.Text = "Revision";
            // 
            // clmSupportResult
            // 
            this.clmSupportResult.Text = "Result";
            // 
            // lstInitialPurchase
            // 
            this.lstInitialPurchase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPurchasePrice,
            this.clmLifetimeEstimation,
            this.clmInitialPriceResult});
            this.lstInitialPurchase.Location = new System.Drawing.Point(12, 193);
            this.lstInitialPurchase.Name = "lstInitialPurchase";
            this.lstInitialPurchase.Size = new System.Drawing.Size(377, 54);
            this.lstInitialPurchase.TabIndex = 3;
            this.lstInitialPurchase.UseCompatibleStateImageBehavior = false;
            // 
            // lstConsommation
            // 
            this.lstConsommation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFuel,
            this.clmCp100km,
            this.clmDpM,
            this.clmConsommationResult});
            this.lstConsommation.Location = new System.Drawing.Point(12, 275);
            this.lstConsommation.Name = "lstConsommation";
            this.lstConsommation.Size = new System.Drawing.Size(377, 54);
            this.lstConsommation.TabIndex = 4;
            this.lstConsommation.UseCompatibleStateImageBehavior = false;
            // 
            // clmPurchasePrice
            // 
            this.clmPurchasePrice.Text = "Purchase price";
            // 
            // clmLifetimeEstimation
            // 
            this.clmLifetimeEstimation.Text = "Lifetime estimation";
            // 
            // clmInitialPriceResult
            // 
            this.clmInitialPriceResult.Text = "Result";
            // 
            // clmFuel
            // 
            this.clmFuel.Text = "Fuel";
            // 
            // clmCp100km
            // 
            this.clmCp100km.Text = "Consommation /100km";
            // 
            // clmDpM
            // 
            this.clmDpM.Text = "Distance /month";
            // 
            // clmConsommationResult
            // 
            this.clmConsommationResult.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "License plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Essentials supports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial car price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Consommation";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstConsommation);
            this.Controls.Add(this.lstInitialPurchase);
            this.Controls.Add(this.lstEssentials);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstLicense);
            this.Name = "FormHistory";
            this.Text = "History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstLicense;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lstEssentials;
        private System.Windows.Forms.ListView lstInitialPurchase;
        private System.Windows.Forms.ListView lstConsommation;
        private System.Windows.Forms.ColumnHeader clmcantonRegistration;
        private System.Windows.Forms.ColumnHeader clmPower;
        private System.Windows.Forms.ColumnHeader clmWeight;
        private System.Windows.Forms.ColumnHeader clmCO2Emission;
        private System.Windows.Forms.ColumnHeader clmLicenseResult;
        private System.Windows.Forms.ColumnHeader clmInsurance;
        private System.Windows.Forms.ColumnHeader clmTires;
        private System.Windows.Forms.ColumnHeader clmRevision;
        private System.Windows.Forms.ColumnHeader clmSupportResult;
        private System.Windows.Forms.ColumnHeader clmPurchasePrice;
        private System.Windows.Forms.ColumnHeader clmLifetimeEstimation;
        private System.Windows.Forms.ColumnHeader clmInitialPriceResult;
        private System.Windows.Forms.ColumnHeader clmFuel;
        private System.Windows.Forms.ColumnHeader clmCp100km;
        private System.Windows.Forms.ColumnHeader clmDpM;
        private System.Windows.Forms.ColumnHeader clmConsommationResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}