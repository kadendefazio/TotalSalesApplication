using System;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TotalSalesApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 7;
                int index = 0;
                decimal total = 0m;
                var sales = new decimal[SIZE];

                StreamReader inputFile = File.OpenText("Sales.txt");
                while (!inputFile.EndOfStream && index < sales.Length)
                {
                    sales[index] = decimal.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                foreach (decimal value in sales)
                {
                    salesListBox.Items.Add(value.ToString("c"));
                }

                // Calculate total
                foreach (decimal value in sales)
                {
                    total += value;
                }
                label2.Text = total.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
