using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.canon.elementary_
{
	static public class _ScaledX
	{
		static public double[,] _Generate_assumeValid(int size, int i, double _nonnil) {
			var r = square_.Canonic.Create(size);
			 real.matrix.op_.unary_.elementary_.rowwise_._ScaleX._Scale_rowAssumeIn_ratioAssumeNonnil(in r, in i, in _nonnil);
			return r;

		}
	}
}
