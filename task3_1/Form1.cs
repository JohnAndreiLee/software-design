namespace fibonacci_sequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int result = FibonacciSequence(input);
            lblResult.Text = $"Result: {result}";
        }

        public int FibonacciSequence(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;

            return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
        }
    }
}
