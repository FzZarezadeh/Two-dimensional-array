using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
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

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtn1.TextLength > 0 && txtn2.TextLength > 0)
            {
                int n1 = int.Parse(txtn1.Text), n2 = int.Parse(txtn2.Text);
                int[,] table = new int[n1, n2];
                dataGridView1.RowCount = n1;
                dataGridView1.ColumnCount = n2;

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        table[i, j] = (j + 1) * (i + 1);
                    }
                }

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = table[i, j];
                    }
                }
            }
            else
                MessageBox.Show("Please fill out the textbox", "Empty textbox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
