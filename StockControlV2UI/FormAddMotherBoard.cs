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
    public partial class FormAddMotherBoard : Form
    {
        private readonly MotherBoardManager _motherBoardManager;
        public FormAddMotherBoard(StockControlV2DL.ApplicationDbContext _context)
        {
            InitializeComponent();
            _motherBoardManager = new MotherBoardManager(_context);
        }


        private void FormAddMotherBoard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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


            MotherBoard newMotherBoard = new MotherBoard
            {
                BrandType = textBox1.Text,
                CreatedDate = DateTime.Now,
                FormFactor = textBox2.Text,
                IsDeleted = false,
                Socket = textBox3.Text,
            };
            _motherBoardManager.Add(newMotherBoard);
            MessageBox.Show("MotherBoard başarıyla eklendi");
            this.Close(); // Formu kapat
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
