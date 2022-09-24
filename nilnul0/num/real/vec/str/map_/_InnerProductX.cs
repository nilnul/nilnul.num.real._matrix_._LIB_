using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.str.map_
{
	///
	/// <see cref="num.real.vec.str.co."/>
	///<summary>
	///regard the right matrix as col major, thus a str of vecs in the form of cols
	/// </summary>
	/// alias:
	///		vecs1vecs
	///		vecs9vecs
	///		vecs2vecs
	///		vecs5vecs
	///			where 5 means vs.
	///		vecs7vecs
	///			whre 7 means vs or serving
	///		by cartesian product
	///		by split
	///vs: <see cref="str.accumulate_._LinearCombinateX"/>

	static public class _InnerProductX
	{



		/// <summary>
		/// this is different from <see cref="real.vec.str._LinearCombinateX"/> in that the <paramref name="col"/>'s size equal to the component's , not the whole's, of the <paramref name="_rows"/>
		/// </summary>
		/// <param name="col">
		/// eg:
		///		1
		///		2
		///		3
		/// </param>
		/// <param name="_rows"></param>
		/// <returns>
		///return a col
		/// </returns>
		/// <see cref="num.real.vec.str._LinearCombinateX"/>
		static public IEnumerable<double> _MultiAsCol_rowAssumeEquisize2col(
			IEnumerable<IEnumerable<double>> _rows
			,
			IEnumerable<double> col
		)
		{
			return _rows.Select(
				y => num.real.str.co_.sameLen._InnerProductX._Eval(col, y)
			);
		}

		/// <summary>
		/// return a row.
		/// </summary>
		/// <param name="row"></param>
		/// <param name="_cols_eachAssumeEquisize2row"></param>
		/// <returns></returns>
		/// <see cref="num.real.vec.str._LinearCombinateX"/>

		static public IEnumerable<double> _MultiAsRow_colAssumeEquisize2row(
			IEnumerable<double> row
			,
			IEnumerable<IEnumerable<double>> _cols_eachAssumeEquisize2row
		)
		{

			/// as that one  puts matrix in the form of rows, not cols, consistent with matrix definition.
			return _MultiAsCol_rowAssumeEquisize2col(_cols_eachAssumeEquisize2row, row);

		}

	
	}
}
