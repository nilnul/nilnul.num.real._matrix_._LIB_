using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.num.real.expr_.Algebraic;


namespace nilnul.num.real.matrix_.sq_.antim.of_
{
	static public class _UpperX
	{
		/// <summary>
		/// populate the lower with the upper value;
		/// the diagonal is set to 0.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="m"></param>
		static public void OfStrictUpper(ref Q4[,] m) {
			int height = m.GetLength(0);
			for (int i = 0; i < height; i++) {
				
				for (int j = 0; j < i; j++)
				{
					m[i, j] = -m[ j,i];
				}
				m[i, i]=0;	///default would be null

			}

		}
	}
}
