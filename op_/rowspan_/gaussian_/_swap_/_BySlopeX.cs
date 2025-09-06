using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_;

namespace nilnul.num.real.matrix.op_.rowspan_._swap_
{
	///	 While it seems like there are three elementary row operations, one of them is actually redundant.
	/// <summary>
	/// rowise swap
	/// </summary>
	static public class _BySlopeX
	{

		static public void _Shuffle_assumeValid(
			in double[,] m
			,
			in int a
			,
			in int b
		) {

			///first we sum the two
			///
			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in a, in b, 1);
			/// now the first row is the sum, making two rows:
			///  a+b, b
			/// 

			///we change the second row
			///
			/// the second row is the old first row's neg:

			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in b, in a, -1);
			/// :  a+b, b-(a+b) = -a 

			/// now the second row is the old first row:
			///
			_ScaleX._Scale_rowAssumeIn_ratioAssumeNonnil(in m, in b,  -1);
			//:  a+b, a


			/// the 1st row is the old 2nd row:
			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in a, in b, -1);
			/// :  a+b-a =b,a


		}


		static public void _Shuffle_assumeValid(
			in int[,] m
			,
			in int r
			,
			in int r1
		) {

			///first we sum the two
			///

			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, 1);
			/// now the first row is the sum.

			///we change the second row
			///
			/// the second row is the old first row's neg

			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r1, in r, -1);

			/// now the second row is the old first row

			_ScaleX._Scale_rowAssumeIn_ratioAssumeNonnil(in m, in r1,  -1);

			_SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, -1);


		}

		static public double[,] _New_assumeValid(in double[,] m, in int r, in int r1)
		{
			var cloned = real.matrix.op_.unary_._CloneX.Clone(m);

			_Shuffle_assumeValid(in cloned, in r, in r1);
			return cloned;
		}


		public static int[,] _New_assumeValid(int[,] m, int r, int r1)
		{
			var cloned = real.matrix.op_.unary_._CloneX.Clone(m);

			_Shuffle_assumeValid(in cloned, in r, in r1);
			return cloned;

		}

	}
}
