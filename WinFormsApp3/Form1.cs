using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = $"Час: {DateTime.Now:HH:mm:ss}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddExpense_Click_1(object sender, EventArgs e)
        {
            
            decimal totalExpenses = 0;
            if (string.IsNullOrWhiteSpace(textBoxExpenseName.Text) || comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("No cost category has been selected or the cost field is empty.", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show($"Витрати додано. Назва витрат : {textBoxExpenseName.Text}, Сума: {numericUpDownAmount.Value} грн, Категорія: {comboBoxCategory.SelectedItem}");
                totalExpenses += numericUpDownAmount.Value;
                labelTotal.Text = $"Загальна сума витрат: {totalExpenses} грн";
            }
        }
    }
}
