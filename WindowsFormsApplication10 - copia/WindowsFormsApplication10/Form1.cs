using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        Random aleatorio = new Random();
        int[] vector = new int[50];
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListaAleatorio.Items.Clear();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(100);
                ListaAleatorio.Items.Add(vector[i]);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ejercicio2.Items.Clear();
            int menor = (0);
            int mayor = (0);
            for (int i = 0; i < vector[i]; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
                else if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }

            }
            Ejercicio2.Items.Add("El mayor es:" + mayor);
            Ejercicio2.Items.Add("El menor es:" + menor);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ejercicio3.Items.Clear();
            Ejercicio3.Items.Add("Contenido 20: " + vector[20]);
            Ejercicio3.Items.Add("Contenido 30: " + vector[30]);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Ejercicio4.Items.Clear();
            int media = 0;
            int media0 = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                media0 = media0 + vector[i];
                media = media0 / 50;
            }
            Ejercicio4.Items.Add("La media es de: " + media);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            Ejercicio5.Items.Clear();
            int n=0;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    if(vector[j] < vector[i])
                    {
                        n = vector[i];
                        vector[i] = vector[j];
                        vector[j] = n;
                    }
                }
            }
                    for(int k = 0; k < vector.Length; k++)
                    {
                Ejercicio5.Items.Add(vector[k]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ejercicio6.Items.Clear();
            int contador=0;
            int valor = Convert.ToInt16(textBox1.Text);
            for (int i=0; i<vector.Length;i++)
            {
                if(vector[i] == valor)
                {
                    contador++;
                }
            }
            
            try
            {
                int num = Convert.ToInt16(textBox1.Text);
}
            catch (Exception ex)

            {

                MessageBox.Show("valor incorrecto " + textBox1.Text);

            }
            Ejercicio6.Items.Add("Mi número: "+valor);
            Ejercicio6.Items.Add("Aparece: " +contador);


        }

    }
}
   
