using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Frm_inicial : Form
    {
       
        public Frm_inicial()
        {
            InitializeComponent();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            int numero = 0 , c = 1;
            listBox1.Items.Clear();
            numero = Convert.ToInt32(Txt_numero.Text);
            String op = Combox.Text;
            if (op == "Perfectos")
            {
                for (int i = 0; i < numero; c++)
                {
                    if (nPerfecto(c))
                    {
                        listBox1.Items.Add(c);
                        i++;
                    }
                }
            }
            if (op == "Primos")
            {
                for (int i = 0 ; i < numero; c++)
                {
                    if (nPrimo(c))
                    {
                        listBox1.Items.Add(c);
                        i++;
                    }
                }
            }

            int a = 1, b = 0;
            if (op == "Fibonacci")
            {
                for (int i = 0; i < numero; i++)
                {
                    c = a + b;
                    listBox1.Items.Add(c);
                    a = b; 
                    b = c;
                }
            }

        }

        private bool nPerfecto(int x)
        {
            int c = 0;
            for(int i = 1; i < x; i++)
            {
                if(x%i == 0)
                {
                    c += i;
                }
            }
            if (c == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool nPrimo(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
