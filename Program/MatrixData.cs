using System;
using System.Text;

namespace Program
{
    partial class MyMatrix
    {
        private double[,] _matrix;
        
        private int Height { get; set; }

        private int Width { get; set; }
        
        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }
        
        public double this[int row, int column]
        {
            get => _matrix[row, column];
            set => _matrix[row, column] = value;
        }
        
        public double GetElement(int row, int column)
        {
            return _matrix[row, column];
        }

        public void SetElement(int row, int column, double value)
        {
            _matrix[row, column] = value;
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    result.Append(_matrix[i, j] + "\t");
                }

                result.AppendLine();
            }
            
            return result.ToString();
        }
        
        public MyMatrix(double[,] array)
        {
            _matrix = (double[,])array.Clone();
            Height = array.GetLength(0);
            Width = array.GetLength(1);
        }
        
        public MyMatrix(MyMatrix array)
        {
            _matrix = (double[,])array._matrix.Clone();
        }
        
        public MyMatrix(double[][] jaggedArray)
        {
            int rows = jaggedArray.Length;
            int cols = jaggedArray[0].Length;
            
            _matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                if (jaggedArray[i].Length != cols)
                {
                    throw new ArgumentException("Jagged array is not rectangular");
                }

                for (int j = 0; j < cols; j++)
                {
                    _matrix[i, j] = jaggedArray[i][j];
                }
            }

            Height = rows;
            Width = cols;
        }

        public MyMatrix(string[] rows)
        {
            int rowCount = rows.Length;
            int colCount = rows[0].Split(new [] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            
            _matrix = new double[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(new [] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (values.Length != colCount)
                {
                    throw new ArgumentException("Invalid number of elements in row");
                }

                for (int j = 0; j < colCount; j++)
                {
                    _matrix[i, j] = double.Parse(values[j]);
                }
            }

            Height = rowCount;
            Width = colCount;
        }

        public MyMatrix(string input)
        {
            string[] rows = input.Split(new [] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            int rowCount = rows.Length;
            int colCount = rows[0].Split(new [] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            
            _matrix = new double[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(new [] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (values.Length != colCount)
                {
                    throw new ArgumentException("Invalid number of elements in row");
                }

                for (int j = 0; j < colCount; j++)
                {
                    _matrix[i, j] = double.Parse(values[j]);
                }
            }

            Height = rowCount;
            Width = colCount;
        }
    }
}