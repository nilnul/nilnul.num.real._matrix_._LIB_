using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.bi_
{
	/// <summary>
	///  [
	///		i,j
	///		a,b
	///	 ].Determinant
	///	 = bi -aj
	///	 ,which is (b, -a)
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	static public class _CrossX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b) Cross(
			double a, double b

		) {
			return (
				b/// still keep the first positive. as in [i,j; a,b], the first one is always positive.
				
				,-a

			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q a, Q b) Cross(
			Q a, Q b

		) {
			return (
				b,-a

			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b) Cross(
			(double a, double b) x

		) {
			return Cross (
				x.a,x.b

			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q a, Q b) Cross(
			(Q a, Q b) x

		) {
			return Cross(
				x.a,x.b

			);
		}

	}
}
