using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.re_
{
	static public class _SommableX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="a">
		/// unihigh
		/// </param>
		/// <param name="b">
		/// uniwide
		/// 
		///  rows of <paramref name="b"/> is partitioned using the same <see cref="nilnul.num.IStr"/> as cols of<paramref name="a"/>. see code.
		///  
		/// </param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Re<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {

			return
				nilnul.obj.matrix.str.be_._UnihighX.IsUnihigh(row) //this is a partition of a row
				&&
				nilnul.obj.matrix.str.be_._UniwideX.IsUniwide(col)  // this is a partition of a col
				&&

				vec.re_._MultibleComponentwiseX.Re(row, col)
			;

			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Re_1equisize<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {

			return
				nilnul.obj.matrix.str.be_._UnihighX.IsUnihigh(row) //this is a partition of a row
				&&
				nilnul.obj.matrix.str.be_._UniwideX.IsUniwide(col)  // this is a partition of a col
				&&

				vec.re_._MultibleComponentwiseX._Re_1equisize(row, col)
			;

			;
		}

	}
}
