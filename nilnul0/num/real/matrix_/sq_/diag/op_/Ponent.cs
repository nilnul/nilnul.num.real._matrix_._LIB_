using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag.op_
{
	static public class _PonentX
	{

		static public void OfDiagonal(double[] diagonal, int ponent) {
			for (int i = 0; i < diagonal.Length; i++)
			{
				diagonal[i] = Math.Pow(diagonal[i],ponent);

			}
		}
	}
}
