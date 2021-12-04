using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSetDevs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Anasayfa form_anasayfa = new Anasayfa();
            form_anasayfa.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKayıtcs formKayıtcs = new FormKayıtcs();
            formKayıtcs.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
