using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.tro.bi_
{
	/// <summary>
	/// [
	///		i,j,k
	///		a,b,c
	///		a1,b1,c1
	/// ].Determinant
	/// , where i,j,k can be regarded as quaternion virtuals.
	/// 
	/// </summary>
	static public class _CrossX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c) Cross(
			(double a, double b, double c) x
			,
			(double a, double b, double c) y

		) {
			return (
				nilnul.num.real.matrix_.sq_._SecondaryX.Determinant(x.b,x.c,y.b,y.c)
				,
				-nilnul.num.real.matrix_.sq_._SecondaryX.Determinant(x.a,x.c,y.a,y.c)
				,
				nilnul.num.real.matrix_.sq_._SecondaryX.Determinant(x.a,x.b,y.a,y.b)

			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (Q a, Q b, Q c) Cross(
			(Q a, Q b, Q c) x
			,
			(Q a, Q b, Q c) y

		) {
			return (
				nilnul.num.real.matrix_.sq_.ii._DeterminantX.Determinant(x.b,x.c,y.b,y.c)
				,
				-nilnul.num.real.matrix_.sq_.ii._DeterminantX.Determinant(x.a,x.c,y.a,y.c)
				,
				nilnul.num.real.matrix_.sq_.ii._DeterminantX.Determinant(x.a,x.b,y.a,y.b)

			);
		}

	}
}
