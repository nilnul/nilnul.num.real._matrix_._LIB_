using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.to_._matrix
{
	static public class _SizeX
	{
		static public int TotalHigh(this double[,][,] k ) {
			var r = 0;
			for (int i = 0; i < k.GetLength(0); i++)
			{
				r += k[0, i].GetLength(0);
			}
			return r;
		}

		public static int TotalHigh(IEnumerable<IEnumerable<IEnumerable<IEnumerable<double>>>> grid)
		{

			return grid.Select(
				(rowOfGrid) => rowOfGrid // a collection of block inside row
				.First().Count()
			).Sum();
		}

		static public int TotalWide(this double[,][,] k ) {
			var r = 0;
			for (int i = 0; i < k.GetLength(1); i++)
			{
				r += k[0, i].GetLength(1);
			}
			return r;
		}

		public static int _TotalWide_ofRow(IEnumerable<IEnumerable<IEnumerable<double>>> row)
		{
			return row.Select(
				(blockInRow) => blockInRow.First().Count()
			).Sum();

		}

		public static int TotalWide(IEnumerable<IEnumerable<IEnumerable<IEnumerable<double>>>> grid)
		{
			return _TotalWide_ofRow(
				grid.First()
			);

		}

	}
}
