using System;
using System.Windows.Forms;

namespace курсовая_работаа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFunction = "";

            if (radioButton1.Checked) selectedFunction = "Линейная";
            else if (radioButton2.Checked) selectedFunction = "Квадратичная";
            else if (radioButton3.Checked) selectedFunction = "Кубическая";
            else if (radioButton4.Checked) selectedFunction = "Синусоида";
            else if (radioButton5.Checked) selectedFunction = "Косинусоида";
            else if (radioButton6.Checked) selectedFunction = "Тангенсоида";
            else if (radioButton7.Checked) selectedFunction = "Экспонента";
            else if (radioButton8.Checked) selectedFunction = "Логарифмическая";
            else if (radioButton9.Checked) selectedFunction = "Модуль";
            else if (radioButton10.Checked) selectedFunction = "Обратная пропорциональность";
            else
            {
                MessageBox.Show("Выберите математическую функцию!");
                return;
            }

            Form2 form2 = new Form2();
            form2.SelectedFunction = selectedFunction;
            form2.Show();
            this.Hide();
        }
    }
}