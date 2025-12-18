using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.toeplitz_.circulant_
{
	static public class _ColwiseX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _ToCirculant_0col1st(in Q4[] row)
		{
			return nilnul.obj.matrix_.sq_.toeplitz_.circulant_._ColwiseX._ToCirculant_0col1st(in row);
	
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _ToCirculant_0col1st(in IEnumerable< Q4> row)
		{
			
			return _ToCirculant_0col1st(row.ToArray());

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int[,] _ToCirculant_0col1st(IEnumerable<int> row)
		{
			return nilnul.obj.matrix_.sq_.toeplitz_.circulant_._ColwiseX._ToCirculant_0col1st(in row);

		}
	}
}
