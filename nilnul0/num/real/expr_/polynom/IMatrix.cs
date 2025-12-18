using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom
{
	public interface IMatrix:nilnul.obj.IMatrix<expr_.IPolynomial>
	{
	}

	static public class _MatrixX {
		static public void Simplify(ref real.expr_.Algebraic[,] m) {

			int h = m.GetLength(0);
			int w = m.GetLength(1);

			for (int i = 0; i < h; i++) {

				for (int j = 0; j < w; j++)
				{
					m[i, j].simplify();
				}
			}
		}
	}
}
