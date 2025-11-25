using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using System.Runtime.CompilerServices;



namespace nilnul.num.real.matrix_.sq.cel.remnant
{
	/// <summary>
	/// first minor. minor means minus something: here we remove some rows and columns. 
	/// Note this is a mutual recursion with determinant.
	/// </summary>
	/// <remarks>
	///	not signed. for signed <see cref="remnant.minor._CofactorX"/>
	/// </remarks>
	/// alias:
	///		余子式, 不添加符号
	///		子, means only one cel is crossed out
	///		
	[Obsolete(nameof(cel._MinorX))]
	public static  class _MinorX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _AssumeValid(double[,] matrix,int i,int j) {

			return sq.cel._MinorX._AssumeValid(in matrix, i, j);
			//return num.real.matrix_.sq._DeterminantX._Determinant_0equilat(nilnul.obj.matrix.cel._RemnantX._Remnant_celAssumeValid(matrix, i, j));
		
			//return num.real.matrix.square.Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _AssumeValid(in Q[,] matrix,int i,int j) {
			return sq.cel._MinorX._AssumeValid(in matrix, i, j);

			//return num.real.matrix_.sq._DeterminantX._Determinant_0equilat(nilnul.obj.matrix.cel._RemnantX._Remnant_celAssumeValid(matrix, i, j));
		
			//return num.real.matrix.square.Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		}





	}
}
