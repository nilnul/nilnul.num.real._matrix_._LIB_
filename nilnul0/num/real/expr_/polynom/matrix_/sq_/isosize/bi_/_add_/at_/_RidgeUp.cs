using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1 = nilnul.num.real.expr_.Algebraic;


namespace nilnul.num.real.expr_.polynom.matrix_.sq_.isosize.bi_._add_.at_
{
	static public class _RidgeUpX
	{
		static public void _RidgeUp_1diag(ref T1[,] matrix, IEnumerable<T1> ridge) {
			var index = 0;
			foreach (var d in ridge)
			{
				matrix[index, index] += d;
				index++;
			}
		}

		static public void _RidgeUp_0shift(ref T1[,] matrix, T1 ridge) {

			int width = matrix.GetLength(0);
			for (int i = 0; i < width; i++)
			{
				matrix[i, i] +=ridge;
			}

		}

	}
}
