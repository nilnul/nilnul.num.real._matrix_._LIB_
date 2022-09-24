using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;



namespace nilnul.num.real.matrix_.square.cel.remnant
{
	/// <summary>
	/// first minor. minor means minus something: here we remove some rows and columns. 
	/// Note this is a mutual recursion with determinant.
	/// </summary>
	/// alias:
	///		余子式
	public static  class _MinorX
	{
		static public double _AssumeValid(double[,] matrix,int i,int j) {

			return num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(nilnul.obj.matrix.cel._RemnantX._Remnant_celAssumeValid(matrix, i, j));
		
			//return num.real.matrix.square.Determinant._Eval_laplace(nilnul.collection.matrix.MatrixX.Delete(matrix, i, j));
		}


		static public R _AssumeCel(matrix_.Square1 square, int i, int j) {
			return matrix_.square.aggregate_._DeterminantX.Determinant(
				new Square1(
					nilnul.matrix.op_._DelX.Deltete_literally(square.val,i,j)
				)	
			);
		}

	 

		static public R2 _AssumeCel(matrix_.Square2 square, int i, int j) {


			return matrix_.square.to_.scalar_._DeterminantX.Determinant(
				new Square2(
					nilnul.matrix.op_._DelX.Deltete_literally(square.val,i,j)
				)	
			);
			return matrix_.square.aggregate_._DeterminantX.Determinant(
				new Square2(
					nilnul.matrix.op_._DelX.Deltete_literally(square.val,i,j)
				)	
			);

		}



	}
}
