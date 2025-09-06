using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		multible
	static public class _MultibleComponentwiseX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Re_1equisize<T>(IEnumerable<T[,]> a, IEnumerable<T[,]> b)
		{
			return a.Zip(
				b
				,
				//(x,y) =>
				obj.matrix.re_._MultibleX.Re
			//(x,y)
			).All(
				x => x
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>

		//[Obsolete(nameof(str.re_.equisize_._MultibleComponentwiseX.Re))]

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Re<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col)
		{
			return row.Select(
					x => x.GetLength(1)
				).SequenceEqual(
					col.Select(y => y.GetLength(0))

				)
			;
		}

	}
}
