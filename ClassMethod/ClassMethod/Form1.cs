using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMethod
{
    public partial class Form1 : Form
    {
        MyClass myClass;
        public Form1()
        {
            InitializeComponent();
            myClass = new MyClass();
            dGview.AllowUserToAddRows = false;
            dGview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dGview.RowHeadersVisible = false;
            tbNot.Minimum = 0;
            tbNot.Maximum = 100;
            tbDagilim.Minimum = 0;
            tbDagilim.Maximum = 20;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }
        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                var yol = openFileDialog1.FileName;
                dGview.DataSource = myClass.OgrenciOku(yol);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Veri seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbNot_Scroll(object sender, EventArgs e)
        {
            txtCC.Text = tbNot.Value.ToString();
        }

        private void tbDagilim_Scroll(object sender, EventArgs e)
        {
            txtDagGoster.Text = tbDagilim.Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dGview.DataSource!=null)
            {
                dGview.DataSource = null;
                dGview.DataSource = myClass.guncelle(tbNot.Value, tbDagilim.Value);
            }
            else
            {
                MessageBox.Show("Öğrencileri yüklemediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
