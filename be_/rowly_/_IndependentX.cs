using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.be_.rowly_
{
	static public class _IndependentX
	{

		/// <summary>
		/// try to make this <see cref="real.matrix_.trape_.left_.rowwise_.ITerrace"/>, and see if the rows are independent.
		/// 
		/// eg:
		///		[1,0,1,0,2]
		///		[0,0,1,0,2]
		///	=> true
		///	;
		///	
		///	
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// 0*0 => it's invertible, hence it's independent. It means no vec in a 0d space;
		/// 0*1 => true
		/// 1*0 => false;
		/// 
		/// </returns>
		static public bool IsIndependent(ref Q[,] m)
		{

			var h = m.GetLength(0);
			var w = m.GetLength(1);
			if (h > w) { return false; }
			var rank = 0;

			/// h lt w
			for (var r = 0; r < h; r++)
			{
				for (var c = rank; c < w; c++)
				{
					Q head = m[r,c];
					if (head != 0)
					{
						op_.colwise_.shuffle_._Swap0nopX._Swap0nop(ref m, rank, c);  /// might be the same row; to make the row move upward.

						op_.basic_.shed_.colwise_._ByDivideX._Shed_2divisor(ref m, rank, head); /// make it <see cref="num.real.vec_.IStd"/>

																				   /// make all following cels 0
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
				if (rank <=r)
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
