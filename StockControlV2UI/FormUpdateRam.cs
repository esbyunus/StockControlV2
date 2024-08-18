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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockControlV2UI
{
    public partial class FormUpdateRam : Form
    {
        private readonly RamManager _ramManager;
        private RAM _ramToUpdate;

        private void LoadRam(int ramId)
        {
            _ramToUpdate = _ramManager.GetByID(ramId);
            if (_ramToUpdate != null)
            {
                textBox1.Text = _ramToUpdate.BrandType;
                textBox2.Text = _ramToUpdate.Speed.ToString();
                textBox3.Text = _ramToUpdate.Capacity.ToString();

            }
            else
            {
                MessageBox.Show("Ram bulunamadı!");
                this.Close();
            }
        }
        public FormUpdateRam(StockControlV2DL.ApplicationDbContext _context, int ramId)
        {
            InitializeComponent();
            _ramManager = new RamManager(_context);
            LoadRam(ramId);
        }

        private void FormUpdateRam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ramToUpdate != null)
            {
                _ramToUpdate.BrandType = textBox1.Text;
                _ramToUpdate.Speed = int.Parse(textBox2.Text);
                _ramToUpdate.Capacity = int.Parse(textBox3.Text);

                _ramManager.Update(_ramToUpdate);
                MessageBox.Show("Ram başarıyla güncellendi!");
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
