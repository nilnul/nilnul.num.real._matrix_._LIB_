//using nilnul.obj.matrix;
using static nilnul.obj.matrix._RowsX;
using System.Collections.Generic;
using System.Linq;
using nilnul.obj.matrix;
using System.Runtime.CompilerServices;
//using nilnul.obj.matrix;

namespace nilnul.num.real.matrix_.canon.op_
{
	static public class _KernelX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="canon">
		/// <see cref="num.real.matrix_.ICanon"/>
		/// </param>
		/// <returns></returns>
		static public IEnumerable<Q[]> _KernelAsVecs_0canon(Q[,] canon)
		{
			var cols = canon.GetLength(1);
			var rows = canon.GetLength(0);

			/// eg: the canon?
			/// 0, 1, 0,0,0,0,1
			/// 0, 0, 0,1,0,0,1
			/// 0, 0, 0,0,1,0,1
			/// 

			/// we need to iterate the free cols, for this eg: 4
			/// , solve the core/bound cols by noncoreCols that is iterated from 4*4 canonical rows;
			/// 


			var bind = new int[rows];

			int b = 0;
			var c00 = 0;

coreCols1:

			while (b < rows)
			{

				for (; ; c00++)
				{
					for (var r000 = 0; r000<rows; r000++)
					{
						if (canon[r000, c00] !=0)
						{
							//nonCoreCols[i] =c00;
							bind[b] = c00;
							b++;
							c00++;
							goto coreCols1;
						}
					}
				}


			}

			var freeCols = Enumerable.Range(0, cols).Except(bind).ToArray
();
			int free = cols-rows;
			//nilnul.num.real.matrix_.sq_.canon._RowsX._Rows8int_0wide(
			//	free

			//);

			//IEnumerable<Q> f()
			//{
			//	for (int i = 0; i < free; i++)
			//	{
			//		yield return slv[
			//			coreCols[i]
			//		];
			//	}
			//}
			IEnumerable<Q> frees(IEnumerator<Q> iter)
			{
				int j = 0;
				for (int i = 0; i < free; i++)
				{
					int core = freeCols[i];

					for (; j <=core; j++)
					{
						iter.MoveNext();

					}

					yield return iter.Current;
				}

			}
			IEnumerable<Q> frees1(Q[] slv)
			{
				return frees(
					(
						(IEnumerable<Q>)
						slv
					)
					.GetEnumerator());
			}
			/// 1,0,0,0
			/// 0,1,0,0
			/// ...
			/// ...
			/// 
			for (int f0 = 0; f0 < free; f0++)
			{


				var slv = new Q[cols];

				int i00 = 0;
				while ( i00 < f0)
				{
					slv[
						freeCols[
							i00++
						]
					] =0;
				}

				slv[
					freeCols[
							i00++
						]
				] =1;

				while ( i00 < free)
				{
					slv[
						freeCols[
							i00++
						]
					] =0;
				}
				///  :the free part filled
				///  

				var frees5slv = frees1(slv).ToArray();	/// while not null

				//var r = 0;
				for (int r = 0; r < rows; r++)
				{

				


					slv[
						bind[r]	
					] = -nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(
							frees5slv
							,
							frees(
								nilnul.obj.matrix._RowsX.Row(
									canon, r
								).GetEnumerator()
							)
						)
					;
					
				}

				yield return slv;
			}

		}

		/// <summary>
		/// we need the result, R, in frees5slv way such that:
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
		static public Q[,] _Kernel_0canon(Q[,] canon)
		{
			return nilnul.obj.matrix.of_._OfColsX._OfCols_0high(
				canon.GetLength(1)
				,
				_KernelAsVecs_0canon(canon)
			);
		}


	}
}
