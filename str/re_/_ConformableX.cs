using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.str.re_
{
	static public class _ConformableX
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
		static public bool Be<T>(IEnumerable<T[,]> row, IEnumerable<T[,]> col) {

			return  str.co.be_.equisize_._ComponentwiseMultibleX.Be(row,col)
				&&

				nilnul.obj.matrix.str.be_._UnihighX.IsUnihigh(row) //this is a partition of a row
				&&
				nilnul.obj.matrix.str.be_._UniwideX.IsUniwide(col)  // this is a partition of a col
				
			;
		}
	}
}
