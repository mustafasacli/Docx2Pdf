using SubSystems.DP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {

        private volatile bool isNotLocked = true;
        Thread thrdInsert;

        public Form1()
        {
            try
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;
            }
            catch (Exception ex)
            {
                writeException("Ctor", ex);
            }
        }

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            GetTables();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        void GetTables()
        {
            if (isNotLocked)
            {
                isNotLocked = false;
                GetTablesAsync();
            }
        }

        void GetTablesAsync()
        {
            try
            {
                lstFiles.Items.Clear();
                txtLog.Text = string.Empty;
                writeLog("Liste Temizlendi.");

                string path = string.Empty;


                // Dosya yolu ayarlama

                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {

                    DialogResult dr = fbd.ShowDialog();

                    if (dr != System.Windows.Forms.DialogResult.OK)
                    {
                        writeLog("Dosya yolu seçme iptal edildi.");
                        return;
                    }

                    path = fbd.SelectedPath;

                    if (string.IsNullOrWhiteSpace(path))
                    {
                        writeLog("Dosya yolu boş.");
                        return;
                    }

                    string[] filePaths = Directory.GetFiles(path, "*.docx");

                    if (filePaths == null)
                    {
                        writeLog("Dosya listesi geçersiz.");
                        return;
                    }


                    if (filePaths.Length == 0)
                    {
                        writeLog("Dosya bulunamadı.");
                        return;
                    }

                    // filePaths = filePaths.AsQueryable().Where(f => f.EndsWith(".docx")).ToArray<string>();
                    writeLog("Dosya listesi yazılmaya başlandı.");

                    foreach (var item in filePaths)
                    {
                        lstFiles.Items.Add(item);
                    }

                    writeLog("Dosya listesi yazılma işlemi bitti.");

                }

            }
            catch (Exception ex)
            {
                writeException("GetTables", ex);
            }
            finally
            {
                isNotLocked = true;
            }
        }

        void Convert()
        {
            try
            {
                if (isNotLocked)
                {
                    isNotLocked = false;
                    thrdInsert = new Thread(new ThreadStart(ConvertAsync));
                    thrdInsert.Start();
                }
            }
            catch (Exception ex)
            {
                writeException("Insert", ex);
            }
        }

        void ConvertAsync()
        {
            try
            {
                writeLog("Dosya dönüştürme - yazma işlemi başladı.");
                string saveFilePath = string.Empty;
                string openFilePath = string.Empty;
                bool result = false;
                foreach (var item in lstFiles.Items)
                {
                    try
                    {
                        openFilePath = string.Format("{0}", item);
                        saveFilePath = openFilePath.Replace(".docx", ".pdf");

                        Dpn dpn = new Dpn();

                        result = dpn.DpsConvertFile(openFilePath, saveFilePath);

                        if (result)
                            writeLog(string.Format("{0} File Conversion Successed.", openFilePath));
                        else
                            writeLog(string.Format("{0} File Conversion Failed.", openFilePath));

                    }
                    catch (Exception ex)
                    {
                        writeLog(string.Format("{0} Kaydetme Hata Oluştu.", item));
                        writeException("InsertAsyncForeach", ex);
                    }
                }
                writeLog("Dosya dönüştürme - yazma işlemi bitti.");

            }
            catch (Exception ex)
            {
                writeException("InsertAsync", ex);
            }
            finally
            {
                isNotLocked = true;
            }
        }

        void writeException(string methodName, Exception ex)
        {
            try
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.AppendLine(string.Format("Exception Time : {0}.", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss fff")));
                strBuilder.AppendLine(string.Format("Exception handled at {0} method.", methodName));
                strBuilder.AppendLine(string.Format("Message: {0}", ex.Message));
                strBuilder.AppendLine(string.Format("Stack Trace: {0}", ex.StackTrace));
                strBuilder.AppendLine("********************************************************************");
                string str = strBuilder.ToString();
                txtLog.Text = string.Format("{0}{1}", txtLog.Text, str);

                if (ex.InnerException != null)
                {
                    writeException(string.Format("{0}_Again", methodName), ex.InnerException);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void writeLog(string eventString)
        {
            try
            {
                txtResult.Text = string.Format("{0}{1}{2}", txtResult.Text, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss fff"), Environment.NewLine);
                txtResult.Text = string.Format("{0}{1}{2}", txtResult.Text, eventString, Environment.NewLine);
                txtResult.Text = string.Format("{0}{1}{2}", txtResult.Text, "***********************************************************", Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DateTime GetTime(string timeString)
        {
            DateTime dtNow = DateTime.Now;
            try
            {
                string time = string.Format("{0}", timeString);
                time = time.Substring(0, 14);
                dtNow = DateTime.ParseExact(time, "yyyyMMddHHmmss", null);
            }
            catch (Exception ex)
            {
                writeException("InsertAsync", ex);
            }
            return dtNow;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isNotLocked)
            {
                isNotLocked = false;
                Delete();
            }
        }

        void Delete()
        {
            try
            {
                if (lstFiles.SelectedIndex == -1)
                {
                    return;
                }

                if (lstFiles.SelectedItem == null)
                {
                    return;
                }

                int indx = lstFiles.SelectedIndex;
                string str = string.Format("{0}", lstFiles.SelectedItem);
                DialogResult dr = MessageBox.Show(String.Format("{0} dosyası listeden çıkarılacak, emin misiniz?", str), "Doğrulama", MessageBoxButtons.YesNo);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    lstFiles.Items.RemoveAt(indx);
                    writeLog(string.Format("{0} dosyası listeden çıkarıldı.", str));
                }

            }
            catch (Exception ex)
            {
                writeException("Delete", ex);
            }
            finally
            {
                isNotLocked = true;
            }

        }


    }
}
