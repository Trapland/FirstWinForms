
namespace WinFormsApp1
{
    partial class MyWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(23, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ФИО";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(23, 56);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(291, 60);
            this.FIO.TabIndex = 1;
            this.FIO.Text = "";
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(23, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 16);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "E-mail";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(23, 145);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(291, 60);
            this.Email.TabIndex = 1;
            this.Email.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(23, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 16);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Номер телефона";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(23, 235);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(291, 60);
            this.Number.TabIndex = 1;
            this.Number.Text = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(127, 323);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 57);
            this.Save.TabIndex = 2;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // MyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 392);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.textBox1);
            this.Name = "MyWindow";
            this.Text = "MyWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.RichTextBox FIO;
        public System.Windows.Forms.RichTextBox Email;
        public System.Windows.Forms.RichTextBox Number;
        public System.Windows.Forms.Button Save;
    }
}

