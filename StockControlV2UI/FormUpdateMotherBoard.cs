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
    public partial class FormUpdateMotherBoard : Form
    {
        private readonly MotherBoardManager _motherBoardManager;
        private MotherBoard _motherBoardToUpdate;

        private void LoadMotherBoard(int cpuId)
        {
            _motherBoardToUpdate = _motherBoardManager.GetByID(cpuId);
            if (_motherBoardToUpdate != null)
            {
                textBox1.Text = _motherBoardToUpdate.BrandType;
                textBox2.Text = _motherBoardToUpdate.FormFactor;
                textBox3.Text = _motherBoardToUpdate.Socket;
            }
            else
            {
                MessageBox.Show("MotherBoard bulunamadı!");
                this.Close();
            }
        }
        public FormUpdateMotherBoard(StockControlV2DL.ApplicationDbContext _context, int motherBoardId)
        {
            InitializeComponent();
            _motherBoardManager = new MotherBoardManager(_context);
            LoadMotherBoard(motherBoardId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _motherBoardToUpdate.BrandType = textBox1.Text;
            _motherBoardToUpdate.FormFactor = textBox2.Text;
            _motherBoardToUpdate.Socket = textBox3.Text;
            MessageBox.Show("MotherBoard başarıyla güncellendi!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
