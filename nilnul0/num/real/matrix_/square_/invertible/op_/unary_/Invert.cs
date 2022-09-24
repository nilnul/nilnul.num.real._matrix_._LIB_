using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.invertible.op_.unary_
{
	public class Invert
		:
		invertible.op_.Unary4dblI
	{
		static public  double[,] _Matrix_assumeSquare1invertible(double[,] nonsinglularSqMatrix) {
			return matrix_.square.op_.unary_.Inverse._Matrix_assumeSquare(
				nonsinglularSqMatrix
			);

		}

		public Invertible4dbl op(Invertible4dbl par)
		{
			return new Invertible4dbl(
				_Matrix_assumeSquare1invertible(par.ee) 
			);
			//throw new NotImplementedException();
		}


		static public Invert Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Invert>.Instance;
			}
		}

	}
}
