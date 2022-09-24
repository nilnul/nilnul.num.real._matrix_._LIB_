using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.secondary_.canonic
{
	static public class _RevolveX
	{
		static public double[,] Revolved() {
			var created = secondary_._CanonicX.Canonic();
			nilnul.obj.matrix.op_.unary_.revolve_.rowwise_._DownwardX._Vod_assumeRowsPositive(created);
			return created;
		}
	}
}
