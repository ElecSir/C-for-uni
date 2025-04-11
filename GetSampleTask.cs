using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Matrix
    {
        public double[,] Values { private set; get; }

        public Matrix(double[,] values)
        {
            Values = (double[,])values.Clone();
        }

        public int Raws => Values.GetLength(0);
        public int Columns => Values.GetLength(1);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            for (int raw = 0; raw < this.Raws; raw++)
            {
                for (int column = 0; column < this.Columns; column++)
                {
                    sb.Append($" {this[raw, column]}");
                }
                sb.Append('\n');
            }

            return sb.ToString();
        }

        public double this[int raw, int column]
        {
            get => this.Values[raw, column];
            set { this.Values[raw, column] = value; }
        }

        private static Matrix Sum(Matrix m1, Matrix m2, bool isSubtraction)
        {
            if (m1.Raws != m2.Raws || m1.Columns != m2.Columns)
                throw new ArgumentException("Матрицы имеют разное количество строк или столбцов.");

            var sumValues = new double[m1.Raws, m1.Columns];

            for (int raw = 0; raw < m1.Raws; raw++)
            {
                for (int column = 0; column < m1.Columns; column++)
                {
                    if(isSubtraction)
                        sumValues[raw, column] = m1[raw, column] - m2[raw, column];
                    else
                        sumValues[raw, column] = m1[raw, column] + m2[raw, column];
                }
            }

            return new Matrix(sumValues);
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return Sum(m1, m2, false);
        }

        public static Matrix operator -(Matrix m1)
        {
            var negativeValues = new double[m1.Raws, m1.Columns];
            for (int raw = 0; raw < m1.Raws; raw++)
            {
                for (int column = 0; column < m1.Columns; column++)
                {
                    negativeValues[raw, column] = -m1[raw, column];
                }
            }

            return new Matrix(negativeValues);
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            return Sum(m1, m2, true);
        }

        public static Matrix operator *(Matrix m1, double scalar)
        {
            var productValues = new double[m1.Raws, m1.Columns];
            for (int raw = 0; raw < m1.Raws; raw++)
            {
                for (int column = 0; column < m1.Columns; column++)
                {
                    productValues[raw, column] = m1[raw, column] * scalar;
                }
            }

            return new Matrix(productValues);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Raws)
                throw new ArgumentException("Число столбцов первой матрицы и число строк второй не совпадают");

            var productValues = new double[m1.Raws, m2.Columns];
            for (int raw = 0; raw < m1.Raws; raw++)
            {
                for (int column = 0; column < m2.Columns; column++)
                {
                    productValues[raw, column] = 0;
                    for (int i = 0; i < m1.Columns; i++)
                    {
                        productValues[raw, column] += m1[raw, i] * m2[i, column];
                    }
                }
            }

            return new Matrix(productValues);
        }

    }
}
