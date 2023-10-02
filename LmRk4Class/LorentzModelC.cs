using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmRk4Class
{
    class LorentzModelC
    {

         double et, b, r;
        double dt = 0.01;
        int n;
        double[] x;
        double[] y;
        double[] z;
        double[] t;
        double k1, k2, k3,k4, l1, l2, l3,l4, m1, m2, m3,m4;
        Form1 f;
        Point or = new Point(200, 200);
        int inc = 190;
        double xmax, ymax , zmax, tmax = 0;

        public LorentzModelC(double _et, double _b, double _r, int _n,double _x,double _y,double _z,double _t)
        {
            et = _et;
            b = _b;
            r = _r; n = _n;
          
            x = new double[n];
             y = new double[n];
             z = new double[n];
            t = new double[n];
            x[0] = _x;
            y[0] = _y;
            z[0] = _z;
            t[0] = _t;
            xmax = x[0];
            ymax = y[0];
            zmax = z[0];
            tmax = t[0];
        }
        public void process()
        {
            for (int i = 0; i < n - 1; i++)
            {
                k1 = dt * f1(x[i], y[i]);
                l1 = dt * f2(x[i], y[i], z[i]);
                m1 = dt * f3(x[i], y[i], z[i]);
                k2 = dt * f1(x[i] + k1 / 2, y[i] + l1 / 2);
                l2 = dt * f2(x[i] + k1 / 2, y[i] + l1 / 2, z[i] + m1 / 2);
                m2 = dt * f3(x[i] + k1 / 2, y[i] + l1 / 2, z[i] + m1 / 2);
                k3 = dt * f1(x[i] + k2 / 2, y[i] + l2 / 2);
                l3 = dt * f2(x[i] + k2 / 2, y[i] + l2 / 2, z[i] + m2 / 2);
                m3 = dt * f3(x[i] + k2 / 2, y[i] + l2 / 2, z[i] + m2 / 2);
                k4 = dt * f1(x[i] + k3, y[i] + l3);
                l4 = dt * f2(x[i] + k3, y[i] + l3, z[i] + l3);
                m4 = dt * f3(x[i] + k3, y[i] + l3, z[i] + m3);
                x[i + 1] = x[i] + (k1 + 2 * (k2 + k3) + k4) / 6;
                y[i + 1] = y[i] + (l1 + 2 * (l2 + l3) + l4) / 6;
                z[i + 1] = z[i] + (m1 + 2 * (m2 + m3) + m4) / 6;
                t[i + 1] = t[i] + dt;
                if (xmax < x[i + 1])
                {
                    xmax = x[i + 1];
                }
                if (ymax < y[i + 1])
                {
                    ymax = y[i + 1];
                }
                if (zmax < z[i + 1])
                {
                    zmax = z[i + 1];
                }
                if (tmax < t[i + 1])
                {
                    tmax = t[i + 1];
                }


            }

        }
        public void plotx_vs_y(Form1 f1)
        {
            f = f1;
            Graphics gg = f1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);
            drawaxis(or, inc, "x", "z");
            for (int i = 0; i < n; i++)
            {
              
                gg.FillEllipse(sb, or.X + (float)(y[i] / ymax * inc), or.Y - (float)(x[i] / xmax * inc), 5, 5);
            }
        }
        public void plotx_vs_t(Form1 f1)
        {     
            f=f1;
            Graphics gg = f1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            drawaxis(or, inc, "t", "x");
            for (int i = 0; i < n; i++)
            {
                gg.FillEllipse(sb, or.X + (float)(t[i] /tmax *inc), or.Y - (float)(x[i] / xmax *inc), 5, 5);

            }
        }
        public void plotz_vs_x(Form1 f1)
        {
            f = f1;
            Graphics gg = f1.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            drawaxis(or, inc, "x", "z");
            for (int i = 0; i < n; i++)
            {
                gg.FillEllipse(sb, or.X + (float)(x[i]/xmax * inc), or.Y- (float)(z[i]/zmax * inc), 5, 5);

            }
        }

        double f1(double x1, double y1)
        {
            return (et * (y1 - x1));
        }
        double f2(double x1, double y1, double z1)
        {
            return ((-x1 * z1 + r * x1) - y1);
        }
        double f3(double x1, double y1, double z1)
        {
            return (x1 * y1 - b * z1);
        }
        void drawaxis(Point or, int incp,string stx,string sty)
        {
            Point p1 = new Point(or.X + incp, or.Y);
            Point p2 = new Point(or.X - incp, or.Y);
            Point p3 = new Point(or.X, or.Y - incp);
            Point p4 = new Point(or.X, or.Y+ incp);
            Graphics gg = f.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);
            Pen p = new Pen(Color.Red);
            Font f22 = new System.Drawing.Font("Ariel", 15);
            gg.DrawLine(p, p1, p2);
            gg.DrawLine(p, p3, p4);
            gg.DrawString(stx, f22, sb, new Point(or.X + 80, or.Y));
            gg.DrawString(sty, f22, sb, new Point(or.X - 20, or.Y-80));



        }

    }
}
