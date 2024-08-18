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
    public partial class FormAddRAM : Form
    {
        private readonly RamManager _ramManager;
        public FormAddRAM(StockControlV2DL.ApplicationDbContext _context)
        {
            InitializeComponent();
            _ramManager = new RamManager(_context);
        }

        private void FormAddRAM_Load(object sender, EventArgs e)
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

            if (!int.TryParse(textBox2.Text, out int speed))
            {
                MessageBox.Show("Geçersiz 'Speed' Giriş!", "Hata!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!int.TryParse(textBox3.Text, out int capacity))
            {
                MessageBox.Show("Geçersiz 'Capacity' Giriş!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            RAM newRAM = new RAM
            {
                BrandType = textBox1.Text,
                Speed = speed,
                IsDeleted = false,
                Capacity = capacity,
                CreatedDate = DateTime.Now
            };
            _ramManager.Add(newRAM);
            MessageBox.Show("RAM başarıyla eklendi!");
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
