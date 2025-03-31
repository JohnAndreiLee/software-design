namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }


        private void buttonSolve_Click_1(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxInput.Text);
            int result = RecursiveFactorial(number);
            labelResult.Text = $"Factorial: {result}";
        }

        private void lblCalculateSum_Click(object sender, EventArgs e)
        {

        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length -1);
            lblSumResult.Text = $"Sum: {result}";
        }
    }
}
