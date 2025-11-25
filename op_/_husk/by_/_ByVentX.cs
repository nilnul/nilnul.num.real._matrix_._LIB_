using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.op_._husk_.by_
{
	static public class _ByVentX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// a matrix represents the kernel.
		/// 
		/// a kernel can be n*0, which is <see cref="real.matrix_.IVacant"/>
		/// </returns>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Husk(
			 ref Q[,] matrix
		) {


			/// for the free vars: take canonical form
			/// 

			/// get the kernel:
			/// 
			/// <see cref="num.real.matrix.op_.IKernel"/>

			nilnul.num.real.matrix.op_.dent_.echelon_._VentX.Vent(ref matrix);

			return nilnul.num.real.matrix_.vent.to_._HuskX._Kernel_0vent(
				 matrix
			);

		}
		static public Q[,] Husk(
			  Q[,] matrix
		) {


			var c = (Q[,]) matrix.Clone();

			return Husk(ref c);

		}



	}





}
