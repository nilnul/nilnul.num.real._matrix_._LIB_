using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.toeplitz_
{
	static public class _SymmetricX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] ToSymmetric_0tracts(in Q4[] row)
		{
			return nilnul.obj.matrix_.sq_.toeplitz_._SymmetricX._ToSymmetricToeplitz_0row1st(in row);
	
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] ToSymmetric_0tracts(in IEnumerable< Q4> row)
		{
			
			return ToSymmetric_0tracts(row.ToArray());

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int[,] ToSymmetric_0tracts(IEnumerable<int> row)
		{
			return nilnul.obj.matrix_.sq_.toeplitz_._SymmetricX._ToSymmetricToeplitz_0row1st(in row);

		}
	}
}
