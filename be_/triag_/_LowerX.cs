using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.triag_
{

	/// <summary>
	/// only lower are immune from nil;
	/// </summary>
	static public class _LowerX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool IsLower(Q[,] m) {

			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			for (int i = 0, iP=1; i < rows; i++, iP++)
			{
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
