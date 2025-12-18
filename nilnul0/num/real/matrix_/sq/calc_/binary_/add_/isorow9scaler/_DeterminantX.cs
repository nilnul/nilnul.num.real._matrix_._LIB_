using nilnul.num.quotient.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.calc_.binary_.add_.isorow9scaler
{
	///该行列式的行和与列和都相等，此类行列式常将各列（行）加到第一列（行），再提取公因式，然后利用行列式性质化成三角形行列式计算。
	///<see cref="sq_.sym_.uniridge_.unielse._DeterminantX"/>
	///<summary>
	/// A+B
	///		,where A is <see cref="real.matrix_.IRank8unplura"/>
	///		B is <see cref="real.matrix_.sq_.IScaler"/>
	///	;
	///	eg:
	///		[	0,2,3
	///			1,1,3
	///			1,2,2
	///		]
	///		
	///		
	/// </summary>
	/// <see cref="dif_.isorow9scaler._DeterminantX"/>
	static public class _DeterminantX
	{
		static public Q Determinant(Q[] row, Q scaler) {

			int wide = row.Length;
			if (wide ==0)
			{
				return 1;
			}

			return (row.Sum() + scaler)		/// sum all cols to the 1st col
				* nilnul.num.quotient.op_._PonentX._Quotient_1natural(
					scaler, wide-1		/// for any nonfirst row, r[i] -= r[0]
			)	/// for child matrix, 
				;
		}
	}
}
