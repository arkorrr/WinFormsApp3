
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxExpenseName = new TextBox();
            fontDialog1 = new FontDialog();
            numericUpDownAmount = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            btnAddExpense = new Button();
            labelTotal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer1.Interval = 5000;
            labelTime = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 54);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва витрат:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Сума витрат:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Категорія:";
            label3.Click += label3_Click;
            // 
            // textBoxExpenseName
            // 
            textBoxExpenseName.Location = new Point(124, 51);
            textBoxExpenseName.Multiline = true;
            textBoxExpenseName.Name = "textBoxExpenseName";
            textBoxExpenseName.Size = new Size(120, 23);
            textBoxExpenseName.TabIndex = 3;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(124, 80);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 23);
            numericUpDownAmount.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Харчування", "Транспорт", "Розваги", "Покупки", "Інше" });
            comboBoxCategory.Location = new Point(124, 106);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(120, 23);
            comboBoxCategory.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(76, 135);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(122, 24);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "Додати витрати";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click_1;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(80, 171);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(51, 15);
            labelTotal.TabIndex = 7;
            labelTotal.Text = "Витрати";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(83, 202);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(38, 15);
            labelTime.TabIndex = 8;
            labelTime.Text = "label4";
            // 
            // Form1
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(labelTime);
            Controls.Add(labelTotal);
            Controls.Add(btnAddExpense);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownAmount);
            Controls.Add(textBoxExpenseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Калькулятор витрат";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxExpenseName;
        private FontDialog fontDialog1;
        private NumericUpDown numericUpDownAmount;
        private ComboBox comboBoxCategory;
        private Button btnAddExpense;
        private Label labelTotal;
        private System.Windows.Forms.Timer timer1;
        private Label labelTime;
        private System.Windows.Forms.Timer timer2;
    }
}
