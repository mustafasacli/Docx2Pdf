using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public partial class Demo
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.TextBox OutputFile;
        private System.Windows.Forms.CheckBox UseBuffer;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.LinkLabel Purchase;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFile = new System.Windows.Forms.TextBox();
            this.OutputFile = new System.Windows.Forms.TextBox();
            this.UseBuffer = new System.Windows.Forms.CheckBox();
            this.Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Purchase = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File Name (.docx)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output File Name (.pdf)";
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(8, 32);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(320, 20);
            this.InputFile.TabIndex = 2;
            // 
            // OutputFile
            // 
            this.OutputFile.Location = new System.Drawing.Point(8, 80);
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.Size = new System.Drawing.Size(320, 20);
            this.OutputFile.TabIndex = 3;
            // 
            // UseBuffer
            // 
            this.UseBuffer.Location = new System.Drawing.Point(8, 120);
            this.UseBuffer.Name = "UseBuffer";
            this.UseBuffer.Size = new System.Drawing.Size(184, 16);
            this.UseBuffer.TabIndex = 6;
            this.UseBuffer.Text = "Transfer file as buffer";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(208, 120);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(120, 16);
            this.Status.TabIndex = 7;
            this.Status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UseBuffer);
            this.groupBox1.Controls.Add(this.OutputFile);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(272, 160);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(192, 160);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            // 
            // Purchase
            // 
            this.Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.Purchase.Location = new System.Drawing.Point(8, 160);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(80, 16);
            this.Purchase.TabIndex = 11;
            this.Purchase.Text = "Purchase...";
            this.Purchase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Purchase_LinkClicked);
            // 
            // Demo
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(352, 189);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DOCX to PDF Converter Demo";
            this.Load += new System.EventHandler(this.Demo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
