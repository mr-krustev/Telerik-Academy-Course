using Matrix.Logic.Common;

namespace Matrix.Logic
{
    using System;

    public static class Matrix
    {
        private static readonly int[] DirectionsByY = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] DirectionsByX = { 1, 0, -1, -1, -1, 0, 1, 1 };
        private static int _directionIndex;
        private static int _nextAvailableValue;
        private static bool _isMatrixReady = false;

        public static int[,] Generate(int rows, int cols)
        {
            Validator.CheckIfValidPositiveNumber(rows);
            Validator.CheckIfValidPositiveNumber(cols);

            var matrix = new int[rows, cols];
            _directionIndex = 0;
            _nextAvailableValue = 0;

            FillMatrix(matrix);

            return matrix;
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (var row = 0; row < matrix.GetLength(0); )
            {
                for (var col = 0; col < matrix.GetLength(1); )
                {
                    var currentCell = FindNextCell(matrix, row, col);
                    if (_isMatrixReady)
                    {
                        row = matrix.GetLength(0);
                        break;
                    }
                    matrix[row, col] = ++_nextAvailableValue;
                    row = currentCell[0];
                    col = currentCell[1];
                }
            }

        }

        private static int[] FindNextCell(int[,] matrix, int row, int col)
        {
            var canMoveInCurrentDirection = CanMoveInCurrentDirection(matrix, row, col);
            var nextCellRow = 0;
            var nextCellColl = 0;
            var directionsCheckedCounter = 0;

            while (!canMoveInCurrentDirection)
            {
                _directionIndex = (_directionIndex + 1) % DirectionsByX.Length;
                canMoveInCurrentDirection = CanMoveInCurrentDirection(matrix, row, col);
                directionsCheckedCounter++;

                if (directionsCheckedCounter > 7)
                {
                    var nextCell = GetSmallestAvailableCell(matrix);
                    _directionIndex = 0;

                    if (nextCell == null)
                    {
                        _isMatrixReady = true;
                        return null;
                    }
                    return nextCell;
                }
            }

            if (canMoveInCurrentDirection)
            {
                nextCellRow = row + DirectionsByY[_directionIndex];
                nextCellColl = col + DirectionsByX[_directionIndex];
            }

            return new int[2] { nextCellRow, nextCellColl };
        }

        private static int[] GetSmallestAvailableCell(int[,] matrix)
        {
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        return new int[2] { row, col };
                    }
                }
            }
            return null;
        }

        private static bool CanMoveInCurrentDirection(int[,] matrix, int row, int col)
        {
            var nextCol = col + DirectionsByX[_directionIndex];
            var nextRow = row + DirectionsByY[_directionIndex];

            var canMoveOnRow = 0 <= nextRow && nextRow < matrix.GetLength(0);
            var canMoveOnCol = 0 <= nextCol && nextCol < matrix.GetLength(1);

            var hasSteppedBefore = false;
            if (canMoveOnCol && canMoveOnRow)
            {
                hasSteppedBefore = (matrix[nextRow, nextCol] != 0);
            }

            return canMoveOnCol && canMoveOnRow && !hasSteppedBefore;
        }
    }
}
