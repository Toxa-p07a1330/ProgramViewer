namespace SoupImage
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
            this.soup_picture = new System.Windows.Forms.PictureBox();
            this.screen_picture = new System.Windows.Forms.PictureBox();
            this.makeScreen_button = new System.Windows.Forms.Button();
            this.soup_button = new System.Windows.Forms.Button();
            this.percenOfSoup = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.makeBW = new System.Windows.Forms.Button();
            this.transporate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.import = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.pass_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soup_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percenOfSoup)).BeginInit();
            this.SuspendLayout();
            // 
            // soup_picture
            // 
            this.soup_picture.Location = new System.Drawing.Point(649, 12);
            this.soup_picture.Name = "soup_picture";
            this.soup_picture.Size = new System.Drawing.Size(589, 537);
            this.soup_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soup_picture.TabIndex = 1;
            this.soup_picture.TabStop = false;
            // 
            // screen_picture
            // 
            this.screen_picture.Location = new System.Drawing.Point(12, 12);
            this.screen_picture.Name = "screen_picture";
            this.screen_picture.Size = new System.Drawing.Size(589, 537);
            this.screen_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screen_picture.TabIndex = 2;
            this.screen_picture.TabStop = false;
            // 
            // makeScreen_button
            // 
            this.makeScreen_button.Location = new System.Drawing.Point(28, 578);
            this.makeScreen_button.Name = "makeScreen_button";
            this.makeScreen_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.makeScreen_button.Size = new System.Drawing.Size(111, 23);
            this.makeScreen_button.TabIndex = 3;
            this.makeScreen_button.Text = "Make screen";
            this.makeScreen_button.UseVisualStyleBackColor = true;
            this.makeScreen_button.Click += new System.EventHandler(this.makeScreen_Click);
            // 
            // soup_button
            // 
            this.soup_button.Location = new System.Drawing.Point(174, 578);
            this.soup_button.Name = "soup_button";
            this.soup_button.Size = new System.Drawing.Size(75, 23);
            this.soup_button.TabIndex = 4;
            this.soup_button.Text = "Soup";
            this.soup_button.UseVisualStyleBackColor = true;
            this.soup_button.Click += new System.EventHandler(this.soup_button_Click);
            // 
            // percenOfSoup
            // 
            this.percenOfSoup.Location = new System.Drawing.Point(273, 555);
            this.percenOfSoup.Maximum = 100;
            this.percenOfSoup.Name = "percenOfSoup";
            this.percenOfSoup.Size = new System.Drawing.Size(104, 42);
            this.percenOfSoup.TabIndex = 5;
            this.percenOfSoup.Value = 50;
            this.percenOfSoup.Scroll += new System.EventHandler(this.percenOfSoup_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "percent";
            // 
            // makeBW
            // 
            this.makeBW.Location = new System.Drawing.Point(405, 578);
            this.makeBW.Name = "makeBW";
            this.makeBW.Size = new System.Drawing.Size(75, 23);
            this.makeBW.TabIndex = 7;
            this.makeBW.Text = "Make BW";
            this.makeBW.UseVisualStyleBackColor = true;
            this.makeBW.Click += new System.EventHandler(this.makeBW_Click);
            // 
            // transporate
            // 
            this.transporate.Location = new System.Drawing.Point(509, 578);
            this.transporate.Name = "transporate";
            this.transporate.Size = new System.Drawing.Size(107, 23);
            this.transporate.TabIndex = 8;
            this.transporate.Text = "Transponate up";
            this.transporate.UseVisualStyleBackColor = true;
            this.transporate.Click += new System.EventHandler(this.transporate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(649, 578);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 9;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(756, 578);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 10;
            this.apply_button.Text = "<--";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(983, 581);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(65, 23);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // pass_button
            // 
            this.pass_button.Location = new System.Drawing.Point(848, 578);
            this.pass_button.Name = "pass_button";
            this.pass_button.Size = new System.Drawing.Size(75, 23);
            this.pass_button.TabIndex = 12;
            this.pass_button.Text = "-->";
            this.pass_button.UseVisualStyleBackColor = true;
            this.pass_button.Click += new System.EventHandler(this.pass_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 616);
            this.Controls.Add(this.pass_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.import);
            this.Controls.Add(this.transporate);
            this.Controls.Add(this.makeBW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percenOfSoup);
            this.Controls.Add(this.soup_button);
            this.Controls.Add(this.makeScreen_button);
            this.Controls.Add(this.screen_picture);
            this.Controls.Add(this.soup_picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.soup_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percenOfSoup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox soup_picture;
        private System.Windows.Forms.PictureBox screen_picture;
        private System.Windows.Forms.Button makeScreen_button;
        private System.Windows.Forms.Button soup_button;
        private System.Windows.Forms.TrackBar percenOfSoup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makeBW;
        private System.Windows.Forms.Button transporate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button pass_button;
    }
}

