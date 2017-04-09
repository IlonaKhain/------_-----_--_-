using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace методы_нелин_ур_й
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            Polynomial polynom = new Polynomial();
            string f = txb_polynom.Text;
            string[] strcoefficients = f.Split(';');
            double[] coefficients = Array.ConvertAll<string, double>(strcoefficients, double.Parse);

            int order = polynom.order(coefficients);
            double a = Convert.ToDouble(txb_a.Text);
            double b = Convert.ToDouble(txb_b.Text);
            
            //проверяем условия применимости метода
            double func_a = polynom.func(coefficients, a, order);
            double func_b = polynom.func(coefficients, b, order);

            if (polynom.IsSignConst(func_a, func_b) == 0 || polynom.IsSignConst(func_a, func_b) == 1)
            {
                MessageBox.Show("Измените промежуток так, чтобы на нем был 1 корень");
            }

            double[] derivatecoef = polynom.derivate_coef(coefficients, order);

            double derivate_func_a = polynom.func(derivatecoef, a, order-1);
            double derivate_func_b = polynom.func(derivatecoef, b, order-1);

            if (polynom.IsSignConst(derivate_func_a, derivate_func_b) == 0|| polynom.IsSignConst(derivate_func_a, derivate_func_b) == -1)
            {
                MessageBox.Show("Метод не применим, производная обращается в 0 или не сохраняет знак");
            }

            // переходим от исходного уравнения к эквивалентному
            double m1 = polynom.minOfDerivate(a, b, derivatecoef);           
            double M1 = polynom.MaxOfDerivate(a, b, derivatecoef);
            double lamda ;

            // применяем иттерационную формулу            

            double x;
            if (derivate_func_a > 0)
            {
                lamda = 2 / (m1 + M1);
            }
            else { lamda = -2 / (m1 + M1); }
            int i = 0;
            double epsilent = Convert.ToDouble(txb_eps.Text);
            do
            {
                x = (polynom.newX_MI(a, lamda, polynom.func(coefficients, a, order)));
                a=x;            
                i++;
               
            }
            while (polynom.finish(polynom.func(coefficients, x, order), m1) > epsilent);
            listBox1.Items.Add("x " + i + " = " + x);
            //проверяем критерий окончания иттерационного процесса


        }

        private void btn_dikhotomia_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Polynomial polynom = new Polynomial();
            string f = txb_polynom.Text;
            string[] strcoefficients = f.Split(';');
            double[] coefficients = Array.ConvertAll<string, double>(strcoefficients, double.Parse);

            int order = polynom.order(coefficients);
            double a = Convert.ToDouble(txb_a.Text);
            double b = Convert.ToDouble(txb_b.Text);

            //проверяем условия применимости метода
            double func_a = polynom.func(coefficients, a, order);
            double func_b = polynom.func(coefficients, b, order);

            if (polynom.IsSignConst(func_a, func_b) == 0 || polynom.IsSignConst(func_a, func_b) == 1)
            {
                MessageBox.Show("Измените промежуток так, чтобы на нем был 1 корень");
            }

            double epsilent = Convert.ToDouble(txb_eps.Text);
            double x=0;

            do
            {
                x = polynom.newX_Dikhot(a, b);
                if (polynom.func(coefficients,x, order)==0)
                {
                    listBox2.Items.Add("точный корень " + x);
                }
                else
                { 
                    if (polynom.IsSignConst(polynom.func(coefficients,a,order),polynom.func(coefficients,x,order))==-1)
                        {
                        b = x;
                         }
                    else { a = x; }
                    listBox2.Items.Add("корень с точностью эпсилен " + x);
                }
                
            }
                
            while (polynom.finish_Dikh(a,b) > epsilent);
           
        }

        private void btn_MN_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Polynomial polynom = new Polynomial();
            string f = txb_polynom.Text;
            string[] strcoefficients = f.Split(';');
            double[] coefficients = Array.ConvertAll<string, double>(strcoefficients, double.Parse);

            int order = polynom.order(coefficients);
            double a = Convert.ToDouble(txb_a.Text);
            double b = Convert.ToDouble(txb_b.Text);

            //проверяем условия применимости метода
            double func_a = polynom.func(coefficients, a, order);
            double func_b = polynom.func(coefficients, b, order);

            if (polynom.IsSignConst(func_a, func_b) == 0 || polynom.IsSignConst(func_a, func_b) == 1)
            {
                MessageBox.Show("Измените промежуток так, чтобы на нем был 1 корень");
            }

            double[] derivatecoef = polynom.derivate_coef(coefficients, order);

            double derivate_func_a = polynom.func(derivatecoef, a, order - 1);
            double derivate_func_b = polynom.func(derivatecoef, b, order - 1);

            if (polynom.IsSignConst(derivate_func_a, derivate_func_b) == 0 || polynom.IsSignConst(derivate_func_a, derivate_func_b) == -1)
            {
                MessageBox.Show("Метод не применим, производная обращается в 0 или не сохраняет знак");
            }

            double[] derivate2coef = polynom.derivate_coef(derivatecoef, order-1);

            double derivate2_func_a = polynom.func(derivate2coef, a, order - 2);
            double derivate2_func_b = polynom.func(derivate2coef, b, order - 2);

            if (polynom.IsSignConst(derivate2_func_a, derivate2_func_b) == 0 || polynom.IsSignConst(derivate2_func_a, derivate2_func_b) == -1)
            {
                MessageBox.Show("Метод не применим, вторая производная обращается в 0 или не сохраняет знак");
            }

            // выбираем начальное приближение
            double x;
            if (polynom.IsSignConst(polynom.func(coefficients, a, order), polynom.func(derivate2coef, a, order - 2)) == 1)
            {
                x = a;
            }
            else if (polynom.IsSignConst(polynom.func(coefficients, b, order), polynom.func(derivate2coef, b, order - 2)) == 1)
            {
                x = b;
            }
            else {
                x = 0;
                MessageBox.Show("Один из концов промежутка является точным корнем");
            }
            //итерационный процесс
            double m1 = polynom.minOfDerivate(a, b, derivatecoef);
            int i = 0;
            double epsilent = Convert.ToDouble(txb_eps.Text);

            do
            {
                x = (polynom.newX_MN(x,coefficients, order));             
                i++;
                listBox3.Items.Add("x " + i + " = " + x);
            }
            while (polynom.finish(polynom.func(coefficients, x, order), m1) > epsilent);
           
            //проверяем критерий окончания иттерационного процесса
        }

        private void btn_Hord_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            Polynomial polynom = new Polynomial();
            string f = txb_polynom.Text;
            string[] strcoefficients = f.Split(';');
            double[] coefficients = Array.ConvertAll<string, double>(strcoefficients, double.Parse);

            int order = polynom.order(coefficients);
            double a = Convert.ToDouble(txb_a.Text);
            double b = Convert.ToDouble(txb_b.Text);

            //проверяем условия применимости метода
            double func_a = polynom.func(coefficients, a, order);
            double func_b = polynom.func(coefficients, b, order);

            if (polynom.IsSignConst(func_a, func_b) == 0 || polynom.IsSignConst(func_a, func_b) == 1)
            {
                MessageBox.Show("Измените промежуток так, чтобы на нем был 1 корень");
            }

            double[] derivatecoef = polynom.derivate_coef(coefficients, order);

            double derivate_func_a = polynom.func(derivatecoef, a, order - 1);
            double derivate_func_b = polynom.func(derivatecoef, b, order - 1);

            if (polynom.IsSignConst(derivate_func_a, derivate_func_b) == 0 || polynom.IsSignConst(derivate_func_a, derivate_func_b) == -1)
            {
                MessageBox.Show("Метод не применим, производная обращается в 0 или не сохраняет знак");
            }

            double[] derivate2coef = polynom.derivate_coef(derivatecoef, order - 1);

            double derivate2_func_a = polynom.func(derivate2coef, a, order - 2);
            double derivate2_func_b = polynom.func(derivate2coef, b, order - 2);

            if (polynom.IsSignConst(derivate2_func_a, derivate2_func_b) == 0 || polynom.IsSignConst(derivate2_func_a, derivate2_func_b) == -1)
            {
                MessageBox.Show("Метод не применим, вторая производная обращается в 0 или не сохраняет знак");
            }

            // выбираем начальное приближение
            double x;
            double not_move_point;
            if (polynom.IsSignConst(func_a, derivate2_func_a) == -1)
            {
                x = a;
                not_move_point = b;
            }
            else if (polynom.IsSignConst(func_b, derivate2_func_b) == -1)
            {
                x = b;
                not_move_point = a;
            }
            else
            {
                x = 0;
                not_move_point = a;
                MessageBox.Show("Один из концов промежутка является точным корнем");
            }

            //итерационный процесс
            double m1 = polynom.minOfDerivate(a, b, derivatecoef);
            int i = 0;
            double epsilent = Convert.ToDouble(txb_eps.Text);

            do
            {
                x = (polynom.newX_MH(x,coefficients,order,not_move_point ));
                i++;
                listBox4.Items.Add("x " + i + " = " + x);
            }
            while (polynom.finish(polynom.func(coefficients, x, order), m1) > epsilent);

            //проверяем критерий окончания иттерационного процесса

        }
    }
}
