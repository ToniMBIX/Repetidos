using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repetidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcModa_Click(object sender, EventArgs e)
        {
            string[] list = txt_Moda.Text.Split(',');
            int[] numbers = Array.ConvertAll(list, int.Parse);

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary[number] = 1;
                }
            }

            int moda = dictionary.Values.Max();
            List<int> modas = new List<int>();
            foreach (KeyValuePair<int, int> par in dictionary)
            {
                if (par.Value == moda)
                {
                    modas.Add(par.Key);
                }
            }

            if (modas.Count == 1)
            {
                MessageBox.Show($"La moda es: {modas[0]}");
            }
            else if (modas.Count > 1)
            {
                string modasText = string.Join(", ", modas);
                MessageBox.Show($"Las modas son: {modasText}");
            }
            else
            {
                MessageBox.Show("No hay moda");
            }
        }
    }
}
