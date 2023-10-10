using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            string str = "-1 0 3\n6 -8 0\n7 8 -2";
            MyMatrix matrixOfFirst = new MyMatrix(str);
            
            string[] stringArray = { "1 2 3", "4 5 6", "7 8 9" };
            MyMatrix matrixOfSecond = new MyMatrix(stringArray);
            
            double[,] twoDimensionalArray = { { 7, 5, -3}, { 1, 2, -6 }, { 3, 9, 4 } };
            MyMatrix matrixOfThird = new MyMatrix(twoDimensionalArray);

            double[][] jaggedArray = { new double[] { 0, -3, 9 }, new double[] { 0, -5, 4 }, new double[] { -7, 4, 9 } };
            MyMatrix matrixOfFourth = new MyMatrix(jaggedArray);

            Console.WriteLine("Перша матриця з рядка:");
            Console.WriteLine(matrixOfFirst);

            Console.WriteLine("Друга матриця з масиву рядкiв:");
            Console.WriteLine(matrixOfSecond);

            Console.WriteLine("Третя матриця з двовимiрного масиву:");
            Console.WriteLine(matrixOfThird);

            Console.WriteLine("Четверта матриця з зубчастого масиву:");
            Console.WriteLine(matrixOfFourth);
            
            Console.WriteLine("Результат додавання першої та другої матриць:");
            MyMatrix resultMatrixAdditionFirst = matrixOfFirst + matrixOfSecond;
            Console.WriteLine(resultMatrixAdditionFirst);
            
            Console.WriteLine("Результат додавання третьої та четвертої матриць:");
            MyMatrix resultMatrixAdditionSecond = matrixOfThird + matrixOfFourth;
            Console.WriteLine(resultMatrixAdditionSecond);
            
            Console.WriteLine("Результат множення першої та другої матриць:");
            MyMatrix resultMatrixMultiplicationFirst = matrixOfFirst * matrixOfSecond;
            Console.WriteLine(resultMatrixMultiplicationFirst);
            
            Console.WriteLine("Результат множення третьої та четвертої матриць:");
            MyMatrix resultMatrixMultiplicationSecond = matrixOfThird + matrixOfFourth;
            Console.WriteLine(resultMatrixMultiplicationSecond);
            
            Console.WriteLine("Транспонована перша матриця:");
            matrixOfFirst.TransposeMe();
            Console.WriteLine(matrixOfFirst);
            
            Console.WriteLine("Транспонована друга матриця:");
            matrixOfSecond.GetTransponedCopy();
            Console.WriteLine(matrixOfSecond);
            
            Console.WriteLine("Транспонована третя матриця:");
            matrixOfThird.TransposeMe();
            Console.WriteLine(matrixOfThird);
            
            Console.WriteLine("Транспонована четверта матриця:");
            matrixOfFourth.GetTransponedCopy();
            Console.WriteLine(matrixOfFourth);
            
            Console.WriteLine($"Висота першої матрицi(Java-style getter): {matrixOfFirst.GetHeight()}");
            Console.WriteLine($"Ширина першої матрицi(Java-style getter): {matrixOfFirst.GetWidth()}\n");
            
            Console.WriteLine("До замiни окремого елемента матрицi:");
            Console.WriteLine(matrixOfSecond);
            
            Console.WriteLine($"Елемент [2, 2]: {matrixOfSecond[1, 1]} (змiнюємо на 10)");
            matrixOfSecond.SetElement(1, 1, 10);
            matrixOfSecond.GetElement(1, 1);
            Console.WriteLine($"Елемент [2, 2]: {matrixOfSecond[1, 1]}\n");
            
            Console.WriteLine("Пiсля замiни окремого елемента матрицi:");
            Console.WriteLine(matrixOfSecond);
        }
    }
}
