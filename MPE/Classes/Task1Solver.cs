using System;
using System.Collections.Generic;

namespace MPE
{
    internal class Task1Solver
    {
        public static double E = Math.Pow(10, -14);
        public static double lx = 10;
        public static double a = 0.004;
        public static double k = 0.13;
        public static double c = 1.84;
        public static double d = Math.Pow(10, -7);
        public static int n;
        public static double eps;

        public static double F(double x)
        {
            return Math.Tan(lx * x / 2) - a / x;
        }

        public static double GetRoot(double a, double b)
        {
            // for i in range(n):
            var mid = (a + b) / 2;
            while (Math.Abs(b - a) > 2 * E)
            {
                mid = (a + b) / 2;
                if (F(mid) * F(b) <= 0)
                    a = mid;
                else
                    b = mid;
            }
            return mid;
        }

        public static List<double> GetPn()
        {
            // 10 ^ (-14)
            // допустимо 10 ^ (-12)

            List<double> Pn = new List<double>();

            double l = d;


            for (int i = 0; i < n; ++i)
            {
                double rAsymp = Math.PI * (2 * i + 1) / lx;
                Pn.Add(GetRoot(l, rAsymp - d));
                l = rAsymp + d;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Pn[i]);
            }

            return Pn;
        }

        public static List<double> GetGn()
        {
            List<double> Gn = new List<double>();
            List<double> Pn = GetPn();

            for (int i = 0; i < n; ++i)
                Gn.Add((lx + Math.Sin(Pn[i] * lx) / Pn[i]) / 4);

            return Gn;
        }

        public static List<double> GetCn()
        {
            List<double> Cn = new List<double>();
            List<double> Pn = GetPn();
            List<double> Gn = GetGn();

            for (int i = 0; i < n; ++i)
                Cn.Add((5 * Math.PI * lx * Math.Cos(Pn[i] * lx / 2)) /
                    (Gn[i] * (Math.Pow(Math.PI, 2) - Math.Pow(lx * Pn[i], 2))));

            return Cn;
        }

        public static List<double> GetSolution(double z, double t)
        {
            List<double> V = new List<double>();
            List<double> Pn = GetPn();
            List<double> Cn = GetCn();
            double b = k / c;
            for (int i = 0; i < n; ++i)
                V.Add(Cn[i] * Math.Exp(-b * Math.Pow(Pn[i], 2) * t) * Math.Cos(Pn[i] * z));
            return V;
        }

        public static List<double> GetPartialSums(List<double> V)
        {
            var list = new List<double>() { V[0] };
            for (int i = 1; i < V.Count; ++i)
            {
                list.Add(list[i - 1] + V[i]);
            }
            return list;
        }

        public static double Fi(double N)
        {
            return 10 * (Math.Log(0.5) - Math.Log((N - 1) / (2 * N - 1))) / Math.PI;
        }

        public static double GetN(double eps)
        {
            double N;
            for (N = 2; Fi(N) > eps; ++N) ;
            return N;
        }
    }
}
