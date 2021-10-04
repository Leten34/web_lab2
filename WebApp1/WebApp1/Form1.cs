using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApp1
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        private int timerInterval = 10000;

        private List<String> URLs = new List<string>() { "www.google.com", "www.yandex.ru", "www.wikipedia.org"};

        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            timer1.Interval = timerInterval;
            timer1.Start();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URLs[counter]);
            counter = ++counter % URLs.Count;
        }
    }
}
