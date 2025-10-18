using nilnul.num.real.stream_.slider._series_._nextAugend_;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.pred_.linear_.col_.equat._slv_.by_
{
	static public class _ByRowReductionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="canon">
		///  the augmented matrix
		/// </param>
		/// <returns>
		/// null when the slv is empty;
		/// 
		///		.subspaces: colwise
		/// </returns>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[] drift, Q[,] husk)? _Solve_0canon(
			 Q[,] canon
		)
		{


			var wide = canon.GetLength(1);
			var wideMinus = wide -1;



			/// zero rows (0=0) are removed.
			/// 
			int high = canon.GetLength(0);
			/// zero rows (0=0) are removed.
			/// 
			if (high ==0)
			{

				return (
					nilnul.num.real.vec_._NaughtX._Quotients_0arity(wideMinus) /// actually any one would make the slv equivalent
					,
					nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(
					wideMinus
				));
			}

			var highMinus = high - 1;

			var pivotOfLstRow = nilnul.num.real.matrix.row._PivotX.Pivot(
				ref canon, highMinus
			);

			if (pivotOfLstRow == wideMinus)
			{
				/// 0 =1
				/// 
				return null;
			}


			var pivotOf1stRow = nilnul.num.real.matrix.row._PivotX.Pivot(
				ref canon, 0
			);

			/// get the drift:
			/// 

			var drift = new Q[
				wideMinus
			];

			int i = 0;



			for (int j = 0; j < high; j++)
			{
				var p = nilnul.num.real.matrix.row._PivotX.Pivot(
					ref canon, j
				);

				while (i< p)
				{
					drift[i++] = 0;
				}

				drift[i++] = canon[j, wideMinus];
			}

			while (i< wideMinus)
			{
				drift[i++] = 0;
			}



			/// now get the homo slv:
			/// 

			return (
				drift
				,
				 nilnul.num.real.matrix_.canon.op_._KernelX._Kernel_0canon(
				nilnul.num.real.matrix_.fat.to_._RemoveLastColumnX._RemoveLastColumn_0fat(canon)
			)
			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="augmented"></param>
		/// <returns>
		///  .subspace, the <see cref="matrix.cols.ILinearCombinate"/>
		/// </returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[] drift, Q[,] husk)? Solve(
			 Q[,] augmented
		)
		{

			return _Solve_0canon(nilnul.num.real.matrix.op_._canon_.by_._GaussianX.ToCanonical(augmented));


		}

	}





}
