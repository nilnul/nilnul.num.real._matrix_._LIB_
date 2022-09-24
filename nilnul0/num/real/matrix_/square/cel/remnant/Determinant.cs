using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.cel.remnant
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DeterminantX
	{
		/*
		 todo: further investigation
		 */
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>
		static public double _AssumeValid(double[,] matrix,int row,int col) {
			return
				real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				real.matrix.cel._ChildX._Child_assumeValid(matrix,row,col)
				);
		
		}

		///		 can this replace <see cref="cel.remnant.minor._CofactorX"/> in calculating determinant, in order to remove the step of giving a sign to the <see cref="remnant._MinorX"/> ?
		///		 it seems this only work for odd-sized square matrix.
		///		 for even-sized square matrix, the child can be got from <see cref="cel.remnant"/> by swapping even times.
		 
	}
}
