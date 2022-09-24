using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.tertiary_.canonic
{
	static public class _RevolveX
	{
		static public double[,] RevolvedDownward() {
			var created = tertiary_._CanonicX.Canonic();
			nilnul.obj.matrix.op_.unary_.revolve_.rowwise_._DownwardX._Vod_assumeRowsPositive(created);
			return created;
		}
		static public double[,] RevolvedUpward() {
			var created = tertiary_._CanonicX.Canonic();
			nilnul.obj.matrix.op_.unary_.revolve_.rowwise_._UpwardX._Vod_assumeRowsPositive(created);
			return created;
		}

	}
}
