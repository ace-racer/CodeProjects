using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects
{
    class KinghtsTour
    {
        /// <summary>
        /// The matrix
        /// </summary>
        private int[,] KnightMoves;

        private int ChessboardSize;

        public KinghtsTour(int size)
        {
            if (size >= 0)
            {
                this.ChessboardSize = size;
                this.KnightMoves = new int[this.ChessboardSize, this.ChessboardSize];
                for (int i = 0; i < this.ChessboardSize; i++)
                {
                    for (int j = 0; j < this.ChessboardSize; j++)
                    {
                        this.KnightMoves[i, j] = -1;
                    }                    
                }                
            }
        }

        public void PerformKnightTour(int row, int col, int moveNumber)
        {
            if(row >= 0 && col >= 0 && row < this.ChessboardSize && col < this.ChessboardSize)
            {
                // if the square is not yet visited
                if(this.KnightMoves[row, col] < 0)
                {
                    this.KnightMoves[row, col] = moveNumber;

                    // Lower half

                    // go two back and one to left
                    PerformKnightTour(row + 2, col + 1, moveNumber + 1);

                    // go two back and one to right
                    PerformKnightTour(row + 2, col - 1, moveNumber + 1);

                    // go two left and one to back
                    PerformKnightTour(row + 1, col + 2, moveNumber + 1);

                    // go two left and one to front
                    PerformKnightTour(row + 1, col - 2, moveNumber + 1);

                    // Lower half 

                    // go two back and one to right
                    PerformKnightTour(row - 2, col + 1, moveNumber + 1);

                    // go two back and one to left
                    PerformKnightTour(row - 2, col - 1, moveNumber + 1);

                    // go two right and one to back
                    PerformKnightTour(row - 1, col + 2, moveNumber + 1);

                    // go two left and one to back
                    PerformKnightTour(row - 1, col - 2, moveNumber + 1);
                }
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Printing the Tour....");
            var rowElements = new StringBuilder();
            for (int i = 0; i < this.ChessboardSize; i++)
            {
                for (int j = 0; j < this.ChessboardSize; j++)
                {
                    rowElements.Append(this.KnightMoves[i, j] + " ");
                }

                Console.WriteLine(rowElements.ToString());
                rowElements.Clear();
            }
        }
    }
}
