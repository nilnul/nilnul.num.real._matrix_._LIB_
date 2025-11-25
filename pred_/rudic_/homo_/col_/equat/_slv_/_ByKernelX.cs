using nilnul.num.real.stream_.slider._series_._nextAugend_;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.pred_.rudic_.homo_.col_.equat._slv_.by_
{
	static public class _ByKernelX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="canon">
		/// </param>
		/// <returns>
		/// </returns>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Solve_0canon(
			 Q[,] canon
		)
		{

			/// now get the homo slv:
			/// 

			return
				 nilnul.num.real.matrix_.vent_.indep.to_._KernelX._Kernel_0indepVent(
				(canon)

			);

		}

		/// <summary>
		/// AX = b
		///		,where b is <see cref="matrix_.ICol"/>
		/// </summary>
		/// <param name="amplifier">
		/// 
		/// </param>
		/// <returns>
		/// </returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Solve(
			 Q[,] amplifier
		)
		{

			return _Solve_0canon(nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(amplifier));


		}

	}





}
