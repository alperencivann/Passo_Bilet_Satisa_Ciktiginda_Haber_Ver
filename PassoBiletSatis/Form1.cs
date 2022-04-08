using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;

namespace PassoBiletSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string url;
        public string xpath;
        public string olumsuzMesaj;
        public int beklemeSuresi;
        public bool bulunduMu = false;
        public ChromeDriver driver;
        public string donen;
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        

        private void button1_Click(object sender, EventArgs e)
        {
            url = txbEtkinlikLink.Text.ToString();
            xpath = txbButonXPath.Text.ToString();
            olumsuzMesaj = txbOlumsuzMesaj.Text.ToString();
            try
            {
                beklemeSuresi = Convert.ToInt32(txbKacSaniyedeBir.Text.ToString());
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized --force-device-scale-factor=0.8 --disable-gpu");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                driver = new ChromeDriver(service, options);
                timer1.Interval = beklemeSuresi * 1000;
                timer1.Enabled = true;
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Tarama sırasındaki bekleme süresini saniye cinsinde yalnızca rakamlarla giriniz.");
                return;
            }
        }
        private void listBoxLog_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(5000);
                donen = driver.FindElement(By.XPath(xpath)).Text.ToString();
            }
            catch{ }
            if (donen == olumsuzMesaj)
            {
                listBoxLog.Items.Add("Bilet Satışta Değil. Butondaki Veri : " + donen + " || Kontrol Saati : " + DateTime.Now.ToString());
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            }
            else
            {
                music.URL = @"C:\\Users\\alper\\Desktop\\mars\\fenermarsi.mp3";
                music.controls.play();
                listBoxLog.Items.Add("BİLET SATIŞA ÇIKTI!! BUTONDAKİ VERİ : " + donen + " || KONTROL SAATİ : " + DateTime.Now.ToString());
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
                bulunduMu = true;
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
    }
}
