using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.be_.colly_
{
	static public class _IndependentX
	{

		/// <summary>
		/// try to make the matrix <see cref="num.real.matrix_.trape_.right_.colly_.IDrape"/> to see.
		/// eg:
		///		[1,0,1,0,2]
		///		[0,0,1,0,2]
		///	=> false
		///	;
		///	
		///	
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// 0*0 => it's invertible, hence it's independent. It means no vec in a 0d space;
		/// 0*1 => false 
		/// 
		/// </returns>
		static public bool IsIndependent(ref Q[,] m)
		{

			var h = m.GetLength(0);

			var w = m.GetLength(1);
			if (w>h)
			{
				return false;
			}
			var rank = 0;

			for (var c = 0; c < w; c++)
			{
				for (var r = rank; r < h; r++)
				{
					Q head = m[r, c];
					if (head != 0)
					{
						op_._indent._GaussGramX._Swap(ref m, rank, r);  /// might be the same row; to make the row move upward.

						op_._indent._GaussGramX._Shed_2divisor(ref m, rank, head); /// make it <see cref="num.real.vec_.IStd"/>

																				   /// make all other rows 0
																				   ///

						for (var remained = r + 1; remained < h; remained++)
						{
							Q pivotCurrent = m[remained, c];
							//if (toCancel != 0)
							//{
							op_._indent._GaussGramX._Skew_12row_3nilish(
								ref m
								,
								remained
								, rank,
								-pivotCurrent                               // /head  =1
							);   ///<see cref="nilnul.num.real.matrix.op_."/>
							//}
						}
						rank++;
						break;
					}
				} /// if one col is all 0s after the row at the rank, the col can be linearly combinated by previous columns.
				if (rank <=c)
				{
					return false;
				}
			}
			return true;
		}


		static public bool IsIndependent(Q[,] m)
		{
			var c = (Q[,])m.Clone();
			return IsIndependent(ref c);

		}




	}
}
