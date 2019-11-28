namespace view
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginSignIn = new System.Windows.Forms.Button();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.btnLoginSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(333, 174);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(32, 13);
            this.lblLoginEmail.TabIndex = 0;
            this.lblLoginEmail.Text = "Email";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(312, 204);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginEmail.Location = new System.Drawing.Point(371, 174);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(100, 13);
            this.txtLoginEmail.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Location = new System.Drawing.Point(371, 204);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 13);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLoginSignIn
            // 
            this.btnLoginSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoginSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSignIn.Location = new System.Drawing.Point(411, 288);
            this.btnLoginSignIn.Name = "btnLoginSignIn";
            this.btnLoginSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSignIn.TabIndex = 4;
            this.btnLoginSignIn.Text = "Sign In";
            this.btnLoginSignIn.UseVisualStyleBackColor = false;
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginCancel.Location = new System.Drawing.Point(330, 288);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLoginCancel.TabIndex = 5;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = false;
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSignUp.Location = new System.Drawing.Point(713, 12);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSignUp.TabIndex = 6;
            this.btnLoginSignUp.Text = "Sign Up";
            this.btnLoginSignUp.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginSignUp);
            this.Controls.Add(this.btnLoginCancel);
            this.Controls.Add(this.btnLoginSignIn);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginEmail);
            this.Name = "FormLogin";
            this.Text = "Car Cost Calculator - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginSignIn;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.Button btnLoginSignUp;
    }
}

