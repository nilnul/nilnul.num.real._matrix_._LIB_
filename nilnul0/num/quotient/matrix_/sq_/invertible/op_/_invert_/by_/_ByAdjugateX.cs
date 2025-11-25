using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq_.invertible.op_._invert_.by_
{
	static public class _ByAdjugateX
	{
		

		/// <summary>
		/// A\ = A*  / |A|
		/// </summary>
		/// <param name="nonsinglularSqMatrix"></param>
		/// <returns></returns>
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
