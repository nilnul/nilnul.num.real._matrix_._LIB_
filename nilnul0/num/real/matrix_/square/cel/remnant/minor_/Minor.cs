using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;



namespace nilnul.num.real.matrix_.square.aggregate_
{
	/// <summary>
	/// first minor. minor means minus something: here we remove some rows and columns. 
	/// Note this is a mutual recursion with determinant.
	/// </summary>
	///
	[Obsolete()]
	public static    class _MinorX
	{
		static public double Eval(double[,] matrix,int i,int j) {

			return real.matrix.square.Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix">must be square</param>
		/// <param name="rows2del"></param>
		/// <param name="cols2del">must equal to rows2del</param>
		/// <returns></returns>

		static public double _Eval(double[,] matrix,IEnumerable<int> rows2del,IEnumerable<int> cols2del) {

			return Determinant.Eval(
				nilnul.collection.matrix.MatrixX.Delete(matrix, rows2del, cols2del)
			);
		
		}

		static public R Minor(matrix_.Square1 square, int i, int j) {
			return matrix_.square.aggregate_._DeterminantX.Determinant(
				new Square1(
					nilnul.matrix.op_._DelX.Deltete_literally(square.val,i,j)
				)	
			);
		}

	 

		static public R2 Minor(matrix_.Square2 square, int i, int j) {
			return matrix_.square.aggregate_._DeterminantX.Determinant(
				new Square2(
					nilnul.matrix.op_._DelX.Deltete_literally(square.val,i,j)
				)	
			);
		}



	}
}
