using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str.re_.equisize_
{
	[Obsolete(nameof(matrix.vec.re_._MultibleComponentwiseX))]
	static public class _MultibleComponentwiseX
	{
		/// <summary>
		/// if the two str are not equisize, returns false;
		/// 
		/// this doesnot guarantee that row is equihigh, or col is equiwide
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>
		///


		//[Obsolete(nameof(_Be_1equisize))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Re<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {
			return row
				.Select(
					x => x.GetLength(1)
				)
				.SequenceEqual(
					col
					.Select(y => y.GetLength(0))
				
				) 
;
//			return _Be_1equisize(row, col);
//;
		}

		[Obsolete(nameof(real.matrix.vec.re_._MultibleComponentwiseX._Re_1equisize))]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Re_1equisize<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col)
		{
			return row.Zip(col, obj.matrix.re_._MultibleX.Re  ).All(x=>x)
;
		}

	}
}
