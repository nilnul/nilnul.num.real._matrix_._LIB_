using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_
{
	/// <summary>
	/// rowwise scale
	/// </summary>
	static public class _ScaleX
	{
		static public void _Scale_rowAssumeIn_ratioAssumeNonnil(in double[,] m, in int r,in double   multiplier) {

			for (int col = 0; col < m.GetLength(1); col++)
			{
				m[r, col] *= multiplier;
			}
		}

		static public void _Scale_rowAssumeIn_ratioAssumeNonnil(in int[,] m, in int r,in int   multiplier) {

			for (int col = 0; col < m.GetLength(1); col++)
			{
				m[r, col] *= multiplier;
			}
		}
	
	}
}
