using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_.sym_
{
	/// <summary>
	/// used in <see cref="num.real.expr_.polynom_.homo_.IQuadratic"/>.
	/// </summary>
	///
	static public class _MidX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// (a+a^t )/2
		/// </returns>
		static public Q[,] Mid(Q[,] m) {

			var r= (Q[,]) m.Clone();

			int wide = r.GetLength(0);

			for (int i = 0; i < wide; i++)
			{
				for (int j = i+1; j < wide; j++)
				{
					r[i, j] = r[ j,i ] = (m[i, j] + m[j, i]) / 2;


				}
			}
			return r;
		}
	}
	internal class IMid
	{
	}
}
