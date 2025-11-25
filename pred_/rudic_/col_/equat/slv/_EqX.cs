using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using S = (Q[] drift, Q[,] husk)?;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat.slv
{
	/// <summary>
	/// check to see whether two slts are equal;
	/// </summary>
	static public class _EqX
	{
		static public bool Eq(
			(Q[] drift, Q[,] husk)? a
			,
			(Q[] drift, Q[,] husk)? b=null
		)
		{
			if (a is null)
			{
				return b is null;
			}
			if (b is null)
			{
				return false;
			}

			///  eg: x+y =1, which is the solvent of :
			///		x+y =1.
			///		it can be represented as:
			///			(1/2, 1/2) + c(-1,1)
			///		or (0,1) + c(-1,1)
			///		; nontheless:
			///			(1/2, 1/2) - (0,1) = 1/2, -1/2
			///			is in the c(-1,1) 
			///			

			var d = 
				///nilnul.num.quotient.vec. 
				nilnul.num.real.vec.bi_._MinusX._Minus_1equisize(
				
				a.Value.drift , b.Value.drift
			)
				//.ToArray()
				;


			var inSpace = nilnul.num.quotient.matrix.husk._HasX._Has_1equihigh(
				a.Value.husk
				,
				d
			);

			return 
			//	nilnul.num.real.vec._Eq_assumeIsosize.Unison.Equals(
			//	a.Value.drift, b.Value.drift
			//)
				inSpace
				&& num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
					a.Value.husk, b.Value.husk
				)


				;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Eq(
			(Q[] drift, Q[,] husk)? a
			,
			Q[] drift
		)
		{
			return a is null
				? false
				: nilnul.num.real.vec._Eq_assumeIsosize.Unison.Equals(
					a.Value.drift, drift
				)
				&&
				a.Value.husk.GetLength(1) == 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="slv">slv for <see cref="matrix.pred_.rudic_.homo_.col_.IEquation"/></param>
		/// <param name="value"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Eq(Q4[,] slv, Q[] value)
		{
			return num.real.matrix.cols.re_._equihull_.by_._ByTransposeX.Re(
				   slv, num.real.matrix_._ColX.OfCol(value)
			   );
		}
	}
}
