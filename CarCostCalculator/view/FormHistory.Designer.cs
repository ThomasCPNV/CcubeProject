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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstEssentials = new System.Windows.Forms.ListView();
            this.lstInitialPurchase = new System.Windows.Forms.ListView();
            this.lstConsommation = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstLicense
            // 
            this.lstLicense.Location = new System.Drawing.Point(12, 12);
            this.lstLicense.Name = "lstLicense";
            this.lstLicense.Size = new System.Drawing.Size(377, 54);
            this.lstLicense.TabIndex = 0;
            this.lstLicense.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(314, 252);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // lstEssentials
            // 
            this.lstEssentials.Location = new System.Drawing.Point(12, 72);
            this.lstEssentials.Name = "lstEssentials";
            this.lstEssentials.Size = new System.Drawing.Size(377, 54);
            this.lstEssentials.TabIndex = 2;
            this.lstEssentials.UseCompatibleStateImageBehavior = false;
            // 
            // lstInitialPurchase
            // 
            this.lstInitialPurchase.Location = new System.Drawing.Point(12, 132);
            this.lstInitialPurchase.Name = "lstInitialPurchase";
            this.lstInitialPurchase.Size = new System.Drawing.Size(377, 54);
            this.lstInitialPurchase.TabIndex = 3;
            this.lstInitialPurchase.UseCompatibleStateImageBehavior = false;
            // 
            // lstConsommation
            // 
            this.lstConsommation.Location = new System.Drawing.Point(12, 192);
            this.lstConsommation.Name = "lstConsommation";
            this.lstConsommation.Size = new System.Drawing.Size(377, 54);
            this.lstConsommation.TabIndex = 4;
            this.lstConsommation.UseCompatibleStateImageBehavior = false;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 283);
            this.Controls.Add(this.lstConsommation);
            this.Controls.Add(this.lstInitialPurchase);
            this.Controls.Add(this.lstEssentials);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstLicense);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLicense;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lstEssentials;
        private System.Windows.Forms.ListView lstInitialPurchase;
        private System.Windows.Forms.ListView lstConsommation;
    }
}