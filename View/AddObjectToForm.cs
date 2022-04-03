using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class AddObjectToForm : Form
    {
        public AddObjectToForm()
        {
            InitializeComponent();

            #if !DEBUG
                buttonCRD.Visible = false;
            #endif
        }


        /// <summary>
        /// Нажатие на кнопку для генерации псевдослучайных значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCRD_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            textBoxParam1.Text = Math.Round(rnd.NextDouble() * 2500 + 1, 1).ToString();            
            textBoxParam2.Text = Math.Round(rnd.NextDouble() * 25 + 1, 0).ToString();
        }


        /// <summary>
        /// Добавить объект в список объектов с отображением в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            if (!Double.TryParse(textBoxParam1.Text, out double bufS))
            {
                MessageBox.Show("(S) Невозможно преобразовать строку в действительное число.",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Double.TryParse(textBoxParam2.Text, out double bufI))
            {
                MessageBox.Show("(I) Невозможно преобразовать строку в действительное число.",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
            {
                try
                {
                    Percentage obj = new Percentage
                    {
                        S = bufS,
                        I = bufI
                    };
                
                    mainForm.lst.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), obj.S.ToString(), obj.I.ToString());
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение\nДолжно быть: S > 0, I > 0.", 
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {               
                    Certificate obj = new Certificate
                    {
                        S = bufS,
                        I = bufI
                    };

                    mainForm.lst.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), obj.S.ToString(), obj.I.ToString());
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение\nДолжно быть: S > 0, I > 0.",
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            Close();
        }


        /// <summary>
        /// Закрытие формы добавления объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
