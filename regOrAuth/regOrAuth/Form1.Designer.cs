namespace regOrAuth
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginAuth = new System.Windows.Forms.TextBox();
            this.passAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorization = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.LinkLabel();
            this.pathToFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passForStor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginAuth
            // 
            this.loginAuth.Location = new System.Drawing.Point(301, 148);
            this.loginAuth.Name = "loginAuth";
            this.loginAuth.Size = new System.Drawing.Size(100, 20);
            this.loginAuth.TabIndex = 0;
            this.loginAuth.Text = "login";
            // 
            // passAuth
            // 
            this.passAuth.Location = new System.Drawing.Point(301, 225);
            this.passAuth.Name = "passAuth";
            this.passAuth.Size = new System.Drawing.Size(100, 20);
            this.passAuth.TabIndex = 1;
            this.passAuth.Text = "qwerty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // authorization
            // 
            this.authorization.Enabled = false;
            this.authorization.Location = new System.Drawing.Point(316, 281);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(75, 23);
            this.authorization.TabIndex = 4;
            this.authorization.Text = "authorize";
            this.authorization.UseVisualStyleBackColor = true;
            this.authorization.Click += new System.EventHandler(this.authorization_Click);
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.Location = new System.Drawing.Point(329, 319);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(50, 13);
            this.registration.TabIndex = 5;
            this.registration.TabStop = true;
            this.registration.Text = "registrate";
            this.registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);
            // 
            // pathToFile
            // 
            this.pathToFile.Location = new System.Drawing.Point(12, 409);
            this.pathToFile.Name = "pathToFile";
            this.pathToFile.Size = new System.Drawing.Size(776, 20);
            this.pathToFile.TabIndex = 6;
            this.pathToFile.Text = "C:\\Users\\User\\Desktop\\db.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path to storage-file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password for storage";
            // 
            // passForStor
            // 
            this.passForStor.Location = new System.Drawing.Point(12, 464);
            this.passForStor.Name = "passForStor";
            this.passForStor.Size = new System.Drawing.Size(776, 20);
            this.passForStor.TabIndex = 9;
            this.passForStor.TextChanged += new System.EventHandler(this.passForStor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.passForStor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathToFile);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.authorization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passAuth);
            this.Controls.Add(this.loginAuth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginAuth;
        private System.Windows.Forms.TextBox passAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button authorization;
        private System.Windows.Forms.LinkLabel registration;
        private System.Windows.Forms.TextBox pathToFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passForStor;
    }
}

