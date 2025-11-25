using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.be_.triag_
{

	/// <summary>
	/// only lower are immune from nil;
	/// </summary>
	/// <see cref="matrix.be_.trape_._LowerX"/>
	static public class _LowerX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsLower_0equilat(in Q[,] m) {

			int rows = m.GetLength(0);

			for (int i = 0, iP=1; i < rows; i++, iP++)
			{
				for (int j = iP; j < rows; j++)
				{
					if (m[i,j]!=0)
					{
						return false;
					}
				}
			}

			return true;

		}

		static public bool _IsLower_0equilat(in int[,] m) {

			int rows = m.GetLength(0);

			for (int i = 0, iP=1; i < rows; i++, iP++)
			{
				for (int j = iP; j < rows; j++)
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
