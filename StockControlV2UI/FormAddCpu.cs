using StockControlV2BL;
using StockControlV2EL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlV2UI
{
    public partial class FormAddCpu : Form
    {
        private readonly CPUManager _cpuManager;
        public FormAddCpu(StockControlV2DL.ApplicationDbContext _context)
        {
            InitializeComponent();
            _cpuManager = new CPUManager(_context);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // CoreCount ve ClockSpeed için geçerli değerler kontrol et
            if (!int.TryParse(textBox1.Text, out int coreCount))
            {
                MessageBox.Show("Geçersiz 'CoreCount' Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal clockSpeed))
            {
                MessageBox.Show("Geçersiz 'ClockSpeed' Giriş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CPU newCPU = new CPU
            {
                CoreCount = coreCount,
                ClockSpeed = clockSpeed,
                BrandType = textBox3.Text,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            _cpuManager.Add(newCPU);
            MessageBox.Show("CPU başarıyla eklendi!");
            this.Close(); // Formu kapat
        }

        #region farkli
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAddCpu_Load(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
