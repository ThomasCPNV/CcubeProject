namespace view
{
    partial class FormRegister
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
            this.btnRegisterSignIn = new System.Windows.Forms.Button();
            this.btnRegisterSignUp = new System.Windows.Forms.Button();
            this.btnRegisterCancel = new System.Windows.Forms.Button();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.txtRegisterConfirm = new System.Windows.Forms.TextBox();
            this.lblRegisterConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterSignIn
            // 
            this.btnRegisterSignIn.Location = new System.Drawing.Point(713, 12);
            this.btnRegisterSignIn.Name = "btnRegisterSignIn";
            this.btnRegisterSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSignIn.TabIndex = 13;
            this.btnRegisterSignIn.Text = "Sign In";
            this.btnRegisterSignIn.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSignUp
            // 
            this.btnRegisterSignUp.Location = new System.Drawing.Point(409, 284);
            this.btnRegisterSignUp.Name = "btnRegisterSignUp";
            this.btnRegisterSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSignUp.TabIndex = 12;
            this.btnRegisterSignUp.Text = "Sign Up";
            this.btnRegisterSignUp.UseVisualStyleBackColor = true;
            // 
            // btnRegisterCancel
            // 
            this.btnRegisterCancel.Location = new System.Drawing.Point(312, 284);
            this.btnRegisterCancel.Name = "btnRegisterCancel";
            this.btnRegisterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCancel.TabIndex = 11;
            this.btnRegisterCancel.Text = "Cancel";
            this.btnRegisterCancel.UseVisualStyleBackColor = true;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterPassword.Location = new System.Drawing.Point(368, 208);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(100, 13);
            this.txtRegisterPassword.TabIndex = 10;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterEmail.Location = new System.Drawing.Point(368, 174);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(100, 13);
            this.txtRegisterEmail.TabIndex = 9;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(309, 208);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLoginPassword.TabIndex = 8;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(330, 174);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(32, 13);
            this.lblRegisterEmail.TabIndex = 7;
            this.lblRegisterEmail.Text = "Email";
            // 
            // txtRegisterConfirm
            // 
            this.txtRegisterConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterConfirm.Location = new System.Drawing.Point(368, 227);
            this.txtRegisterConfirm.Name = "txtRegisterConfirm";
            this.txtRegisterConfirm.Size = new System.Drawing.Size(100, 13);
            this.txtRegisterConfirm.TabIndex = 15;
            // 
            // lblRegisterConfirm
            // 
            this.lblRegisterConfirm.AutoSize = true;
            this.lblRegisterConfirm.Location = new System.Drawing.Point(320, 227);
            this.lblRegisterConfirm.Name = "lblRegisterConfirm";
            this.lblRegisterConfirm.Size = new System.Drawing.Size(42, 13);
            this.lblRegisterConfirm.TabIndex = 14;
            this.lblRegisterConfirm.Text = "Confirm";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegisterConfirm);
            this.Controls.Add(this.lblRegisterConfirm);
            this.Controls.Add(this.btnRegisterSignIn);
            this.Controls.Add(this.btnRegisterSignUp);
            this.Controls.Add(this.btnRegisterCancel);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblRegisterEmail);
            this.Name = "FormRegister";
            this.Text = "Car Cost Calculator - Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterSignIn;
        private System.Windows.Forms.Button btnRegisterSignUp;
        private System.Windows.Forms.Button btnRegisterCancel;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.TextBox txtRegisterConfirm;
        private System.Windows.Forms.Label lblRegisterConfirm;
    }
}