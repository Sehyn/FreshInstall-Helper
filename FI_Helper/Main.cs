using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FI_Helper
{
    public partial class Form1 : Form
    {
        private string DLStatus ="";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Fresh Install - [#] WAITING [#]";
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/Installer.txt"), "Installer.bat");
            DLStatus = "Waiting..";
        }

        private  void BtnDownload_Click(object sender, EventArgs e)
        {
            BtnDownload.Enabled = false;
            BtnDownload.Text = "Please wait..";
            BtnDownload.Visible = false;



            var client = new WebClient();

            if (ChkAIO.Checked == true)
            {
                this.DLStatus = "All In One Runtimes download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/AIO_INSTALLER.exe"), "AIO.exe");
            }
            if (ChkVS.Checked == true)
            {
                this.DLStatus = "Visual Studio download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/vs_Community_INSTALLER.exe"), "VS_Community.exe");
            }
            if (ChkLogitechGhub.Checked == true)
            {
                this.DLStatus = "Logitech G HUB download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/LGHUB_INSTALLER.exe"), "LogitechGHUB.exe");
            }
            if (ChkWinrar.Checked == true)
            {
                this.DLStatus = "WinRAR download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/WINRAR_INSTALLER.exe"), "WinRAR.exe");
            }
            if (ChkGForceExp.Checked == true)
            {
                this.DLStatus = "Geforce Experience download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/GFORCE_INSTALLER.exe"), "GeForceExperience.exe");
            }
            if (ChkRyzenMaster.Checked == true)
            {
                this.DLStatus = "AMD Ryzen Master download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/AMD-Ryzen-Master_INSTALLER.exe"), "Amd_Ryzen_Master.exe");
            }
            if (ChkSteam.Checked == true)
            {
                this.DLStatus = "Steam download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/STEAM_INSTALLER.exe"), "Steam.exe");
            }
            if (ChkOrigin.Checked == true)
            {
                this.DLStatus = "Origin download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/ORIGIN_INSTALLER.exe"), "Origin.exe");

            }
            if (ChkBattleNet.Checked == true)
            {
                this.DLStatus = "Battle Net download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/BATTLENET_INSTALLER.exe"), "BattleNet.exe");
            }
            if (ChkDiscord.Checked == true)
            {
                this.DLStatus = "Discord download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/DISCORD_INSTALLER.exe"), "DISCORD.exe");
            }
            if (ChkOperaGx.Checked == true)
            {
                this.DLStatus = "Opera GX download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/OperaGX_INSTALLER.exe"), "OperaGX.exe");
            }
            if (ChkShareX.Checked == true)
            {
                this.DLStatus = "ShareX download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/SHAREX_INSTALLER.exe"), "ShareX.exe");
            }
            if (ChkDefenderCtrl.Checked == true)
            {
                this.DLStatus = "Defender Control download completed.";

                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://dl.nextadvantage.xyz/Helper/DEFENDER_CONTROL.exe"), "Defender_Control.exe");
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            LblStatus.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
            BarDLProgress.Value = int.Parse(Math.Truncate(percentage).ToString());
           
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            
            int i = groupBox1.Controls.OfType<CheckBox>().Where(c => c.Checked).Count() + groupBox2.Controls.OfType<CheckBox>().Where(c => c.Checked).Count() + groupBox3.Controls.OfType<CheckBox>().Where(c => c.Checked).Count();
            if(i > 1)
            {
                LblStatus.Text = (i.ToString() + " files were succesfully downloaded.");

            }
            else
            {
                LblStatus.Text = DLStatus;

            }
        }


    }
}
