using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static WComplex;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue1;
            double imaginary1;
            double realvalue2;
            double imaginary2;
            double n;
            if (!double.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue1 = Convert.ToDouble(textBox1.Text.ToString());
            }
            if (!double.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary1 = Convert.ToDouble(textBox3.Text.ToString());
            }       
            WComplex complex = new WComplex(realvalue1, imaginary1);
            if (!double.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue2 = Convert.ToDouble(textBox2.Text.ToString());
            }
            if (!double.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary2 = Convert.ToDouble(textBox4.Text.ToString());
            }
            WComplex complexx = new WComplex(realvalue2, imaginary2);
            WComplex result = complexx + complex;


            textBox5.Text = Convert.ToString(result.real);
            textBox6.Text = Convert.ToString(result.imaginary);

            textBox1.Text = Convert.ToString(result.real);
            textBox3.Text = Convert.ToString(result.imaginary);

            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;

            if (checkedListBox1.SelectedIndex == 0)
            {
                this.chart1.Series["Число 1"].Points.AddXY("Действительная часть", realvalue1);
                this.chart1.Series["Число 2"].Points.AddXY("Действительная часть", realvalue2);
                this.chart1.Series["Результат"].Points.AddXY("Действительная часть", result.real);
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 1)
                {
                    this.chart1.Series["Число 1"].Points.AddXY("Мнимая часть", imaginary1);
                    this.chart1.Series["Число 2"].Points.AddXY("Мнимая часть", imaginary2);
                    this.chart1.Series["Результат"].Points.AddXY("Мнимая часть", result.imaginary);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue1;
            double imaginary1;
            double realvalue2;
            double imaginary2;
            double n;
            if (!double.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue1 = Convert.ToDouble(textBox1.Text.ToString());
            }
            if (!double.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary1 = Convert.ToDouble(textBox3.Text.ToString());
            }
            WComplex complex = new WComplex(realvalue1, imaginary1);
            if (!double.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue2 = Convert.ToDouble(textBox2.Text.ToString());
            }
            if (!double.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary2 = Convert.ToDouble(textBox4.Text.ToString());
            }
            WComplex complexx = new WComplex(realvalue2, imaginary2);
            WComplex result = complex - complexx;


            textBox5.Text = Convert.ToString(result.real);
            textBox6.Text = Convert.ToString(result.imaginary);

            textBox1.Text = Convert.ToString(result.real);
            textBox3.Text = Convert.ToString(result.imaginary);

            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;

            if (checkedListBox1.SelectedIndex == 0)
            {
                this.chart1.Series["Число 1"].Points.AddXY("Действительная часть", realvalue1);
                this.chart1.Series["Число 2"].Points.AddXY("Действительная часть", realvalue2);
                this.chart1.Series["Результат"].Points.AddXY("Действительная часть", result.real);
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 1)
                {
                    this.chart1.Series["Число 1"].Points.AddXY("Мнимая часть", imaginary1);
                    this.chart1.Series["Число 2"].Points.AddXY("Мнимая часть", imaginary2);
                    this.chart1.Series["Результат"].Points.AddXY("Мнимая часть", result.imaginary);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue1;
            double imaginary1;
            double realvalue2;
            double imaginary2;
            double n;
            if (!double.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue1 = Convert.ToDouble(textBox1.Text.ToString());
            }
            if (!double.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary1 = Convert.ToDouble(textBox3.Text.ToString());
            }
            WComplex complex = new WComplex(realvalue1, imaginary1);
            if (!double.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue2 = Convert.ToDouble(textBox2.Text.ToString());
            }
            if (!double.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary2 = Convert.ToDouble(textBox4.Text.ToString());
            }
            WComplex complexx = new WComplex(realvalue2, imaginary2);
            WComplex result = complex * complexx;


            textBox5.Text = Convert.ToString(result.real);
            textBox6.Text = Convert.ToString(result.imaginary);

            textBox1.Text = Convert.ToString(result.real);
            textBox3.Text = Convert.ToString(result.imaginary);

            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;

            if (checkedListBox1.SelectedIndex == 0)
            {
                this.chart1.Series["Число 1"].Points.AddXY("Действительная часть", realvalue1);
                this.chart1.Series["Число 2"].Points.AddXY("Действительная часть", realvalue2);
                this.chart1.Series["Результат"].Points.AddXY("Действительная часть", result.real);
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 1)
                {
                    this.chart1.Series["Число 1"].Points.AddXY("Мнимая часть", imaginary1);
                    this.chart1.Series["Число 2"].Points.AddXY("Мнимая часть", imaginary2);
                    this.chart1.Series["Результат"].Points.AddXY("Мнимая часть", result.imaginary);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue1;
            double imaginary1;
            double realvalue2;
            double imaginary2;
            double n;
            if (!double.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue1 = Convert.ToDouble(textBox1.Text.ToString());
            }
            if (!double.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary1 = Convert.ToDouble(textBox3.Text.ToString());
            }
            WComplex complex = new WComplex(realvalue1, imaginary1);
            if (!double.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue2 = Convert.ToDouble(textBox2.Text.ToString());
            }
            if (!double.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary2 = Convert.ToDouble(textBox4.Text.ToString());
            }
            WComplex complexx = new WComplex(realvalue2, imaginary2);
            WComplex result = complex / complexx;

            textBox5.Text = Convert.ToString(result.real);
            textBox6.Text = Convert.ToString(result.imaginary);

            textBox1.Text = Convert.ToString(result.real);
            textBox3.Text = Convert.ToString(result.imaginary);

            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;

            if (checkedListBox1.SelectedIndex == 0)
            {
                this.chart1.Series["Число 1"].Points.AddXY("Действительная часть", realvalue1);
                this.chart1.Series["Число 2"].Points.AddXY("Действительная часть", realvalue2);
                this.chart1.Series["Результат"].Points.AddXY("Действительная часть", result.real);
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 1)
                {
                    this.chart1.Series["Число 1"].Points.AddXY("Мнимая часть", imaginary1);
                    this.chart1.Series["Число 2"].Points.AddXY("Мнимая часть", imaginary2);
                    this.chart1.Series["Результат"].Points.AddXY("Мнимая часть", result.imaginary);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue;
            double imaginary;
            double n;
            if (!double.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue = Convert.ToDouble(textBox1.Text.ToString());
            }
            if (!double.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary = Convert.ToDouble(textBox3.Text.ToString());
            }
            double mod = Math.Sqrt(Math.Pow(realvalue, 2) + Math.Pow(imaginary, 2));
            textBox7.Text = Convert.ToString(mod);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Число 1"].Points.Clear();
            chart1.Series["Число 2"].Points.Clear();
            chart1.Series["Результат"].Points.Clear();
            double realvalue;
            double imaginary;
            double n;
            if (!double.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите действительную часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                realvalue = Convert.ToDouble(textBox2.Text.ToString());
            }
            if (!double.TryParse(textBox4.Text, out n))
            {
                MessageBox.Show("Введите мнимую часть числа 2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                imaginary = Convert.ToDouble(textBox3.Text.ToString());
            }
            double mod = Math.Sqrt(Math.Pow(realvalue, 2) + Math.Pow(imaginary, 2));
            textBox7.Text = Convert.ToString(mod);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Возможность ввода только цифр и клавиши BackSpace
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                //Выбор только одного элемента
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        checkedListBox1.SetItemChecked(i, false);
                    checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
                }
        }
    }
}
