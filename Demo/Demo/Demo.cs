using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text;
using SubSystems.DP;             // DOCX to PDF Converter

namespace Demo
{
    /// <summary>
    /// Summary description for demo.
    /// </summary>
    public partial class Demo : System.Windows.Forms.Form
    {

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///    Constructor
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        public Demo()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

        }



        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs ev)
        {
            base.OnPaintBackground(ev);
        }

        private void Demo_Load(object sender, System.EventArgs e)
        {
            Purchase.Links.Add(0, 11, "www.subsystems.com/dpw.htm");
            //DemoTest1();   // test code
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            bool result = false;

            Status.Text = "";

            string InFile = InputFile.Text;
            string OutFile = OutputFile.Text;

            // check the file names
            if (InFile.Length == 0)
            {
                InputFile.Focus();
                return;
            }
            if (OutFile.Length == 0)
            {
                OutputFile.Focus();
                return;
            }

            Status.Text = "Converting...";
            Status.Refresh();

            // do the conversion
            Dpn dpn = new Dpn();

            //dpn.InWebServer = true;

            //dpn.DpsSetPaperSize(PaperKind.Custom, 12240, 15840);
            //dpn.DpsSetPaperOrient(false);
            //dpn.DpsSetPageMargin(720, 720, 720, 720);
            //dpn.DpsSetPageBorder(Dpn.BRDRTYPE_DBL,30,720,Color.Red);
            //dpn.DpsSetPageRange(0,0);      // example to print just the first page

            //dpn.OwnerPassword = "owner";
            //dpn.UserPassword = "user";
            //dpn.PermFlags = 0; // Dpn.PERM_COPY | Dpn.PERM_MOD;
            //dpn.PictQuality = 5; // picture quality, 1=lowest, 5=highest, 3=default
            //dpn.DoCaching=false;  // write directly to disk
            //dpn.ExactTextPlacement=true;
            //dpn.MacCompatible=true;
            //dpn.PdfA=true;               // generate pdfA compliant output

            if (UseBuffer.Checked)
            {  // read the file in the memory buffer and do the conversion
                byte[] InData = null;
                string OutData;

                if ((InData = dpn.DpsFileToBytes(InFile)) != null)
                {
                    if ((OutData = dpn.DpsConvertBuffer(InData)) != null)
                    {
                        result = dpn.DpsWriteToFile(OutFile, OutData); // write the memory to the output file   
                    }
                }
            }
            else result = dpn.DpsConvertFile(InFile, OutFile);       // convert files directly

            InputFile.Focus();    // ask for the next file
            Status.Text = result ? "Done!" : "Error!";

            if (result)
            {
                try { System.Diagnostics.Process.Start(OutFile); }  // display pdf
                catch { };
            }
        }

        private void Purchase_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs ev)
        {
            // Determine which link was clicked within the LinkLabel.
            Purchase.Links[Purchase.Links.IndexOf(ev.Link)].Visited = true;
            // Display the appropriate link based on the value of the LinkData property of the Link object.
            System.Diagnostics.Process.Start(ev.Link.LinkData.ToString());
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////  Helper functions
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        string ReadFromFile(string file)
        {
            string str = null;

            StreamReader InFile = null;
            if ((InFile = new StreamReader(file)) != null)
            {
                str = InFile.ReadToEnd();
                InFile.Close();
            }

            return str;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //    Testing/Debugging code                                                                    
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /***************************************************************************
            DemoTest1:
            test code
        ****************************************************************************/
        internal new void DemoTest1()
        {

        }

        /***************************************************************************
            ToInt:
            Convert string to integer
        ****************************************************************************/
        internal new int ToInt(TextBox item)
        {
            return ToInt(item.Text);
        }

        internal new int ToInt(string txt)
        {
            try
            {
                return (int)Convert.ToInt32(txt);
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        internal new bool True(int val)
        {
            return (val != 0);
        }


    }
}
