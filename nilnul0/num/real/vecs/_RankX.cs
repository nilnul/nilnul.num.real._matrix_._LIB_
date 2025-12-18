using M = System.Collections.Generic.List<nilnul.num.quotient_.DenomNonnil[]>;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.vecs
{
	/// <see cref="num.quotient.matrix.IRank"/>
	/// <see cref="num.real.vecs.IRank"/>
	/// 
	/// <summary>
	/// as <see cref="real.matrix.rows.IRank"/> = <see cref="real.matrix.cols.IRank"/>
	/// , here we use <see cref="real.matrix.rows.IRank"/>, as matrix is row major:<see cref="obj.matrix.be_.IRowMajor"/>
	/// </summary>
	static public class _RankX
	{
		static public int Rank(ref M m)
		{
			///<see cref="num.real.matrix.be_.rowly_._IndependentX"/>
			/// <see cref="num.real.matrix.op_.dent_._EchelonX.EchelonForRank(ref M)"/>

			var h = m.Count;
			if (h == 0) return 0;

			var w = m[0].Length;
			var rank = 0; /// initially, the dimensions count is 0;

			for (var r = 0; r < h; r++)
			{
				for (var c = rank; c < w; c++)
				{
					Q head = m[r][ c];
					if (head != 0)
					{
						obj.co.op_._ConverseX.Converse(m, rank,c);

						
						op_.basic_.shed_.colwise_._ByDivideX._Shed_2divisor(ref m, rank, head); /// make it <see cref="num.real.vec_.IStd"/>

																								/// make all following cels in the row to be 0
																								///

						for (var remained = c + 1; remained < w; remained++)
						{
							Q pivotCurrent = m[r, remained];

							op_.basic_.skew_.colwise_._BySubtractX._Skew_12col_3nilish(
								ref m
								,
								remained
								, rank,
								pivotCurrent                               // /head  =1
							);
						}
						rank++;
						break;
					}
				} /// if one row is all 0s after the col at the rank, the row can be linearly combinated by previous rows.
		
			}
			return rank;
		}


		static public int Rank(Q[,] m)
		{
			var c = (Q[,])m.Clone();
			return Rank(ref c);

		}




	}
}
