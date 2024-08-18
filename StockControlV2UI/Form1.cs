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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockControlV2UI
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly CPUManager _cpuManager;
        private readonly GPUManager _gpuManager;
        private readonly MotherBoardManager _motherboardManager;
        private readonly RamManager _ramManager;

        public Form1()
        {
            InitializeComponent();
            //managerler olusturuldu
            _context = new ApplicationDbContext();
            _cpuManager = new CPUManager(_context);
            _gpuManager = new GPUManager(_context);
            _motherboardManager = new MotherBoardManager(_context);
            _ramManager = new RamManager(_context);

            //Combobox'a eklenildi
            comboBox1.Items.Add("CPU");
            comboBox1.Items.Add("GPU");
            comboBox1.Items.Add("MotherBoard");
            comboBox1.Items.Add("RAM");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Listele
        private void button1_Click(object sender, EventArgs e) //List All
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedItem != null)
            {
                string selectedEntity = comboBox1.SelectedItem.ToString();
                switch (selectedEntity)
                {
                    case "CPU":
                        List<CPU> cpus = _cpuManager.GetListAll();
                        foreach (var cpu in cpus)
                        {
                            listBox1.Items.Add($"ID: {cpu.Id}, CoreCount: {cpu.CoreCount}, ClockSpeed: {cpu.ClockSpeed}, BrandType: {cpu.BrandType}");
                        }
                        break;
                    case "GPU":
                        List<GPU> gpus = _gpuManager.GetListAll();
                        foreach (var gpu in gpus)
                        {
                            listBox1.Items.Add($"ID: {gpu.Id}, Memory: {gpu.Memory}, CoreClock: {gpu.CoreClock}, BrandType: {gpu.BrandType}");
                        }
                        break;
                    case "MotherBoard":
                        List<MotherBoard> motherboards = _motherboardManager.GetListAll();
                        foreach (var mb in motherboards)
                        {
                            listBox1.Items.Add($"ID: {mb.Id}, Socket: {mb.Socket}, FormFactor: {mb.FormFactor}, BrandType: {mb.BrandType}");
                        }
                        break;
                    case "RAM":
                        List<RAM> rams = _ramManager.GetListAll();
                        foreach (var ram in rams)
                        {
                            listBox1.Items.Add($"ID: {ram.Id}, Capacity: {ram.Capacity}, Speed: {ram.Speed}, BrandType: {ram.BrandType}");
                        }
                        break;
                }
            }
        }
        #endregion

        #region Ekle
        private void button2_Click(object sender, EventArgs e) //Add
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem != null)
                {
                    string selectedEntity = comboBox1.SelectedItem.ToString();
                    Form addForm = null;

                    // Seçilen öğeye göre uygun formu aç
                    switch (selectedEntity)
                    {
                        case "CPU":
                            addForm = new FormAddCpu(_context);
                            break;
                        case "GPU":
                            addForm = new FormAddGPU(_context);
                            break;
                        case "MotherBoard":
                            addForm = new FormAddMotherBoard(_context);
                            break;
                        case "RAM":
                            addForm = new FormAddRAM(_context);
                            break;
                    }
                    if (addForm != null)
                    {
                        addForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir bileşen seçin.");
                }

            }
        }
        #endregion

        #region Guncelle
        private void button3_Click(object sender, EventArgs e) //update
        {
            if (comboBox1.SelectedItem != null && int.TryParse(textBox1.Text, out int id))
            {
                string selectedEntity = comboBox1.SelectedItem.ToString();
                Form updateForm = null;

                switch (selectedEntity)
                {
                    case "CPU":
                        updateForm = new FormUpdateCpu(_context, id);
                        break;
                    case "GPU":
                        updateForm = new FormUpdateGpu(_context, id);
                        break;
                    case "MotherBoard":
                        updateForm = new FormUpdateMotherBoard(_context, id);
                        break;
                    case "RAM":
                        updateForm = new FormUpdateRam(_context, id); // FormUpdateRam oluşturulmalı
                        break;
                }

                if (updateForm != null)
                {
                    updateForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz.");
            }
        }
        #endregion

        #region Sil
        private void buttonDelete_Click_Click(object sender, EventArgs e) //delete
        {

            if (comboBox1.SelectedItem != null && int.TryParse(textBox1.Text, out int id))
            {
                string selectedEntity = comboBox1.SelectedItem.ToString();
                switch (selectedEntity)
                {
                    case "CPU":
                        CPU cpu = _cpuManager.GetByID(id);
                        if (cpu != null)
                        {
                            _cpuManager.Delete(cpu);
                            MessageBox.Show("CPU başarıyla silindi!");
                            listBox1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("CPU bulunamadı!");
                        }
                        break;

                    case "GPU":
                        GPU gpu = _gpuManager.GetByID(id);
                        if (gpu != null)
                        {
                            _gpuManager.Delete(gpu);
                            MessageBox.Show("GPU başarıyla silindi!");
                            listBox1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("GPU bulunamadı!");
                        }
                        break;

                    case "MotherBoard":
                        MotherBoard motherboard = _motherboardManager.GetByID(id);
                        if (motherboard != null)
                        {
                            _motherboardManager.Delete(motherboard);
                            MessageBox.Show("MotherBoard başarıyla silindi!");
                            listBox1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("MotherBoard bulunamadı!");
                        }
                        break;

                    case "RAM":
                        RAM ram = _ramManager.GetByID(id);
                        if (ram != null)
                        {
                            _ramManager.Delete(ram);
                            MessageBox.Show("RAM başarıyla silindi!");
                            listBox1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("RAM bulunamadı!");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Lütfen ID giriniz");
            }
            textBox1.Clear();

        }
        #endregion

        #region Idye gore getir
        private void button5_Click(object sender, EventArgs e) //idye gore getir
        {
            if (comboBox1.SelectedItem != null && int.TryParse(textBox1.Text, out int id))
            {
                listBox1.Items.Clear();
                string selectedEntity = comboBox1.SelectedItem.ToString();
                switch (selectedEntity)
                {
                    case "CPU":
                        CPU cpu = _cpuManager.GetByID(id);
                        if (cpu != null)
                        {
                            listBox1.Items.Add($"ID: {cpu.Id}, CoreCount: {cpu.CoreCount}, ClockSpeed: {cpu.ClockSpeed}, BrandType: {cpu.BrandType}");
                        }
                        else
                        {
                            MessageBox.Show("CPU bulunamadı!");
                        }
                        break;

                    case "GPU":
                        GPU gpu = _gpuManager.GetByID(id);
                        if (gpu != null)
                        {
                            listBox1.Items.Add($"ID: {gpu.Id}, Memory: {gpu.Memory}, CoreClock: {gpu.CoreClock}, BrandType: {gpu.BrandType}");
                        }
                        else
                        {
                            MessageBox.Show("GPU bulunamadı!");
                        }
                        break;

                    case "MotherBoard":
                        MotherBoard motherboard = _motherboardManager.GetByID(id);
                        if (motherboard != null)
                        {
                            listBox1.Items.Add($"ID: {motherboard.Id}, Socket: {motherboard.Socket}, FormFactor: {motherboard.FormFactor}, BrandType: {motherboard.BrandType}");
                        }
                        else
                        {
                            MessageBox.Show("MotherBoard bulunamadı!");
                        }
                        break;

                    case "RAM":
                        RAM ram = _ramManager.GetByID(id);
                        if (ram != null)
                        {
                            listBox1.Items.Add($"ID: {ram.Id}, Capacity: {ram.Capacity}, Speed: {ram.Speed}, BrandType: {ram.BrandType}");
                        }
                        else
                        {
                            MessageBox.Show("RAM bulunamadı!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen ID giriniz");
            }
        }
        #endregion

        #region farkli
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}