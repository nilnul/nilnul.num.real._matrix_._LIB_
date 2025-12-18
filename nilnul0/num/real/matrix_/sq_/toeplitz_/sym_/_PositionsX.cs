using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.toeplitz_.sym_
{
	/// <summary>
	/// [
	///		1,2,3,...,n
	///		2,1,2,...,n-1
	///		3,2,1,...,n-2
	///		...
	///		n,n-1,n-2,...,1
	/// ]
	/// , note where each row is NOT a right shift of the previous row., a shuffle.
	/// </summary>
	static public class _PositionsX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int[,] Generate(int n)
		{
			return nilnul.num.real.matrix_.sq_.toeplitz_._SymmetricX.ToSymmetric_0tracts(
				Enumerable.Range(1, n)
			);
		}
	}
}
