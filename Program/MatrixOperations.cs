using System;

namespace Program
{
    partial class MyMatrix 
    {
        private double[,] GetTransponedArray()
        {
            double[,] transposedArray = new double[Width, Height];
            
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    transposedArray[j, i] = _matrix[i, j];
                }
            }
            
            return transposedArray;
        }
        
        public MyMatrix GetTransponedCopy()
        {
            double[,] transposedArray = GetTransponedArray();
            
            return new MyMatrix(transposedArray);
        }
        
        public void TransposeMe()
        {
            _matrix = GetTransponedArray();
            
            int temp = Height;
            Height = Width;
            Width = temp;
        }
        
        public static MyMatrix operator +(MyMatrix matrixOfFirst, MyMatrix matrixOfSecond)
        {
            if (matrixOfFirst.Height != matrixOfSecond.Height || matrixOfFirst.Width != matrixOfSecond.Width)
            {
                throw new ArgumentException("Matrices must have the same dimensions for addition.");
            }

            double[,] resultArray = new double[matrixOfFirst.Height, matrixOfFirst.Width];
            
            for (int i = 0; i < matrixOfFirst.Height; i++)
            {
                for (int j = 0; j < matrixOfFirst.Width; j++)
                {
                    resultArray[i, j] = matrixOfFirst[i, j] + matrixOfSecond[i, j];
                }
            }

            return new MyMatrix(resultArray);
        }
        
        public static MyMatrix operator *(MyMatrix matrixOfFirst, MyMatrix matrixOfSecond)
        {
            if (matrixOfFirst.Width != matrixOfSecond.Height)
            {
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix for matrix multiplication.");
            }

            double[,] resultArray = new double[matrixOfFirst.Height, matrixOfSecond.Width];
            
            for (int i = 0; i < matrixOfFirst.Height; i++)
            {
                for (int j = 0; j < matrixOfSecond.Width; j++)
                {
                    double sum = 0;
                    
                    for (int k = 0; k < matrixOfFirst.Width; k++)
                    {
                        sum += matrixOfFirst[i, k] * matrixOfSecond[k, j];
                    }
                    
                    resultArray[i, j] = sum;
                }
            }

            return new MyMatrix(resultArray);
        }
    }
}