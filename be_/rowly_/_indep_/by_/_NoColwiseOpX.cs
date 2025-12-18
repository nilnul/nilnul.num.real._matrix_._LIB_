using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.real.matrix.be_.rowly_._indep_.by_
{
	static public class _NoColwiseOpX
	{

		/// <summary>
		/// try to make this <see cref="real.matrix_.trape_.right_.rowly_."/>, and see if the rows are independent.
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
			for (var c0 = 0; c0 < w; c0++)
			{
				for (var r = rank; r < h; r++)
				{
					Q head = m[r,c0];
					if (head != 0)
					{
						op_.rowwise_.shuffle_._Swap0nopX._Swap0nop(ref m, rank, r);  /// might be the same row; to make the row move upward.

						op_.basic_.shed_._ByDivideX._Shed_2divisor(ref m, rank, head); /// make it <see cref="num.real.vec_.IStd"/>

																				   /// make all following cels 0
																				   ///

						for (var remained = r + 1; remained < h; remained++)
						{
							Q pivotCurrent = m[ remained,c0];
							op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
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
				} 
			}
			return rank ==h;
		}


		static public bool IsIndependent(Q[,] m)
		{
			var c = (Q[,])m.Clone();
			return IsIndependent(ref c);

		}




	}
}
