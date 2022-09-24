using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.to_
{
	static public class _ToMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="grid"></param>
		/// <param name="_majorPartition_assumePositivesSumValid"> group rows</param>
		/// <param name="_minorPartition_assumePositivesSumValid">
		/// group cols
		/// </param>
		/// <returns></returns>
		static public double[,] _Matrix_assumeDwelt1gridBlockEachDwelt(
			double[,][,] grid
		)
		{
			var h = matrix.grid.to_._matrix._SizeX.TotalHigh(grid);

			var r = new double[h, _matrix._SizeX.TotalWide(grid)];

			for (int i = 0, rRowBase = 0; i < grid.GetLength(0); i++)
			{

				int j = 0;
				for (var rColBase = 0; j < grid.GetLength(1); j++)
				{

					for (int cRow = 0, rRowIndex = rRowBase; cRow < grid[i, j].GetLength(0); cRow++, rRowIndex++)
					{
						for (int cCol = 0, rColIndex = rColBase; cCol < grid[i, j].GetLength(1); cCol++, rColIndex++)
						{
							r[rRowIndex, rColIndex] = grid[i, j][cRow, cCol];

						}
					}
					rColBase += grid[i, j].GetLength(1);

				}
				if (j > 0)  ///at least one lap
				{
					rRowBase += grid[i, 0].GetLength(0);
				}
			}

			return r;
		}

		public static double[,] _Matrix_assumeDwelt1gridBlockEachDwelt(IEnumerable<IEnumerable<IEnumerable<IEnumerable<double>>>> grid)
		{
			var h =		matrix.grid.to_._matrix._SizeX.TotalHigh(grid);

			var r = new double[h, _matrix._SizeX.TotalWide(grid)];

			for (int i = 0, rRowBase = 0; i <  grid.Count(); i++)
			{

				int j = 0;
				for (var rColBase = 0; j < grid.First().Count(); j++)
				{

					for (int cRow = 0, rRowIndex = rRowBase; cRow < grid.ElementAt(i).ElementAt( j).Count(); cRow++, rRowIndex++)
					{
						for (int cCol = 0, rColIndex = rColBase; cCol < grid.ElementAt(i).ElementAt( j).First().Count(); cCol++, rColIndex++)
						{
							r[rRowIndex, rColIndex] = grid.ElementAt(i).ElementAt( j).ElementAt(cRow).ElementAt( cCol);

						}
					}
					rColBase += grid.ElementAt(i).ElementAt( j).First().Count();

				}
				if (j > 0)  ///at least one lap
				{
					rRowBase += grid.ElementAt(i).First().Count();
				}
			}

			return r;

		}
	}
}
