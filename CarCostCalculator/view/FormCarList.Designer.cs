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
            this.btnSelect = new System.Windows.Forms.Button();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstCar
            // 
            this.lstCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.Model,
            this.Version});
            this.lstCar.Location = new System.Drawing.Point(12, 12);
            this.lstCar.Name = "lstCar";
            this.lstCar.Size = new System.Drawing.Size(198, 263);
            this.lstCar.TabIndex = 0;
            this.lstCar.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(135, 281);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 313);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstCar);
            this.Name = "FormCarList";
            this.Text = "FormCarList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Version;
    }
}