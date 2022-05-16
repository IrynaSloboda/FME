using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.mariuszgromada.math.mxparser;

namespace FiniteElementMethod
{
    public partial class Form1 : Form
    {
        public Function ux;
        public Function Tx;
        public Function fx;
        public double q_;
        public int n;

        public Form1()
        {
            InitializeComponent();
        }

        public double[,] Aij(List<double> x, Function T, double h, int n)
        {
            var A = new double[n, n];

            A[0, 0] = (1 / h) * T.calculate(x[0] + h / 2);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && i != 0)
                    {
                        A[i, j] = (1 / h) * (T.calculate(x[i] - h / 2) + T.calculate(x[i] + h / 2));
                    }
                    else if (j - i == 1)
                    {
                        A[i, j] = (-1 / h) * T.calculate(x[i] + h / 2);
                    }
                    else if (i - j == 1)
                    {
                        A[i, j] = (-1 / h) * T.calculate(x[j] + h / 2);
                    }
                }
            }
            return A;
        }

        public double[] Li(List<double> x, Function f, double h, double q_, int n)
        {
            var l = new double[n];
            l[0] = (h / 2) * (f.calculate(x[0] + h / 2)) + q_;

            for (int i = 1; i < n; i++)
            {
                l[i] = (h / 2) * (f.calculate(x[i] - h / 2) + f.calculate(x[i] + h / 2));
            }
            return l;
        }

        public List<double> TridiagonalMatrixAlgorithmSLAR(double[,] A, double[] l, int n)
        {
            List<double> a = new List<double>(); // нижня діагональ
            List<double> b = new List<double>(); // центральна діагональ
            List<double> c = new List<double>(); // верхня діагональ

            List<double> qi = new List<double>();
            for (int i = 0; i < n; i++)
            {
                qi.Add(0);
            }

            a.Add(0); // a1=0
            for (int i = 0; i < n - 1; i++)
            {
                b.Add(A[i, i]);
                a.Add(A[i + 1, i]);
                c.Add(A[i, i + 1]);
            }

            b.Add(A[n - 1, n - 1]);
            c.Add(0); // cn=0

            c[0] /= b[0];
            l[0] /= b[0];

            for (int i = 1; i < n; i++)
            {
                double temp = 1 / (b[i] - c[i - 1] * a[i]);
                c[i] *= temp;
                l[i] = (l[i] - l[i - 1] * a[i]) * temp;
            }

            qi[n - 1] = l[n - 1];
            for (int i = n - 2; i >= 0; i--)
                qi[i] = l[i] - (c[i] * qi[i + 1]);

            return qi;
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            realChart.Series[0].Points.Clear();
            allCharts.Series["Real Chart"].Points.Clear();

            ux = new Function("f(x) = " + u_function.Text);
            var uxDer = new Function("f(x) = der(" + u_function.Text + ", x)");

            Tx = new Function("f(x) = " + T_function.Text);
            fx = new Function("f(x) = " + f_function.Text);
            q_ = Convert.ToDouble(q_value.Text);
            n = Convert.ToInt32(n_value.Text);

            for (double i = 0.0; i <= 1.01; i += 0.01)
            {
                realChart.Series[0].Points.AddXY(i, ux.calculate(i));
                allCharts.Series["Real Chart"].Points.AddXY(i, ux.calculate(i));
            }

            List<double> xi = new List<double>();
            for (double i = 0; i <= n; i++)
            {
                xi.Add((1.0 / n) * i);
            }

            var h = 1.0 / n;
            double[,] A = Aij(xi, Tx, h, n);
            double[] l = Li(xi, fx, h, q_, n);
            List<double> q = TridiagonalMatrixAlgorithmSLAR(A, l, n);
            q.Add(0);

            List<double> uh = new List<double>();
            for (int i = 0; i <= n; i++)
            {
                var x = xi[i];
                uh.Add(q[i] * Fi(h, i, xi, x));
            }

            var title = "n = " + n.ToString();
            chart.Series[0].Name = title;
            for (int i = 0; i < uh.Count; i++)
            {
                chart.Series[0].Points.AddXY(xi[i], uh[i]);
            }

            allCharts.Series.Add(title);
            allCharts.Series[title].ChartType = SeriesChartType.Line;
            for (int i = 0; i < uh.Count; i++)
            {
                allCharts.Series[title].Points.AddXY(xi[i], uh[i]);
            }

            var uh0 = Norma0(q, h);
            uh0_value.Text = Math.Round(uh0, 5).ToString();
            uh1_value.Text = Math.Round(Norma1(q, h, uh0), 5).ToString();

            double error = 0.0;
            for (int i = 0; i < n; i++)
            {
                double sum1 = GaussLegendreQuadrature(xi[i], xi[i + 1],
                    x => Math.Pow(ux.calculate(x) - (q[i] * (1 - (x - xi[i]) / h) + q[i + 1] * ((x - xi[i]) / h)), 2));
                double sum2 = GaussLegendreQuadrature(xi[i], xi[i + 1],
                    x => Math.Pow(uxDer.calculate(x) - ((q[i + 1] - q[i]) / h), 2));
                error += sum1 + sum2;
            }
            u_uh.Text = Math.Round(Math.Sqrt(error), 5).ToString();
        }

        public double Fi(double h, int i, List<double> xi, double x)
        {
            if (i == 0)
            {
                if (x >= xi[0] && x <= xi[1])
                    return (xi[1] - x) / h;
                else
                    return 0;
            }
            else if (i == xi.Count)
            {
                if (x >= xi[i - 1] && x <= xi[i])
                    return (x - xi[i - 1]) / h;
                else
                    return 0;
            }
            else if (x >= xi[i - 1] && x <= xi[i])
            {
                return (x - xi[i - 1]) / h;
            }
            else if (x >= xi[i] && x <= xi[i + 1])
            {
                return (xi[i + 1] - x) / h;
            }
            return 0;
        }

        public double Norma0(List<double> q, double h)
        {
            double uh0 = 0;
            for (int i = 0; i < n; i++)
            {
                uh0 += Math.Pow(q[i], 2) + q[i] * q[i + 1] + Math.Pow(q[i + 1], 2);
            }
            return Math.Sqrt((h / 3) * uh0);
        }

        public double Norma1(List<double> q, double h, double uh0)
        {
            double uh1 = 0;
            for (int i = 0; i < n; i++)
            {
                uh1 += Math.Pow(q[i] - q[i + 1], 2);
            }
            return Math.Sqrt(1 / h * uh1 + Math.Pow(uh0, 2));
        }

        static double GaussLegendreQuadrature(double a, double b, Func<double, double> func)
        {
            var x = new double[5] { -0.90618, -0.538469, 0, 0.538469, 0.90618 };
            var w = new double[5] { 0.23693, 0.47863, 0, 0.56889, 0.23693 };

            var res = 0.0;
            for (int i = 0; i < 5; i++)
            {
                res += w[i] * func(((b - a) / 2) * x[i] + (a + b) / 2 );
            }

            return res *= (b - a) / 2;
        }
    }
}