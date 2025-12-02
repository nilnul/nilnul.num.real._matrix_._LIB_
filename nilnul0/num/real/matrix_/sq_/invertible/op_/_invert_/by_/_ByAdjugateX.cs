using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.invertible.op_._invert_.by_
{
	/// <summary>
	/// get the adjugate, which is the matrix of cofactors, transposed;
	/// then divide that by determ^n;
	/// </summary>
	/// 
	[Obsolete(nameof(_ByRatioReduceX) + " is preferred as this involves too many determ computation, which is costly")]
	static public class _ByAdjugateX
	{
		

		/// <summary>
		/// A\ = A*  / |A|
		/// </summary>
		/// <param name="nonsinglularSqMatrix"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  Q[,] _Inverse_0invertible(this Q[,] nonsinglularSqMatrix) {

			return num.quotient.matrix_.sq_.invertible.op_._invert_.by_._ByAdjugateX._Inverse_0invertible( nonsinglularSqMatrix);

	
		}

		
	}
}
