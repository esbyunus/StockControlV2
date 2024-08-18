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
    public partial class FormUpdateCpu : Form
    {
        private readonly CPUManager _cpuManager;
        private CPU _cpuToUpdate;
        private void LoadCpu(int cpuId)
        {
            _cpuToUpdate = _cpuManager.GetByID(cpuId);
            if (_cpuToUpdate != null)
            {
                textBox1.Text = _cpuToUpdate.CoreCount.ToString();
                textBox2.Text = _cpuToUpdate.ClockSpeed.ToString();
                textBox3.Text = _cpuToUpdate.BrandType;
            }
            else
            {
                MessageBox.Show("CPU bulunamadı!");
                this.Close();
            }
        }
        public FormUpdateCpu(StockControlV2DL.ApplicationDbContext _context, int cpuId)
        {
            InitializeComponent();
            _cpuManager = new CPUManager(_context);
            LoadCpu(cpuId);
        }

        #region farkli
        private void FormUpdateCpu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_cpuToUpdate != null)
            {
                _cpuToUpdate.CoreCount = int.Parse(textBox1.Text);
                _cpuToUpdate.ClockSpeed = decimal.Parse(textBox2.Text);
                _cpuToUpdate.BrandType = textBox3.Text;
                _cpuManager.Update(_cpuToUpdate);
                MessageBox.Show("CPU başarıyla güncellendi!");
                this.Close();
            }
        } 
        #endregion
    }
}
