using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_.shuffle_
{
	/// <summary>
	/// rowise swap
	/// </summary>
	static public class _ByShearX
	{

		static public void _Shuffle_assumeValid(
			in double[,] m
			,
			in int r
			,
			in int r1
		) {

			///first we sum the two
			///


			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, 1);
			/// now the first row is the sum.

			///we change the second row
			///
			/// the second row is the old first row's neg

			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r1, in r, -1);

			/// now the second row is the old first row

			rowwise_._ScaleX._Scale_rowAssumeIn_ratioAssumeNonnil(in m, in r1,  -1);

			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, -1);


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


			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, 1);
			/// now the first row is the sum.

			///we change the second row
			///
			/// the second row is the old first row's neg

			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r1, in r, -1);

			/// now the second row is the old first row

			rowwise_._ScaleX._Scale_rowAssumeIn_ratioAssumeNonnil(in m, in r1,  -1);

			rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(in m, in r, in r1, -1);


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
