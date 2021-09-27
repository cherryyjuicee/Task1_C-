using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task1__.net_
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n;
            
            int.TryParse(textBox2.Text, out n);
            
            int[,] arr1 = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    arr1[i, j] = rnd.Next(-30, 30);
            }


            
            if (n <= 0)
            {
                MessageBox.Show("Введите количество строк и столбцов (>0)");
            }

            else
            {
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = n;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int x = -1;
                int y = -1;

                int n;
                
                int.TryParse(textBox2.Text, out n);
                int[,] arr1 = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr1[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());

                        if (arr1[i, j] < 0 && x == -1)
                        {
                            x = i; //номер строки первого отрицательного элемента
                        }
                        if (arr1[i, j] == 0)
                        {
                            y = j; //номер столбца последнего нулевого элемента
                        }
                    }
                }

                int scl = 0;

                if (x == -1 && y == -1)
                {
                    MessageBox.Show("В матрице нет отрицательных и нулевых элементов");
                }
                else if (x == -1)
                {
                    MessageBox.Show("В матрице нет отрицательных элементов");
                }
                else if (y == -1)
                {
                    MessageBox.Show("В матрице нет нулевых элементов");
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        scl = scl + arr1[x, i] * arr1[i, y];
                    }
                    MessageBox.Show("Номер строки с первым отрицательным элементом: " + (x+1) + "\nНомер столбца с последним нулевым элементом: " + (y+1) + "\nСкалярное произведение строки на столбец: " + scl);
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int.Parse(textBox2.Text = "4");


            int[,] arr1 = new int[4, 4]
            {
                {1, 2, 3, 4},
                {0, 5, 5, 0},
                {-1, 4, 5, 0},
                {-5, -8, 0, 5}
            };
                       
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox2.Text, out n);

            
            if (n <= 0)
            {
                MessageBox.Show("Введите количество строк и столбцов (>0)");
            }

            else
            {
                dataGridView1.RowCount = n;
                dataGridView1.ColumnCount = n;

            }

        }
    
    }
}
