using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.cols
{
	static public class _RankX
	{

		/// <summary>
		/// eg:
		///		[1,0,1,0,2]
		///		[0,0,1,0,2]
		///	=> 2
		///	;
		///	
		///	
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// 0*0 => 0
		/// 0*1 => 0 
		/// 
		/// </returns>
		static public int Rank(ref Q[,] m)
		{

			var h = m.GetLength(0);
			var w = m.GetLength(1);

			var rank = 0;
			for (var c = 0; c < w; c++)
			{
				for (var r = rank; r < h; r++)
				{
					Q head = m[r, c];
					if (head != 0)
					{
						real.matrix.op_.rowwise_.shuffle_._Swap0nopX._Swap0nop(ref m, rank, r);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(ref m, rank, head); /// make it <see cref="num.real.vec_.IStd"/>

																				   /// make all other rows 0
																				   ///

						for (var remained = r + 1; remained < h; remained++)
						{
							var pivotCurrent = m[remained, c];
							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m
								,
								remained
								, rank,
								pivotCurrent
							);   ///<see cref="nilnul.num.real.matrix.op_."/>
						}
						rank++;
						break;
					}
				} /// if one col is all 0s after the row at the rank, the col can be linearly combinated by previous columns.
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