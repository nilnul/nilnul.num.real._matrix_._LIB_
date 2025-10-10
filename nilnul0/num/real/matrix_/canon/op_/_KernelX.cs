//using nilnul.obj.matrix;
using static nilnul.obj.matrix._RowsX;
using System.Collections.Generic;
using System.Linq;
using nilnul.obj.matrix;
//using nilnul.obj.matrix;

namespace nilnul.num.real.matrix_.canon.op_
{
	static public class _KernelX {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="canon">
		/// <see cref="num.real.matrix_.ICanon"/>
		/// </param>
		/// <returns></returns>
		static public IEnumerable<Q[]> _KernelAsRows_0canon(Q[,] canon) {

			var cols = canon.GetLength(1);
			var rows = canon.GetLength(0);

			//var rows00000 = canon.Rows().Reverse().GetEnumerator();

			

			//var c = cols-rows;



			for (
				var pos =
				///cols
				rows
				/// regard the returned as cols, then we put it in reversed (from down up) canonical form
				
				;	
				pos <cols	///rows
				; 
				pos++
			) {
				//--i;
				/// eg:
				/// 1,0,0
				/// 0,1,0
				/// 0,0,1
				/// 

				var slv = new Q[cols];

				int k = cols; /// the latter part of the solution.
				//k--;

				//int oneIndex = rows+i;

				for (; k >pos;  )
				{
					slv[--k]=0;
				}

				slv[--k] =1;

				for (; k >rows; )
				{
					slv[--k]=0;
				}


				for (; k >0;)
				{

					var oldK = k;
					--k;
					//rows00000.MoveNext();

					slv[k] = - 
						nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(
							slv.Skip(oldK)
							,
							nilnul.obj.matrix._RowsX.Row(
								canon,k
							).Skip(oldK)
						)	
					;
				}

				yield return slv;
			}
		}

		/// <summary>
		/// we need the result, R, in a way such that:
		///		CR = 0
		///	; hence, the height of R is the width of C, and the width of R is the <see cref="real.matrix_.indep.IFreedom"/> of C.
		///	
		/// </summary>
		/// <param name="canon"></param>
		/// <returns>
		/// 
		/// </returns>
		static public Q[,] _Kernel_0canon(Q[,] canon) {

			var rows = canon.GetLength(0);
			var cols = canon.GetLength(1);

			//var rows00000 = canon.Rows().Reverse().GetEnumerator();

			int cS = cols-rows;

			var rowsPlus = rows+1;

			var o = new Q[cols, cS];
			//int c=0;
			for (
				int 
				c=0
				//,
				
				//r	/// the row in result
				//=
				//rows
				/// regard the returned as cols, then we put it in reversed (from down up) canonical form
				;
				c<cS
				//r <cols	
				; 
				//r++,
				c++
			) {
				/// eg: columnly
				/// 1,0,0
				/// 0,1,0
				/// 0,0,1
				/// 
				

				int k = cols; /// the latter part of the solution.
				//k--;

				//int oneIndex = rows+i;

				for (; k >rowsPlus+c;  )
				{
					o[--k, c] =0;
				}

				/// k =rowsPlus +c 
				o[--k, c] =1;  ///k =rows +c


				for (; k >rows; )
				{
					o[--k, c] =0;
				}


				for (; k >0;)
				{

					var oldK = k;
					--k;

					o[k, c] = - 
						nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(
							nilnul.obj.matrix._ColsX.Col(o,c).Skip(oldK)
							,
							nilnul.obj.matrix._RowsX.Row(
								canon,k
							).Skip(oldK)
						)	
					;
				}

				
			}
			return o;
		}


	}
}
