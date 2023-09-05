using MTP;
using System;

namespace MPE
{
    public class Task2Solver
    {
        private double B ;//TODO: посмотреть знак констант
        private double Ly ;
        private int N ;
        private double Tr;
        private double t;
        private double y;
        private double[] An;

        public Task2Solver(InputHelper input) {
            B = input.k / input.c;
            Ly = input.l_y;
            N = input.N;
            Tr = input.T;
            An = InitAn(input.N);
        }

        public double GetLy()
        {
            return Ly;
        }

        public void SetLy(double Ly)
        {
            if (Ly < 0)
                throw new Exception("Ly < 0");
            this.Ly = Ly;
        }

        public double GetTr()
        {
            return Tr;
        }

        public void SetTr(double Tr)
        {
            if (Tr < 0)
                throw new Exception("Tr < 0");
            this.Tr = Tr;
        }

        public double GetY() {
            return y;
        }

        public void SetY(double y) {
            if (y < 0 || y > Ly)
                throw new Exception("y<0 or y>Ly");
            this.y = y;
        }

        public double GetT()
        {
            return t;
        }
        public void SetT(double t)
        {
            if (t < 0 || t > Tr)
                throw new Exception("t<0 or t>T");
            this.t = t;
        }

        public void SetN(int N) {
            if (this.N != N)
            {
                this.N = N;
                InitAn(N);
            }
            if(N<1)
                throw new Exception("N<1");//TODO
        }

        public int GetN()
        {
            return N;
        }

        private  double[] InitAn(int N)
        {
            double[] An = new double[N / 2 + 2];
            An[0] = 4;
            for (int i = 1, j = 1; i <= N; i += 2, ++j)
            {
                An[j] = (8 / (Math.PI * i)) * Math.Pow(-1, (i - 1) / 2);
            }
            return An;
        }

        public double GetPartialSum()
        {
            double sum = An[0];
            for (int i = 1, j = 1; i <= N; i += 2, ++j)
            {
                sum += An[j] * Math.Exp(-B * Math.Pow(Math.PI * i / Ly, 2) * t)
                * Math.Cos(Math.PI * i * y / Ly);
            }
            return sum;
        }

    }
}
