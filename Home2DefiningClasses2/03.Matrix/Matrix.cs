using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Matrix
{
    public class Matrix<T> where T : struct, IComparable, IEnumerable
    {
        private int rows;
        private int row;
        private int cols;
        private int col;
        private T[,] matrix;
        

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.Row = row;
            this.Col = col;
            this.matrix = new T[this.Rows, this.Cols];
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = matrix[row, col];
                }
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get 
            {
                return this.matrix.GetLength(0);
            }
            set
            {
                if (this.rows < 0 || this.rows >= this.matrix.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
            set
            {
                if (this.cols < 0 || this.cols >= this.matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.cols = value;
            }
        }
        public int Row 
        { 
            get { return this.row; }
            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.row = value;
            }
        }
        public int Col
        {
            get { return this.col; }
            set
            {
                if (col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.col = value;
            }
        }
        
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                throw new ArgumentException();
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    //result[i, j] = (Matrix<T>)(matrix1[i, j] + matrix2[i, j])};
                }
            }
            return result;
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Append(string.Format("{0},  ", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, true);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, false);
        }

        private static bool BooleanOperator(Matrix<T> matrix, bool trueOrFalse)
        {
            foreach (var element in matrix.matrix)
            {
                if (!element.Equals(default(T)))
                {
                    return trueOrFalse;
                }
            }

            return !trueOrFalse;
        }

    }
}
