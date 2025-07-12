namespace СalculatorSimple
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            selectAction.Items.AddRange(new string[] { "*", "/", "+", "-", "%" });
            selectAction.SelectedIndex = 0;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            if (!double.TryParse(txtFirstNumber.Text, out num1) || (!double.TryParse(txtSecondNumber.Text, out num2)))
            {
                labelResult.Text = "Ошибка! Введите число";
            }

            string? operation = selectAction.SelectedItem.ToString();
            double result = 0;

            switch (operation)
            {
                case "*": result = num1 * num2; break;
                case "/":
                    if (num2 == 0 || num1 == 0)
                    {
                        labelResult.Text = "Ошибка! Деление на ноль!";
                        return;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "%": result = num1 * (num2 / 100); break;
            }
            labelResult.Text = $"Результат: {result}";
        }
    }
}
