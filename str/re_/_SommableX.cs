using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str.re_
{
	[Obsolete(nameof(matrix.vec.re_._SommableX))]
	static public class _SommableX
	{
		/// <summary>
		/// <see cref="real.vec.compart.str.co._MultiX"/>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="row">
		/// unihigh
		/// </param>
		/// <param name="col">
		/// uniwide
		/// 
		///  rows of <paramref name="col"/> is partitioned using the same <see cref="nilnul.num.IStr"/> as cols of<paramref name="row"/>. see code.
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

				str.re_.equisize_._MultibleComponentwiseX.Re(row,col)
			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Re_1equisize<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {

			return real.matrix.vec.re_._SommableX._Re_1equisize(row, col);

			//return
			//	nilnul.obj.matrix.str.be_._UnihighX.IsUnihigh(row) //this is a partition of a row
			//	&&
			//	nilnul.obj.matrix.str.be_._UniwideX.IsUniwide(col)  // this is a partition of a col
			//	&&

			//	str.re_.equisize_._MultibleComponentwiseX._Re_1equisize(row,col)
			//;
		}


	}
}
