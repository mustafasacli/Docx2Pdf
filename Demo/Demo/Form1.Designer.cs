namespace Demo
{
    partial class Form1
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
            this.tbCtrlMain = new System.Windows.Forms.TabControl();
            this.tbPgTables = new System.Windows.Forms.TabPage();
            this.tblytTables = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytTablesLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.tblLytTableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tbPgLogs = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tbCtrlMain.SuspendLayout();
            this.tbPgTables.SuspendLayout();
            this.tblytTables.SuspendLayout();
            this.tblLytTablesLeft.SuspendLayout();
            this.tblLytTableButtons.SuspendLayout();
            this.tbPgLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlMain
            // 
            this.tbCtrlMain.Controls.Add(this.tbPgTables);
            this.tbCtrlMain.Controls.Add(this.tbPgLogs);
            this.tbCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tbCtrlMain.Name = "tbCtrlMain";
            this.tbCtrlMain.SelectedIndex = 0;
            this.tbCtrlMain.Size = new System.Drawing.Size(1471, 651);
            this.tbCtrlMain.TabIndex = 0;
            // 
            // tbPgTables
            // 
            this.tbPgTables.Controls.Add(this.tblytTables);
            this.tbPgTables.Location = new System.Drawing.Point(4, 25);
            this.tbPgTables.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgTables.Name = "tbPgTables";
            this.tbPgTables.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgTables.Size = new System.Drawing.Size(1463, 622);
            this.tbPgTables.TabIndex = 0;
            this.tbPgTables.Text = "Tables";
            this.tbPgTables.UseVisualStyleBackColor = true;
            // 
            // tblytTables
            // 
            this.tblytTables.ColumnCount = 2;
            this.tblytTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblytTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblytTables.Controls.Add(this.tblLytTablesLeft, 0, 0);
            this.tblytTables.Controls.Add(this.txtResult, 1, 0);
            this.tblytTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblytTables.Location = new System.Drawing.Point(4, 4);
            this.tblytTables.Name = "tblytTables";
            this.tblytTables.RowCount = 1;
            this.tblytTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblytTables.Size = new System.Drawing.Size(1455, 614);
            this.tblytTables.TabIndex = 0;
            // 
            // tblLytTablesLeft
            // 
            this.tblLytTablesLeft.ColumnCount = 1;
            this.tblLytTablesLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTablesLeft.Controls.Add(this.lstFiles, 0, 0);
            this.tblLytTablesLeft.Controls.Add(this.tblLytTableButtons, 0, 1);
            this.tblLytTablesLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytTablesLeft.Location = new System.Drawing.Point(3, 3);
            this.tblLytTablesLeft.Name = "tblLytTablesLeft";
            this.tblLytTablesLeft.RowCount = 2;
            this.tblLytTablesLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTablesLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytTablesLeft.Size = new System.Drawing.Size(721, 608);
            this.tblLytTablesLeft.TabIndex = 0;
            // 
            // lstFiles
            // 
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 16;
            this.lstFiles.Location = new System.Drawing.Point(3, 3);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(715, 522);
            this.lstFiles.TabIndex = 1;
            // 
            // tblLytTableButtons
            // 
            this.tblLytTableButtons.ColumnCount = 3;
            this.tblLytTableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytTableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytTableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLytTableButtons.Controls.Add(this.btnGetTables, 0, 0);
            this.tblLytTableButtons.Controls.Add(this.btnConvert, 2, 0);
            this.tblLytTableButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblLytTableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytTableButtons.Location = new System.Drawing.Point(3, 531);
            this.tblLytTableButtons.Name = "tblLytTableButtons";
            this.tblLytTableButtons.RowCount = 1;
            this.tblLytTableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTableButtons.Size = new System.Drawing.Size(715, 74);
            this.tblLytTableButtons.TabIndex = 2;
            // 
            // btnGetTables
            // 
            this.btnGetTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetTables.Location = new System.Drawing.Point(74, 17);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(90, 40);
            this.btnGetTables.TabIndex = 0;
            this.btnGetTables.Text = "Get Tables";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.Location = new System.Drawing.Point(550, 17);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 40);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(312, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(730, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(722, 608);
            this.txtResult.TabIndex = 1;
            // 
            // tbPgLogs
            // 
            this.tbPgLogs.Controls.Add(this.txtLog);
            this.tbPgLogs.Location = new System.Drawing.Point(4, 25);
            this.tbPgLogs.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgLogs.Name = "tbPgLogs";
            this.tbPgLogs.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgLogs.Size = new System.Drawing.Size(1463, 622);
            this.tbPgLogs.TabIndex = 1;
            this.tbPgLogs.Text = "Logs";
            this.tbPgLogs.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(4, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1455, 614);
            this.txtLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 651);
            this.Controls.Add(this.tbCtrlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tbCtrlMain.ResumeLayout(false);
            this.tbPgTables.ResumeLayout(false);
            this.tblytTables.ResumeLayout(false);
            this.tblytTables.PerformLayout();
            this.tblLytTablesLeft.ResumeLayout(false);
            this.tblLytTableButtons.ResumeLayout(false);
            this.tbPgLogs.ResumeLayout(false);
            this.tbPgLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlMain;
        private System.Windows.Forms.TabPage tbPgTables;
        private System.Windows.Forms.TabPage tbPgLogs;
        private System.Windows.Forms.TableLayoutPanel tblytTables;
        private System.Windows.Forms.TableLayoutPanel tblLytTablesLeft;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TableLayoutPanel tblLytTableButtons;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDelete;
    }
}

