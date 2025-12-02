using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq_.invertible.op_._invert_.by_
{

		[Obsolete(nameof(_ByRatioX) + " is more efficient")]	/// but in abgebra, this is necessary, as <see cref="_ByRatioX"/> wouldnot work for abgebra;
	static public class _ByAdjugateX
	{


		/// <summary>
		/// A\ = A*  / |A|
		/// </summary>
		/// <param name="nonsinglularSqMatrix"></param>
		/// <returns></returns>
		/// 
		[Obsolete(nameof(_ByRatioX) + " is more efficient")]	/// but in abgebra, this is necessary, as <see cref="_ByRatioX"/> wouldnot work for abgebra;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q4[,] _Inverse_0invertible(this Q4[,] nonsinglularSqMatrix) {


			return num.real.matrix.op_._ShrinkX.ShrinkAsNew(
				real.matrix_.sq.op_._AdjugateX._Adjugate_0equilat(nonsinglularSqMatrix)
				,

				real.matrix_.sq._DeterminantX._Determinant_0sq(nonsinglularSqMatrix)

			);
		}

		
	}
}
