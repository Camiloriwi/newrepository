using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable___sabado
{
    public partial class Form1 : Form
    {
        string nombre1 = "";
        int peso = 0;

        string nombre2 = "";
        int CC = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = "";
            nombre = (textBox2.Text);

            if (nombre == "" && comboBox1.Text =="otro") 
            {
                tabControl1.Visible = false;
                MessageBox.Show("lo sentimos no tienes permiso para aceder a este contenido");

           
            }
            else if(nombre !="" &&  comboBox1.Text !="otro")
            {
                MessageBox.Show("BIenvenido:  " + nombre + "   estas en la seccion de:   " + comboBox1.Text);
                tabControl1.Visible = true;
            }
            groupBox1.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Random num = new Random();
            int num1 =num.Next(100);
            int num2 = num.Next(100);
            int num3 = num.Next(100);
            int mayor=0;
            int menor=0;
            int suma = 0;

            label3.Text = num1.ToString();
            label6.Text = num2.ToString();
            label7.Text = num3.ToString();

            if (num1 > num2 && num1 > num3)
            {
                label10.Text = num1.ToString();
                mayor = num1;
            }else if(num2 > num3 && num2 >num3 )
            {
                mayor = num2;
                label10.Text = num2.ToString();
            }else if (num3 > num1 && num3 > num2)
            {
                mayor = num3;
                label10.Text = num3.ToString();
            }
            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
                label11.Text = num1.ToString();
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
                label11.Text = num2.ToString();
            }
            else if(num3 < num1 && num3 < num2)
            {
                menor = num3;
                label11.Text = num3.ToString();
            }
            else
            {
                MessageBox.Show("los tres numeros son iguales");
            }
            suma = mayor + menor;
            label12.Text = suma.ToString();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            peso = int.Parse(textBox3.Text);
            nombre1= textBox1.Text;

            if (nombre1 != "" && peso > 0)
            {
                groupBox4.Visible = true;
            }
            if (comboBox2.Text != "otra")
            {
                groupBox2.Visible = true;

            }
            else 
            {   
                groupBox2.Visible = false;
                MessageBox.Show("la opcion que elegiste no esta disponible por ahora intenta nuevamente con una opcion diferente");
            }
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double calorias = 0;
            double time2=0;
            

            int time = int.Parse(textBox4.Text);

            if (comboBox2.Text=="dormir")
            {
                if (time > 25)
                {
                    calorias = time * 1.08;
                    groupBox3.Visible = true;
                    label26.Text = nombre1;
                    label27.Text = peso.ToString() + " KG";
                    label25.Text = comboBox2.Text;
                    label24.Text = time.ToString() + " minutos";
                    label23.Text = calorias.ToString() + " calorias";

                }
                else
                {
                    
                    time2 = time * 60;
                    calorias = time2 * 1.08;
                    groupBox3.Visible = true;
                    label26.Text = nombre1;
                    label27.Text = peso.ToString()+ " KG";
                    label25.Text = comboBox2.Text;
                    label24.Text = time2.ToString() + " minutos";
                    label23.Text = calorias.ToString()+ " calorias";
                }

            }
            if (comboBox2.Text == "sentado en reposo")
            {

                if (time > 25)
                {
                    calorias = time * 1.66;
                    groupBox3.Visible = true;
                    label26.Text = nombre1;
                    label27.Text = peso.ToString() + " KG";
                    label25.Text = comboBox2.Text;
                    label24.Text = time.ToString() + " minutos";
                    label23.Text = calorias.ToString() + " calorias";

                }
                else
                {

                    time2 = time * 60;
                    calorias = time2 * 1.66;
                    groupBox3.Visible = true;
                    label26.Text = nombre1;
                    label27.Text = peso.ToString() + " KG";
                    label25.Text = comboBox2.Text;
                    label24.Text = time2.ToString() + " minutos";
                    label23.Text = calorias.ToString() + " calorias";
                }


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            float result1=0;
            float result2=0;
            float result3 = 0;

            num1 = int.Parse(textBox5.Text);
            num2 = int.Parse(textBox6.Text);

            result = num1 * num2;
            label37.Text = result.ToString();
            result3 = num1 - num2;
            label36.Text = result3.ToString();
            result = num1 + num2;
            label35.Text = result.ToString();
            result1 = num1 / num2;
            label38.Text = result1.ToString();
            if (num1 % num2 != 0)
            {
                result2 = num1 % num2;
                label40.Text = result2.ToString();
                
            }

            if (num1 == num2)
            {
                result = num1 * num2;
                label42.Text =result.ToString();
                label41.Text = "Multiplicacion";
                groupBox6.Visible = true;

            }else if(num1 > num2)
            {
                result = num1 - num2;
                label42.Text = result.ToString();
                label41.Text = "Resta";
                groupBox6.Visible = true;
            }
            else
            {
                result = num1 + num2;
                label42.Text = result.ToString();
                label41.Text = "Suma";
                groupBox6.Visible = true;

            }

            groupBox5.Visible = true;



        }

        private void button6_Click(object sender, EventArgs e)
        {
             nombre2 = "";
             CC = 0;

            nombre2=textBox8.Text;
            CC = int.Parse(textBox9.Text);

            if (nombre2!=""  && CC != 0)
            {
                groupBox8.Visible = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            double price = 0;
            int cod = 0;
            string desc2 = "";
            double desc = 0;
            double total = 0;
            price = double.Parse(textBox7.Text);

            if (price != 0)
            {

                Random num = new Random();
                int num1 = num.Next(1,5);

                if (num1==1)
                {
                    label60.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                    label50.Text =cod.ToString()+1;
                    label51.Text = nombre2;
                    label52.Text = CC.ToString();
                    label53.Text = price.ToString();
                    desc2 = "25%";
                    label56.Text = desc2;
                    desc = price * 0.25;
                    total = price - desc;
                    label57.Text = total.ToString();


                }
                 else if (num1 == 2)
                {
                    label60.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                    label50.Text = cod.ToString() + 1;
                    label51.Text = nombre2;
                    label52.Text = CC.ToString();
                    label53.Text = price.ToString();
                    desc2 = "100%";
                    label56.Text = desc2;
                    desc = price * 1;
                    total = price - desc;
                    label57.Text = total.ToString();
                }
                 else if (num1 == 3)
                {
                    label60.Visible = true;
                    pictureBox3.Visible = true;
                 
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;

                    label50.Text = cod.ToString() + 1;
                    label51.Text = nombre2;
                    label52.Text = CC.ToString();
                    label53.Text = price.ToString();
                    desc2 = "10%";
                    label56.Text = desc2;
                    desc = price * 0.10;
                    total = price - desc;
                    label57.Text = total.ToString();
                }
                else if (num1 == 4)
                {   
                    label60.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;

                    label50.Text = cod.ToString() + 1;
                    label51.Text = nombre2;
                    label52.Text = CC.ToString();
                    label53.Text = price.ToString();
                    desc2 = "50%";
                    label56.Text = desc2;
                    desc = price * 0.50;
                    total = price - desc;
                    label57.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("no has obtenido ningun descuento");
                }




                label58.Visible = true;
                groupBox7.Visible = true;
            }



        }
    }
}
