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
    public partial class FormUpdateGpu : Form
    {
        private readonly GPUManager _gpuManager;
        private GPU _gpuToUpdate;
        private void LoadGpu(int gpuId)
        {
            _gpuToUpdate = _gpuManager.GetByID(gpuId);
            if (_gpuToUpdate != null)
            {
                textBox1.Text = _gpuToUpdate.Memory.ToString();
                textBox2.Text = _gpuToUpdate.CoreClock.ToString();
                textBox3.Text = _gpuToUpdate.BrandType;
            }
            else
            {
                MessageBox.Show("GPU bulunamadı!");
                this.Close();
            }
        }
        public FormUpdateGpu(StockControlV2DL.ApplicationDbContext _context, int gpuId)
        {
            InitializeComponent();
            _gpuManager = new GPUManager(_context);
            LoadGpu(gpuId);
        }

        private void FormUpdateGpu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_gpuToUpdate != null)
            {
                _gpuToUpdate.Memory = int.Parse(textBox1.Text);
                _gpuToUpdate.CoreClock = int.Parse(textBox2.Text);
                _gpuToUpdate.BrandType = textBox3.Text;
                _gpuManager.Update(_gpuToUpdate);
                MessageBox.Show("CPU başarıyla güncellendi!");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
