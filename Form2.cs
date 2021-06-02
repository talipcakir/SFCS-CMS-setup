using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SFCS_CMS_Kurulum
{
    public partial class Kurulum_2 : Form
    {

        //SFCS CMS - Link & Path & Command & Extract
        string SFCS_Link = "https://github.com/sfctechnology/sfcs-cms/releases/download/sfcs-cms-2.3.5-xampp-full/xampp.zip";
        string SFCS_Path = @"C:\\SFCS\\SFCS-CMS.zip";
        string SFCS_Folder_Locale = @"c:\SFCS";
        //string c_Locale = @"c:\";
        private BackgroundWorker extractFile;
        private long fileSize;    //the size of the zip file
        private long extractedSizeTotal;    //the bytes total extracted
        private long compressedSize;    //the size of a single compressed file
        private string compressedFileName;    //the name of the file being extracted

        public Kurulum_2()
        {
            InitializeComponent();
            //Folder Create Func.
            folder_Create(SFCS_Folder_Locale);
            Xampp_progressBar.Maximum = int.MaxValue;

            extractFile = new BackgroundWorker();
            extractFile.DoWork += ExtractFile_DoWork;
            extractFile.ProgressChanged += ExtractFile_ProgressChanged;
            extractFile.RunWorkerCompleted += ExtractFile_RunWorkerCompleted;
            extractFile.WorkerReportsProgress = true;
        }

        private void folder_Create(string Folder_Locale)
        {
            bool exists = Directory.Exists(Folder_Locale);
            if (!exists)
            {
                Directory.CreateDirectory(Folder_Locale);
            }
        }

        private void download_Func(string link, string patch, ProgressBar pBar, TextBox download_Info_Label)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DW_Change);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DW_Complate);
            client.DownloadFileAsync(new Uri(link), patch);
        }
        void client_DW_Complate(object sender, AsyncCompletedEventArgs e)
        {
            textBox_ExtractFile.Text = "Completed";
            dw_Button.Enabled = false;
            go_Button.Enabled = true;
        }
        private void client_DW_Change(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            double mbConvert = e.BytesReceived / 1024 / 1024;
            double mbTotalConvert = e.TotalBytesToReceive / 1024 / 1024;
            textBox_ExtractFile.Text = "İndiriliyor: " + mbConvert + "/" + mbTotalConvert+ " MB";
            Xampp_progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        private void Kurulum_2_Leave(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dw_Button_Click(object sender, EventArgs e)
        {
            download_Func(SFCS_Link, SFCS_Path, Xampp_progressBar, textBox_ExtractFile);
        }

        private void go_Button_Click(object sender, EventArgs e)
        {
            extractFile.RunWorkerAsync();
        }

        private void ExtractFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Set the maximum vaue to int.MaxValue because the process is completed
            Xampp_progressBar.Value = int.MaxValue;
            textBox_ExtractFile.Text = "BİTTİ.";
            textBox_ExtractFile.BackColor = Color.Green;
            Run_BackSetup();
        }

        private void Run_BackSetup()
        {
            try
            {
                ProcessStartInfo procInfo = new ProcessStartInfo();
                procInfo.UseShellExecute = true;
                for(int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        procInfo.FileName = "setup_xampp.bat";  //The file in that DIR.
                        procInfo.WorkingDirectory = @"C:\xampp\"; //The working DIR.
                    }
                    if (i == 1)
                    {
                        procInfo.FileName = "apache_installservice.bat";  //The file in that DIR.
                        procInfo.WorkingDirectory = @"C:\xampp\apache\"; //The working DIR.
                    }
                    if (i == 2)
                    {
                        procInfo.FileName = "mysql_installservice.bat";  //The file in that DIR.
                        procInfo.WorkingDirectory = @"C:\xampp\mysql\"; //The working DIR.
                    }
                    //if (i == 3)
                    //{
                    //    procInfo.FileName = "apache_start.bat";  //The file in that DIR.
                    //    procInfo.WorkingDirectory = @"C:\xampp\"; //The working DIR.
                    //}
                    //if (i == 4)
                    //{
                    //    procInfo.FileName = "mysql_start.bat";  //The file in that DIR.
                    //    procInfo.WorkingDirectory = @"C:\xampp\"; //The working DIR.
                    //}
                    procInfo.Verb = "runas";
                    Process.Start(procInfo);  //Start that process.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExtractFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox_ExtractFile.Text = compressedFileName;

            //calculate the totalPercent
            long totalPercent = ((long)e.ProgressPercentage * compressedSize + extractedSizeTotal * int.MaxValue) / fileSize;
            if (totalPercent > int.MaxValue)
                totalPercent = int.MaxValue;
            Xampp_progressBar.Value = (int)totalPercent;
        }

        private void ExtractFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileName = "C:\\SFCS\\SFCS-CMS.zip";
                string extractPath = "c:\\";

                //get the size of the zip file
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
                fileSize = fileInfo.Length;
                using (Ionic.Zip.ZipFile zipFile = Ionic.Zip.ZipFile.Read(fileName))
                {
                    //reset the bytes total extracted to 0
                    extractedSizeTotal = 0;
                    int fileAmount = zipFile.Count;
                    int fileIndex = 0;
                    zipFile.ExtractProgress += Zip_ExtractProgress;
                    foreach (Ionic.Zip.ZipEntry ZipEntry in zipFile)
                    {
                        fileIndex++;
                        compressedFileName = "(" + fileIndex.ToString() + "/" + fileAmount + "): " + ZipEntry.FileName;
                        //get the size of a single compressed file
                        compressedSize = ZipEntry.CompressedSize;
                        ZipEntry.Extract(extractPath, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                        //calculate the bytes total extracted
                        extractedSizeTotal += compressedSize;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Zip_ExtractProgress(object sender, Ionic.Zip.ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                long percent = e.BytesTransferred * int.MaxValue / e.TotalBytesToTransfer;
                //Console.WriteLine("Indivual: " + percent);
                extractFile.ReportProgress((int)percent);
            }
        }
    }
}
