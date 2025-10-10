using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.op_._kernel_.by_
{
	static public class _ByRowReductionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="coef"></param>
		/// <returns>
		/// a matrix represents the kernel.
		/// 
		/// a kernel can be n*0, which is <see cref="real.matrix_.IVacant"/>
		/// </returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Kernel(
			 Q[,] coef
		) {


			/// for the free vars: take canonical form
			/// 

			/// get the kernel:
			/// 
			/// <see cref="num.real.matrix.op_.IKernel"/>



			return nilnul.num.real.matrix_.canon.op_._KernelX._Kernel_0canon(
				nilnul.num.real.matrix.op_._canon_.by_._GaussianX.ToCanonical( coef)
			);

		}

	}





}
