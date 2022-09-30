using AutoUpdaterDotNET;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace Capital_Launcher
{
    public partial class Selector : Form
    {
        WebClient webClient = new WebClient();
        public Selector()
        {
            InitializeComponent();
            AutoUpdater.Start("https://pastebin.com/raw/0vm82kxe");
            verLbl.Text = "v." + Application.ProductVersion;


            string bankFile = Directory.GetCurrentDirectory() + "/Bank/Capital Bank.exe";
            if (File.Exists(bankFile))
            {
                label2.Text = "Установлен";
                label2.ForeColor = Color.Green;
                bankStart.Visible = true;
            }
            else
            {
                label2.Text = "Не установлен";
                label2.ForeColor = Color.Red;
                bankBtn.Visible = true;
                bankStart.Visible = false;
            }
                ;
        }

        private void bankBtn_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Bank");
            webClient.DownloadFile("https://github.com/Brian-Galaxy/Capital-Bank/files/9680839/upd.zip", "upd.zip");
            File.Move(Directory.GetCurrentDirectory() + "/upd.zip", Directory.GetCurrentDirectory() + "/Bank/upd.zip");
            ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "/Bank/upd.zip", Directory.GetCurrentDirectory() + "/Bank");

            string bankFile = Directory.GetCurrentDirectory() + "/Bank/Capital Bank.exe";
            if (File.Exists(bankFile))
            {
                Application.Restart();
            }
            else
            {
                label2.Text = "Ошибка установки";
                label2.ForeColor = Color.Red;
            }
                ;


        }

        private void bankStart_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + "/Bank/Capital Bank.exe");
            Application.Exit();
        }
    }
}
