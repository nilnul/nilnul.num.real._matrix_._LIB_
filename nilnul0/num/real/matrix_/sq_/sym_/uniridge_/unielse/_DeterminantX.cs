using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.sym_.uniridge_.unielse
{
	///该行列式的行和与列和都相等，此类行列式常将各列（行）加到第一列（行），再提取公因式，然后利用行列式性质化成三角形行列式计算。
	///<summary>
	/// 
	/// </summary>
	/// <see cref="sq.calc_.binary_.dif_.IIsorowScaler"/>
	static public class _DeterminantX
	{
		static public Q Determinant(int wide, Q ridge, Q other) {
			if (wide == 0) { return 1; }

			var dif = ridge -other;

			return (dif + wide*other) 
				* nilnul.num.quotient.op_._PonentX._Quotient_1natural(
					dif, wide-1
				);
		}
	}
}
