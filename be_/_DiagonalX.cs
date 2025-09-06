using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{

	/// <summary>
	/// only diagonal cels are immune from nil;
	/// </summary>
	static public class _DiagonalX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <remarks>
		/// both <see cref="triag_._LowerX"/> and <see cref="triag_._UpperX"/>
		/// </remarks>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool IsDiagonal(Q[,] m) {

			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			for (int i = 0, iP=1; i < rows; i++, iP++)
			{
				var min = Math.Min(cols, i);
				for (int j = 0; j < min; j++)
				{
					if (m[i, j] != 0)
					{
						return false;
					}
				}


				for (int j = iP; j < cols; j++)
				{
					if (m[i,j]!=0)
					{
						return false;
					}
				}
			}

			return true;

		}
	}
}
