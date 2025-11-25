using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent.op_._std
{

	/// <summary>
	///  shuffle by 
	///  move unnil cols left;
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="matrix_.sq.grid_.triag_.ISkew"/>
	/// 
	static public class _LeftwardX
	{
		/// <summary>
		/// change the matrix, M, to M';
		/// return the colwise shuffler: S
		/// ,such that:
		///		MS = M'
		///		,where M is the input
		///		, S is the returned
		/// 
		/// </summary>
		/// <param name="vent">
		/// would be shuffled such that the core is moved to the left;
		/// </param>
		/// <param name="rank"></param>
		/// <returns>
		/// </returns>
		static public Q4[,] _LeftwardForRank_0vent(ref Q[,] vent, out int rank) {
			///shuffle
			///
			var w = vent.GetLength(1);
			int h = vent.GetLength(0);

			var s = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(
				w
			);

			for (int i = 0; i < h ; i++)
			{
				/// get the pivot
				/// 
				int j = 0;
				for (; j < w; j++)
				{
					if (vent[i,j]!=0)
					{
						break;
					}
				}
				if (j==w)
				{
					rank = i;
					return s;
				}

				/// 
				nilnul.obj.matrix.op_.swap_._ColwiseX._Swap_12col(
					ref vent, j,i
				);
				nilnul.obj.matrix.op_._SwapX._Swap_12row(
					ref s, j,i
				);
			}
			rank =h;
			return s;

		
		}
	}
}
