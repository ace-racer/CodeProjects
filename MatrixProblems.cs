using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects
{
    public class MatrixProblems
    {
        /// <summary>
        /// The matrix
        /// </summary>
        private int[,] Matrix;

        /// <summary>
        /// The rows
        /// </summary>
        private int rows;

        /// <summary>
        /// The columns
        /// </summary>
        private int columns;

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixProblems"/> class.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="columns">The columns.</param>
        public MatrixProblems(int rows, int columns)
        {
            if (rows >= 0 && columns >= 0)
            {
                this.rows = rows;
                this.columns = columns;
                Matrix = new int[rows, columns];
                int cellValue = 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Matrix[i, j] = cellValue;
                        cellValue++;
                    }
                }
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Printing the Matrix....");
            var rowElements = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {                    
                    rowElements.Append(this.Matrix[i, j] + " ");
                }

                Console.WriteLine(rowElements.ToString());
                rowElements.Clear();
            }
        }       
        
        public void RotateClockwise()
        {
            int numShells = this.rows / 2;
            for (int i = 0; i < numShells; i++)
            {
                for (int j = i; j < this.columns - 1 - i; j++)
                {
                    int temp = this.Matrix[i, j];

                    this.Matrix[i, j] = this.Matrix[this.rows - 1 - j, i];

                    this.Matrix[this.rows - 1 - j, i] = this.Matrix[this.rows - 1 - i, this.columns - 1 - j];

                    this.Matrix[this.rows - 1 - i, this.columns - 1 - j] = this.Matrix[j, this.columns - 1 - i];

                    this.Matrix[j, this.columns - 1 - i] = temp ;
                }
            }
        }
        
        public void PrintSpiralOfMatrix()
        {
            var sb = new StringBuilder();
            if (this.rows >= 2 && this.columns >= 2)
            {
                int numShells = this.rows / 2;                
                for (int i = 0; i <= numShells; i++)
                {
                    // the top row of the shell (including the first and last elements)
                    for (int j = i; j <= this.columns - 1 - i; j++)
                    {
                        sb.Append(this.Matrix[i, j] + " ");
                    }

                    // the right column of the shell (excluding the first but including the last element)
                    for (int j = i + 1; j <= this.rows - 1 - i; j++)
                    {
                        sb.Append(this.Matrix[j, this.columns - 1 - i] + " ");
                    }

                    // the last row of the shell (excluding the first but including the last element)
                    for (int j = this.columns - i - 2; j >= i; j--)
                    {
                        sb.Append(this.Matrix[this.rows - 1 - i, j] + " ");
                    }

                    // the first column of the shell (excluding the first and the last element)
                    for (int j = this.rows - 2 - i; j >= i + 1; j--)
                    {
                        sb.Append(this.Matrix[j, i] + " ");
                    }
                }
            }
            else
            {
                sb.Append(this.Matrix[0, 0]);    
            }


            Console.WriteLine(sb.ToString());
        }                        
    }
}
