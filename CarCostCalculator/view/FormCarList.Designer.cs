namespace view
{
    partial class FormCarList
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
            this.lstCar = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.clmCarListVanish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstCar
            // 
            this.lstCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmBrand,
            this.clmModel,
            this.clmVersion,
            this.clmType,
            this.clmRelease,
            this.clmCarListVanish});
            this.lstCar.FullRowSelect = true;
            this.lstCar.GridLines = true;
            this.lstCar.Location = new System.Drawing.Point(12, 12);
            this.lstCar.MultiSelect = false;
            this.lstCar.Name = "lstCar";
            this.lstCar.ShowGroups = false;
            this.lstCar.ShowItemToolTips = true;
            this.lstCar.Size = new System.Drawing.Size(241, 263);
            this.lstCar.TabIndex = 0;
            this.lstCar.UseCompatibleStateImageBehavior = false;
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            // 
            // clmBrand
            // 
            this.clmBrand.Text = "Brand";
            // 
            // clmModel
            // 
            this.clmModel.Text = "Model";
            // 
            // clmVersion
            // 
            this.clmVersion.Text = "Version";
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            // 
            // clmRelease
            // 
            this.clmRelease.Text = "Release";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(178, 281);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // clmCarListVanish
            // 
            this.clmCarListVanish.Text = "";
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 313);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstCar);
            this.Name = "FormCarList";
            this.Text = "FormCarList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmBrand;
        private System.Windows.Forms.ColumnHeader clmModel;
        private System.Windows.Forms.ColumnHeader clmVersion;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ColumnHeader clmRelease;
        private System.Windows.Forms.ColumnHeader clmCarListVanish;
    }
}