namespace StockControlV2UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            buttonListAll_Click = new Button();
            buttonAdd_Click = new Button();
            buttonUpdate_Click = new Button();
            buttonDelete_Click = new Button();
            buttonGetById = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(402, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(402, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonListAll_Click
            // 
            buttonListAll_Click.Location = new Point(235, 55);
            buttonListAll_Click.Name = "buttonListAll_Click";
            buttonListAll_Click.Size = new Size(94, 29);
            buttonListAll_Click.TabIndex = 2;
            buttonListAll_Click.Text = "ListAll";
            buttonListAll_Click.UseVisualStyleBackColor = true;
            buttonListAll_Click.Click += button1_Click;
            // 
            // buttonAdd_Click
            // 
            buttonAdd_Click.Location = new Point(235, 90);
            buttonAdd_Click.Name = "buttonAdd_Click";
            buttonAdd_Click.Size = new Size(94, 29);
            buttonAdd_Click.TabIndex = 3;
            buttonAdd_Click.Text = "Add";
            buttonAdd_Click.UseVisualStyleBackColor = true;
            buttonAdd_Click.Click += button2_Click;
            // 
            // buttonUpdate_Click
            // 
            buttonUpdate_Click.Location = new Point(235, 125);
            buttonUpdate_Click.Name = "buttonUpdate_Click";
            buttonUpdate_Click.Size = new Size(94, 29);
            buttonUpdate_Click.TabIndex = 4;
            buttonUpdate_Click.Text = "Update";
            buttonUpdate_Click.UseVisualStyleBackColor = true;
            buttonUpdate_Click.Click += button3_Click;
            // 
            // buttonDelete_Click
            // 
            buttonDelete_Click.Location = new Point(235, 160);
            buttonDelete_Click.Name = "buttonDelete_Click";
            buttonDelete_Click.Size = new Size(94, 29);
            buttonDelete_Click.TabIndex = 5;
            buttonDelete_Click.Text = "Delete";
            buttonDelete_Click.UseVisualStyleBackColor = true;
            buttonDelete_Click.Click += buttonDelete_Click_Click;
            // 
            // buttonGetById
            // 
            buttonGetById.Location = new Point(235, 195);
            buttonGetById.Name = "buttonGetById";
            buttonGetById.Size = new Size(94, 29);
            buttonGetById.TabIndex = 6;
            buttonGetById.Text = "GetByID";
            buttonGetById.UseVisualStyleBackColor = true;
            buttonGetById.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(402, 160);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 384);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 99);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Category";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 667);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonGetById);
            Controls.Add(buttonDelete_Click);
            Controls.Add(buttonUpdate_Click);
            Controls.Add(buttonAdd_Click);
            Controls.Add(buttonListAll_Click);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button buttonListAll_Click;
        private Button buttonAdd_Click;
        private Button buttonUpdate_Click;
        private Button buttonDelete_Click;
        private Button buttonGetById;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}