using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.op_.unary_
{
	public class Transpose
		:
		matrix_.square.op_.Unary4dblI
	{

		static public double[,] _Op(double [,] matrix) {
			return num.real.matrix.op_.unary_.Transpose.Op(matrix);
		}
		public Square4dbl op(Square4dbl par)
		{
			return new Square4dbl(
				nilnul.obj.matrix.op_.unary_.Transpose<double>.Singleton.op(par)
			);

		}


		static public Transpose Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Transpose>.Instance;
			}
		}


	}
}
