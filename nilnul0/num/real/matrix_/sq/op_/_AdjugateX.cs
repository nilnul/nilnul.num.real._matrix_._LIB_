using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	///  transpose of <see cref="sq.op_.unary_.CofactorMatrix"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///  this * A = |A|
	/// alias:
	///		 伴随矩阵
	///		 aStar
	///			,often add an asterisk the supscript to the matrix.
	///		adjunct,  
	///		 adjoin
	///			was used historically, but now is reserved for other use as conjugate transpose for complex matrix
	///		classical adjoint
	///		
	/// <see cref="nilnul.num.real.matrix_.sq.op_.unary_.Adjugate"/>
	static public class _AdjugateX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>empty if empty</returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Adjugate_0equilat(Q[,] matrix) {

			return num.real.matrix.op_.Transpose.Op(
				op_._adjugate._CofactorMatrixX._CofactorMatrix_0equilat(matrix)
				//CofactorMatrix.Matrix4dbl(matrix)
			);
		
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Adjugate_0equilat(double[,] matrix) {

			return num.real.matrix.op_.Transpose.Op(
				op_._adjugate._CofactorMatrixX._CofactorMatrix_0equilat(matrix)
				//CofactorMatrix.Matrix4dbl(matrix)
			);
		
		}




	}
}
