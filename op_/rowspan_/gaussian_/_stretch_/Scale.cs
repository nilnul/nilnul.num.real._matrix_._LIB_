using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_
{
	/// <summary>
	/// rowwise scale by a nonnil factor.
	/// </summary>
	static public class _ScaleX
	{
		static public void _Scale_rowAssumeIn_ratioAssumeNonnil(in double[,] m, in int r,in double   multiplier) {

			int cols = m.GetLength(1);
			for (int col = 0; col < cols; col++)
			{
				m[r, col] *= multiplier;
			}
		}

		static public void _Scale_rowAssumeIn_ratioAssumeNonnil(in int[,] m, in int r,in int   multiplier) {

			int cols = m.GetLength(1);
			for (int col = 0; col < cols; col++)
			{
				m[r, col] *= multiplier;
			}
		}
	
	}
}
