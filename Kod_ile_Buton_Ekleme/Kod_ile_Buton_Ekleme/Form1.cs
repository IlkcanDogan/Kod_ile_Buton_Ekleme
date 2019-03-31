using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kod_ile_Buton_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 12;
        private void button1_Click(object sender, EventArgs e)
        {
            Button yeniButon = new Button();
            yeniButon.Top = 20; 
            yeniButon.Left = 50;
            yeniButon.Text = "Yeni Buton ";
            yeniButon.Height = 25;
            yeniButon.Width = 100;
            yeniButon.Location = new Point(12,x); //x ve y değerleri.
            
            this.Controls.Add(yeniButon);
            yeniButon.Click += new EventHandler(yeniButon_Click);
            x += 30;
            

        }
        private void yeniButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }
        
    }
}
