namespace task3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(txtBase.Text);
            int expNum = int.Parse(txtExponent.Text);
            int result = PowerCalculation(baseNum,expNum);
            lblResult.Text = $"Result: {result}";
        }

        public int PowerCalculation(int x, int n)
        {
            if (n == 0) return 1;
            return x * PowerCalculation(x, n - 1);
        }
    }
}
