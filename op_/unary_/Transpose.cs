using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.unary_
{
	 public  class Transpose:Unary4dblI
	{
		static public double[,] Op(double[,] matrix) {
			return MatrixX131113.Transpose(matrix);
		
		}
		

		public double[,] op(double[,] par)
		{
			return nilnul.obj.matrix.op_.unary_.Transpose<double>.Singleton.op(par);

		}
	}
}
