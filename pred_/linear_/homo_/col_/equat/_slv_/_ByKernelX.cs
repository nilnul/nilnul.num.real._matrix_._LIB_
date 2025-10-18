using nilnul.num.real.stream_.slider._series_._nextAugend_;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.pred_.linear_.homo_.col_.equat._slv_.by_
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
				 nilnul.num.real.matrix_.canon.op_._KernelX._Kernel_0canon(
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

			return _Solve_0canon(nilnul.num.real.matrix.op_._canon_.by_._GaussianX.ToCanonical(amplifier));


		}

	}





}
