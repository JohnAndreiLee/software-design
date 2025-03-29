using System.ComponentModel;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class BubbleSortForm : Form
    {
        Random rnd = new Random();
        int noOfValues;
        BindingList<int> values = new BindingList<int>();

        private void BubbleSortForm_Load(object sender, EventArgs e)
        {
            noOfValues = 10;
            textBoxValues.Text = noOfValues.ToString();
            listBox.DataSource = values;
            GenerateValues(noOfValues);
        }

        public BubbleSortForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxValues.Text, out noOfValues) && noOfValues > 0)
            {
                values.Clear();
                GenerateValues(noOfValues);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number");
            }
        }

        private void GenerateValues(int no)
        {
            for (int i = 0; i < no; i++)
            {
                values.Add(rnd.Next(1, 100));
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void BubbleSort()
        {
            int t;
            for (int j = 0; j <= values.Count - 2; j++) 
            {
                for (int i = 0; i <= values.Count - 2; i++) 
                {
                    if (values[i] > values[i + 1]) 
                    {
                        t = values[i + 1]; 
                        values[i + 1] = values[i];
                        values[i] = t;
                    }
                }
            }

        }

    }
}
