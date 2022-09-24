using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.tertiary_.unital
{
	static public class _ShuffleX
	{
		static public double[,] Y2z() {
			var created = tertiary_._CanonicX.Canonic();
			nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_.shuffle_._ByShearX._Shuffle_assumeValid(created,1,2);
			return created;
		}

		static public double[,] X2z() {
			var created = tertiary_._CanonicX.Canonic();
			nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_.shuffle_._ByShearX._Shuffle_assumeValid(created,0,2);
			return created;
		}
		static public double[,] X2y() {
			var created = tertiary_._CanonicX.Canonic();
			nilnul.num.real.matrix.op_.unary_.elementary_.rowwise_.shuffle_._ByShearX._Shuffle_assumeValid(created,0,1);
			return created;
		}


	

	}
}
