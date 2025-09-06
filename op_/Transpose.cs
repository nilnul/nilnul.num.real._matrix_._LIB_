using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	 public  class Transpose:Unary4dblI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Op(double[,] matrix) {
			return nilnul.obj.matrix.op_.unary_.Transpose<double>.Singleton.op(matrix);
			///return MatrixX131113.Transpose(matrix);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Op(Q[,] matrix) {
			return nilnul.obj.matrix.op_.unary_.Transpose<Q>.Singleton.op(matrix);
			///return MatrixX131113.Transpose(matrix);
		}
		

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double[,] op(double[,] par)
		{
			return nilnul.obj.matrix.op_.unary_.Transpose<double>.Singleton.op(par);

		}


	}
}
