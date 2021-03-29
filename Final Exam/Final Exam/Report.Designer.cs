namespace Final_Exam
{
   partial class Report
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
         this.components = new System.ComponentModel.Container();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
         this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.Data_studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.StudentDataSet = new Final_Exam.StudentDataSet();
         this.Data_studentTableAdapter = new Final_Exam.StudentDataSetTableAdapters.Data_studentTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Data_studentBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentDataSet)).BeginInit();
         this.SuspendLayout();
         // 
         // reportViewer1
         // 
         reportDataSource1.Name = "DataSet1";
         reportDataSource1.Value = this.Data_studentBindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_Exam.Report1.rdlc";
         this.reportViewer1.Location = new System.Drawing.Point(-5, 114);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.Size = new System.Drawing.Size(848, 266);
         this.reportViewer1.TabIndex = 0;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(139, 119);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // richTextBox1
         // 
         this.richTextBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.richTextBox1.Font = new System.Drawing.Font("Yu Gothic", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.richTextBox1.Location = new System.Drawing.Point(343, 14);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(199, 51);
         this.richTextBox1.TabIndex = 2;
         this.richTextBox1.Text = "ICON School";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(432, 81);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(202, 20);
         this.textBox1.TabIndex = 3;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button1.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Bold);
         this.button1.ForeColor = System.Drawing.Color.Crimson;
         this.button1.Location = new System.Drawing.Point(266, 77);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(160, 28);
         this.button1.TabIndex = 4;
         this.button1.Text = "Search for Level:";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // Data_studentBindingSource
         // 
         this.Data_studentBindingSource.DataMember = "Data_student";
         this.Data_studentBindingSource.DataSource = this.StudentDataSet;
         // 
         // StudentDataSet
         // 
         this.StudentDataSet.DataSetName = "StudentDataSet";
         this.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // Data_studentTableAdapter
         // 
         this.Data_studentTableAdapter.ClearBeforeFill = true;
         // 
         // Report
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(840, 374);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.richTextBox1);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.reportViewer1);
         this.Name = "Report";
         this.Text = "Report";
         this.Load += new System.EventHandler(this.Report_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Data_studentBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.StudentDataSet)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
      private System.Windows.Forms.BindingSource Data_studentBindingSource;
      private StudentDataSet StudentDataSet;
      private StudentDataSetTableAdapters.Data_studentTableAdapter Data_studentTableAdapter;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button1;
   }
}