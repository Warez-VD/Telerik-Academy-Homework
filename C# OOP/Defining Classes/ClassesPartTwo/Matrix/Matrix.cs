namespace ClassesPartTwo.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : struct
    {
        //Fields
        private T[,] matrix;

        //Constructor
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        #region Methods
        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex < 0 || rowIndex >= matrix.GetLength(0)
                    && colIndex < 0 || colIndex >= matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("The index is outside the bounds of the array.");
                }

                return this.matrix[rowIndex, colIndex];
            }
            set
            {
                if (rowIndex < 0 || rowIndex >= matrix.GetLength(0)
                    && colIndex < 0 || colIndex >= matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("The index is outside the bounds of the array.");
                }

                this.matrix[rowIndex, colIndex] = value;
            }
        }

        public int GetLenght(int dimension)
        {
            if (dimension == 0)
            {
                return this.Rows;
            }
            else if (dimension == 1)
            {
                return this.Cols;
            }
            else
            {
                throw new ArgumentException("There isn's such dimension");
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetLenght(0) == m2.GetLenght(0) && m1.GetLenght(1) == m2.GetLenght(1))
            {
                Matrix<T> additionMatrix = new Matrix<T>(m1.GetLenght(0), m1.GetLenght(1));
                for (int row = 0; row < m1.GetLenght(0); row++)
                {
                    for (int col = 0; col < m1.GetLenght(1); col++)
                    {
                        additionMatrix[row, col] = (dynamic)m1[row, col] + (dynamic)m2[row, col];
                    }
                }

                return additionMatrix;
            }
            else
            {
                throw new ArgumentException("Matrices must have same lenght.");
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetLenght(0) == m2.GetLenght(0) && m1.GetLenght(1) == m2.GetLenght(1))
            {
                Matrix<T> substractMatrix = new Matrix<T>(m1.GetLenght(0), m1.GetLenght(1));
                for (int row = 0; row < m1.GetLenght(0); row++)
                {
                    for (int col = 0; col < m1.GetLenght(1); col++)
                    {
                        substractMatrix[row, col] = (dynamic)m1[row, col] - (dynamic)m2[row, col];
                    }
                }

                return substractMatrix;
            }
            else
            {
                throw new ArgumentException("Matrices must have same lenght.");
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetLenght(1) == m2.GetLenght(0))
            {
                Matrix<T> multiplyMatrix = new Matrix<T>(m1.GetLenght(0), m2.GetLenght(1));
                for (int row = 0; row < m1.GetLenght(0); row++)
                {
                    for (int col = 0; col < m2.GetLenght(1); col++)
                    {
                        for (int i = 0; i < m1.GetLenght(1); i++)
                        {
                            multiplyMatrix[row, col] += (dynamic)m1[row, i] * (dynamic)m2[i, col];
                        }
                    }
                }

                return multiplyMatrix;
            }
            else
            {
                throw new ArgumentException("To implement multiplication operation, the first matrix should have columns equal to the rows of the second matrix ");
            }

        }

        public static bool CheckForZeroValue(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.GetLenght(0); i++)
            {
                for (int j = 0; j < matrix.GetLenght(1); j++)
                {
                    dynamic value = matrix[i, j];

                    if (value == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return Matrix<T>.CheckForZeroValue(matrix);
        }
        
        public static bool operator false(Matrix<T> matrix)
        {
            return Matrix<T>.CheckForZeroValue(matrix);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result.Append(matrix[row, col] + " ");
                }
                result.AppendLine();
            }
            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
        #endregion

        //Properties
        public int Rows { get; set; }

        public int Cols { get; set; }
    }
}
