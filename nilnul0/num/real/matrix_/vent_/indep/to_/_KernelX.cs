//using nilnul.obj.matrix;
using nilnul.num.quotient.matrix.prop;
using nilnul.obj.matrix;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using static nilnul.obj.matrix._RowsX;
//using nilnul.obj.matrix;

namespace nilnul.num.real.matrix_.vent_.indep.to_
{
	/// <summary>
	/// the returned is also <see cref="matrix_.trape_.right_.colly_.drape_.IParagon"/>
	/// </summary>
	static public class _KernelX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="indepVent">
		/// <see cref="num.real.matrix_.ICanon"/>
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		static public IEnumerable<Q[]> _KernelAsVecs_0indepVent(Q[,] indepVent)
		{
			//return vent.to_._KernelX._Kernel_0vent(canon, canon.GetLength(0));

			var rows = indepVent.GetLength(0);
			var cols = indepVent.GetLength(1);

			/// eg: the indep vent?
			/// 0, 1, 2,0,0,3,1
			/// 0, 0, 0,1,0,0,1
			/// 0, 0, 0,0,1,0,1
			/// ,where col[0,2,5,6] are free cols, and they will be taken as the span of the kernel, as an embedded canonical in the kernel
			/// , note the resulted kernel is not indented, but a lower triag: step anymore:
			///		1	0		0	0		0	0	0
			///		0	-1/2	1	0		0	0	0
			///		0	-1/3	0	0		0	1	0
			///		0	-1		0	-1		-1	0	1
			///		,which is then transposed

			/// we need to iterate the free cols, for this eg: 4
			/// , solve the core/bound cols by noncoreCols that is iterated from 4*4 canonical rows;
			/// 


			var pivots = new int[rows]; /// <see cref="nilnul.num.real.matrix.row._PivotX"/>

			var c = 0;

			for (int r = 0; r < rows; r++)
			{
				while (indepVent[r, c] ==0)
				{
					c++;
				}
				pivots[r] = c;
				c++;
			}


			var unpivots = Enumerable.Range(0, cols).Except(pivots).ToArray
();
			int unpivotsCount = cols-rows;

			/// 1,0,0,0
			/// 0,1,0,0
			/// ...
			/// ...
			/// 
			for (int u = 0; u < unpivotsCount; u++)
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


				///  eg:
				///		[
				///			0,1,2,0,2
				///			0,0,0,1,1
				///		]
				///	;
				///	the slt is:
				///		1,0,0,0,0
				///		0,-2,1,0,0
				///		0,-1,0,-1,1
				///  

				for (int r = 0; r < rows; r++)
				{

					slt[
						pivots[r]
					]
					=
					-indepVent[r, unpivot]
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
		/// <param name="canon"></param>
		/// <returns>
		/// 
		/// </returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Kernel_0indepVent(Q[,] canon)
		{
			return nilnul.obj.matrix.of_._OfColsX._OfCols_0high(
				canon.GetLength(1)
				,
				_KernelAsVecs_0indepVent(canon)
			);
		}


	}
}
