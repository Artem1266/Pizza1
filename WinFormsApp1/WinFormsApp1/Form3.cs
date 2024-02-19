using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ принят. Едьте в пиццерию и заберите заказ, после нажмите на кнопку забрал заказ. Адрес: ул.Малахова д.16");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что забрали заказ?Если да то следующий адрес: ул.Сухэ-Батора д.10 кв.5");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ доставлен.");
        }
    }
}
