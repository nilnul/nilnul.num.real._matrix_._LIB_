using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_
{
	/// <summary>
	/// merge another row timed by a coefficient. 
	/// </summary>
	/// alias:
	///		swallow
	///		shear
	///		transvection
	///		skew
	///		slant
	static public class _SlantX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="r"></param>
		/// <param name="row2swallow"></param>
		/// <param name="multiplier">can be nil, when this op is noop.</param>
		static public void _Act_rowAssumeIn_ratioAssumeNonnil(
			in double[,] m
			,
			in int r
			,
			in int row2swallow 
			,
			in double multiplier
		) {

			for (int col = 0; col < m.GetLength(1); col++)
			{
				m[r, col] += multiplier*m[ row2swallow,col];
			}
		}
		static public void _Act_rowAssumeIn_ratioAssumeNonnil(
			in int[,] m
			,
			in int r
			,
			in int row2swallow 
			,
			in int multiplier
		) {

			for (int col = 0; col < m.GetLength(1); col++)
			{
				m[r, col] += multiplier*m[ row2swallow,col];
			}
		}

		
	}
}
