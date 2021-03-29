namespace Final_Exam
{
   partial class School
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(School));
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // richTextBox1
         // 
         this.richTextBox1.BackColor = System.Drawing.Color.Tan;
         this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.richTextBox1.Font = new System.Drawing.Font("Modern No. 20", 24.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.richTextBox1.ForeColor = System.Drawing.Color.Crimson;
         this.richTextBox1.Location = new System.Drawing.Point(281, 6);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(399, 45);
         this.richTextBox1.TabIndex = 0;
         this.richTextBox1.Text = "Welcome to ICON  School";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(258, 250);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(429, 64);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(74, 14);
         this.label1.TabIndex = 2;
         this.label1.Text = "User Name:";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(384, 80);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(171, 20);
         this.textBox1.TabIndex = 3;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(384, 138);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(171, 20);
         this.textBox2.TabIndex = 5;
         this.textBox2.UseSystemPasswordChar = true;
         this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(435, 122);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(70, 14);
         this.label2.TabIndex = 4;
         this.label2.Text = "Password:";
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Tan;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.Location = new System.Drawing.Point(432, 186);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 6;
         this.button1.Text = "Login";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // School
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.Tan;
         this.ClientSize = new System.Drawing.Size(692, 248);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.richTextBox1);
         this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
         this.Name = "School";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "School";
         this.Load += new System.EventHandler(this.School_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button1;
   }
}