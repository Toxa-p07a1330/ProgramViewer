namespace regOrAuth
{
    partial class Registration
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
            this.loginReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passReg1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passReg2 = new System.Windows.Forms.TextBox();
            this.agreement = new System.Windows.Forms.CheckBox();
            this.registr = new System.Windows.Forms.Button();
            this.auth = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginReg
            // 
            this.loginReg.Location = new System.Drawing.Point(282, 122);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(100, 20);
            this.loginReg.TabIndex = 0;
            this.loginReg.TextChanged += new System.EventHandler(this.loginReg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "login";
            // 
            // passReg1
            // 
            this.passReg1.Location = new System.Drawing.Point(282, 204);
            this.passReg1.Name = "passReg1";
            this.passReg1.Size = new System.Drawing.Size(100, 20);
            this.passReg1.TabIndex = 2;
            this.passReg1.UseSystemPasswordChar = true;
            this.passReg1.TextChanged += new System.EventHandler(this.passReg1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "repeat password";
            // 
            // passReg2
            // 
            this.passReg2.Location = new System.Drawing.Point(282, 287);
            this.passReg2.Name = "passReg2";
            this.passReg2.Size = new System.Drawing.Size(100, 20);
            this.passReg2.TabIndex = 5;
            this.passReg2.UseSystemPasswordChar = true;
            this.passReg2.TextChanged += new System.EventHandler(this.passReg2_TextChanged);
            // 
            // agreement
            // 
            this.agreement.AutoSize = true;
            this.agreement.Location = new System.Drawing.Point(282, 335);
            this.agreement.Name = "agreement";
            this.agreement.Size = new System.Drawing.Size(59, 17);
            this.agreement.TabIndex = 6;
            this.agreement.Text = "I agree";
            this.agreement.UseVisualStyleBackColor = true;
            this.agreement.CheckedChanged += new System.EventHandler(this.agreement_CheckedChanged);
            // 
            // registr
            // 
            this.registr.Enabled = false;
            this.registr.Location = new System.Drawing.Point(282, 381);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(75, 23);
            this.registr.TabIndex = 7;
            this.registr.Text = "Registrate";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.registr_Click);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Location = new System.Drawing.Point(282, 425);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(28, 13);
            this.auth.TabIndex = 8;
            this.auth.TabStop = true;
            this.auth.Text = "auth";
            this.auth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.auth_LinkClicked);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.agreement);
            this.Controls.Add(this.passReg2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passReg1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginReg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passReg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passReg2;
        private System.Windows.Forms.CheckBox agreement;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.LinkLabel auth;
    }
}