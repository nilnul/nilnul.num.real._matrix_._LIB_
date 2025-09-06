using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.triag_
{

	/// <summary>
	/// only upper are immune from nil;
	/// </summary>
	static public class _UpperX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool IsUpper(Q[,] m) {

			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			for (int i = 0, iP=1; i < rows; i++, iP++)
			{
				var min = Math.Min(cols, i);
				for (int j = 0; j < min; j++)
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
