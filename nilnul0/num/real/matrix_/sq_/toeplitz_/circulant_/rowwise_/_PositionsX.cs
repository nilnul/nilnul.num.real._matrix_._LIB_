using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.toeplitz_.circulant_.rowwise_
{
	/// <summary>
	/// [
	///		1,2,3,...,n
	///		n,1,2,...,n-1
	///		n-1,n,1,...,n-2
	///		...
	///		2,3,4,...n,1
	/// ]
	/// , note where each row is a right shift of the previous row., a shuffle.
	/// </summary>
	static public class _PositionsX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int[,] Generate(int n)
		{
			return nilnul.num.real.matrix_.sq_.toeplitz_.circulant_._RowwiseX._ToCirculant_0row1st(
				Enumerable.Range(1, n)
			);
		}
	}
}
