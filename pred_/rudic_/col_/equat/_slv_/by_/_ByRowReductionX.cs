using nilnul.num.real.stream_.slider._series_._nextAugend_;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat._slv_.by_
{
	/// <see cref="nilnul.num.co.op_.IModulo"/>
	/// <summary>
	/// <see cref="num.real.matrix.co.op_.div_.IQuota"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _ByRowReductionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="indepVent">
		///  the augmented matrix
		/// </param>
		/// <returns>
		/// null when the slv is empty;
		/// 
		///		.subspaces: colwise
		/// </returns>
		/// <see cref="num.real.matrix.co.op_.IDivide"/> 
		///		,where drift is the remainder. husk is the quotient. 
		///		,when it's null, that means the divisor is 0.
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[] drift, Q[,] husk)? _Solve_0indepVent(
			 Q[,] indepVent
		)
		{

			var wide = indepVent.GetLength(1);
			var wideMinus = wide -1;	/// de-augment



			/// 
			int high = indepVent.GetLength(0);
			/// zero rows (0=0) are removed.
			/// 
			if (high ==0)
			{

				return (
					nilnul.num.real.vec_._NaughtX._Quotients_0arity(wideMinus) /// actually any one would make the slv equivalent; but this is the simplest;
					,
					nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(
					wideMinus
				));
			}

			var highMinus = high - 1;

			var pivotOfLstRow = nilnul.num.real.matrix.row._PivotX.Pivot(
				in indepVent, highMinus
			);

			if (pivotOfLstRow == wideMinus)
			{
				/// 0 =1;
				/// 1/0, unsatisfiable;
				/// 
				return null;	/// alternatively, (null, vacant)
			}


			var pivotOf1stRow = nilnul.num.real.matrix.row._PivotX.Pivot(
				in indepVent, 0
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
					ref indepVent, j
				);

				while (i< p)
				{
					drift[i++] = 0;
				}

				drift[i++] = indepVent[j, wideMinus];
			}	

			while (i< wideMinus)
			{
				drift[i++] = 0;
			}///  eg:[0,0,2,0,5,0,0  ] 
				/// where the b is: [2,5]



			/// now get the homo slv:
			/// 

			return (
				drift
				,
				 nilnul.num.real.matrix_.vent_.indep.to_._KernelX._Kernel_0indepVent(
				nilnul.num.real.matrix_.fat.to_._RemoveLastColumnX._RemoveLastColumn_0fat(indepVent)	 /// it must be fat, as this is indepVent
			)
			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="augmented"></param>
		/// <returns>
		/// null if there is no solution.
		///  .subspace, the <see cref="matrix.cols.ILinearCombinate"/>
		/// </returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[] drift, Q[,] husk)? Solve(
			 Q[,] augmented
		)
		{

			return _Solve_0indepVent(nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(augmented));


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="coef"></param>
		/// <param name="rightHand"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q[] drift, Q[,] husk)? Solve(
			 Q[,] coef, Q[] rightHand
		)
		{

			return Solve(
				
					nilnul.obj.matrix_.isohigh.bi_._JuxtaposeX._Juxtapose_1isohighCol(coef, rightHand)
				
			);


		}


	}





}
