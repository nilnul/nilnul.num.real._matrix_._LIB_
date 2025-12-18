using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq.be_.triag_
{

	/// <summary>
	/// only lower are immune from nil;
	/// </summary>
	/// <see cref="real.matrix.be_.trape_._UpperX"/>
	static public class _LowerX
	{
		/// <summary>
		/// all upper cels are 0;
		/// eg:
		///		[
		///			a,0
		///			3,b
		///		]
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsLower_0sq(A[,] m)
		{

			int n = m.GetLength(0);

			for (int j = 0; j < n; j++)
			{
				for (int i = 0; i < j; i++)
				{
					if (m[i, j]!=0)
					{
						return false;
					}
				}
			}

			return true;

		}


	}
}
