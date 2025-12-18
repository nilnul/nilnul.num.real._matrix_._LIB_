//using nilnul.obj.matrix;
using static nilnul.obj.matrix._RowsX;
using System.Collections.Generic;
using System.Linq;
using nilnul.obj.matrix;
using System.Runtime.CompilerServices;
//using nilnul.obj.matrix;

namespace nilnul.num.real.matrix_.vent.to_
{
	/// <summary>
	///  the resulted is independent <see cref="matrix_.trape_.right_.colly_.drape_.IParagon"/>
	/// 
	/// </summary>
	/// alias:
	///		kernel
	///		husk, 
	///			which implies no nil columns
	///			,hull of kernel, colwise
	///			
	/// <see cref="real.matrix.op_._kernel_.by_._ByRowReductionX"/>
	static public class _KernelX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vent">
		/// <see cref="num.real.matrix_.ICanon"/>
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		static public IEnumerable<Q[]> _Cols_0vent(Q[,] vent, int rank)
		{
			var cols = vent.GetLength(1);
			var rows = vent.GetLength(0);

			/// eg: the indep vent?
			/// 0, 1, 2,0,0,3,1
			/// 0, 0, 0,1,0,0,1
			/// 0, 0, 0,0,1,0,1
			/// 0, 0, 0,0,0,0,0
			/// 
			/// ,where col[0,2,5,6] are free cols, and they will be taken as the span of the kernel, as an embedded canonical in the kernel
			/// , note the resulted kernel is not indented, but a lower triag: step anymore:
			///		1	0		0	0		0	0	0
			///		0	-2		1	0		0	0	0
			///		0	-3		0	0		0	1	0
			///		0	-1		0	-1		-1	0	1
			///	,transposed
			/// , it will become 
			///		[
			///		1		0		0		0
			///		0		-2		-3		-1
			///		0		1		0		0
			///		0		0		0		-1
			///		0		0		0		-1
			///		0		0		1		0
			///		0		0		0		1
			///		,which is not dent, but colwise <see cref="real.matrix_.trape_.right_.drape_.IParagon"/> when from right to left.
			///		
			/// we need to iterate the free cols, for this eg: 4
			/// , solve the core/bound cols by noncoreCols that is iterated from 4*4 canonical rows;
			/// 


			var pivots = new int[rank]; /// the cols of chimneys; binded; pivots

			var c = 0;

			for (int r = 0; r < rank; r++)
			{
				while (vent[r, c] ==0)
				{
					c++;
				}
				pivots[r] = c;
				c++;
			}

			var unpivots = Enumerable.Range(0, cols).Except(pivots).ToArray
();
			int unpivotsCount = cols-rank;

	
			/// 1,0,0,0
			/// 0,1,0,0
			/// ...
			/// ...
			/// 
			for (int u = 0; u < unpivotsCount; u++)   /// the count of slns
			{
				int unpivot = unpivots[u];

				var slt = new Q[cols];

				int i00 = 0;

				while (i00 < u)
				{
					slt[
						unpivots[
							i00++
						]
					] =0;
				}

				slt[
					unpivot
				] =1;

				while (++i00 < unpivotsCount)
				{
					slt[
						unpivots[
							i00
						]
					] =0;
				}

				
				for (int r = 0; r < rank; r++)
				{

					slt[
						pivots[r]
					]
					= 
					-vent[r, unpivot]
					;
				}

				yield return slt;
			}

		}

		/// <summary>
		/// we need the result, R, in freesOfSlv way such that:
		///		CR = 0
		///	; hence, the height of R is the width of C, and the width of R is the <see cref="real.matrix_.indep.IFreedom"/> of C.
		///	
		/// </summary>
		/// <param name="vent"></param>
		/// <returns>
		/// 
		/// </returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Kernel_0vent( Q[,] vent, int rank)
		{
			return nilnul.obj.matrix.of_._OfColsX._OfCols_0high(
				vent.GetLength(1)
				,
				_Cols_0vent(vent,rank)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Kernel_0vent(Q[,] vent)
		{
			return _Kernel_0vent(vent,

				nilnul.num.real.matrix_.dent._RankX._Rank_0dent(in vent)
				
			);
		}
	}
}
