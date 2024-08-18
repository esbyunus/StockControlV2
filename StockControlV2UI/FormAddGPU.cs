using StockControlV2BL;
using StockControlV2DL;
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
    public partial class FormAddGPU : Form
    {
        private readonly GPUManager _gpuManager;
        public FormAddGPU(StockControlV2DL.ApplicationDbContext _context)
        {
            InitializeComponent();
            _gpuManager = new GPUManager(_context);
        }

        private void FormAddGPU_Load(object sender, EventArgs e)
        {

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
            
            if (!int.TryParse(textBox1.Text, out int memory))
            {
                MessageBox.Show("Geçersiz 'Memory' Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out int coreClock))
            {
                MessageBox.Show("Geçersiz 'CoreClock' Giriş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GPU newGPU = new GPU
            {
                BrandType = textBox3.Text,
                CoreClock = coreClock,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Memory = memory,
            };
            _gpuManager.Add(newGPU);
            MessageBox.Show("GPU başarıyla eklendi!");
            this.Close(); // Formu kapat
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
