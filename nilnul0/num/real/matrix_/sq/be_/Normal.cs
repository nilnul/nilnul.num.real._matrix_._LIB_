using nilnul.num.real.matrix.bi_;
using nilnul.obj.matrix.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.matrix;

namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	///  a square matrix is normal if it commutes with its transpose.
	/// </summary>
	static public class _NormalX
    {
		static public bool _Be_0square(Q[,] a) {
			var t =  nilnul.obj.matrix.op_._TransposeX.Transpose(a);
			

			return a._Multiply_1sociable(t).Eq(
				t._Multiply_1sociable(a)
			);

		}

	}
}
