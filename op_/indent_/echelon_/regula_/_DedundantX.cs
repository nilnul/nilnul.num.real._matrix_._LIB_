using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.indent_.echelon_.regula_
{
	/// <summary>
	/// <see cref="matrix.op_.IIndent"/>
	/// 
	/// </summary>
	/// alias:
	///		echelon:<see cref="matrix.be_.IIndent"/>, <see cref="matrix_.indent_.indep_."/>
	///		indent
	///		gaussian
	///		Gauss–Jordan elimination
	///	vs:
	///		GramSchmidt process to get orthogonal basis, where the result here is not orthogonal in general; the Gram–Schmidt and Gaussian elimination can both be described as taking a given basis to a special basis; Gaussian transforms the matrix by making the subspace orthonormal, and Schmidt takes the superspace into account. eg: (0,1,1) and (1,0, 1) is orthonormal in (x,y), but not ortho nor normal in (x,y,z);  
	static public class _DedundantX
	{


		static public Q[,] ToCanonical( ref Q[,] matrix)
		{
			var _rank = indent_._EchelonX.EchelonForRank(ref matrix); /// we need the rank twice

			_RegulateX._Regulate_0echelon_1rank(ref matrix, _rank );

			return op_.indent_._DedundantX._Dedundant_0indent_1rank(matrix, _rank);

		}


		static public Q[,] ToCanonical(  Q[,] matrix)
		{
			var x = (Q[,])matrix.Clone();
			return ToCanonical(
				ref x
			);

			//var _rank = indent_._EchelonX.EchelonForRank(ref matrix); /// we need the rank twice

			//_RegulateX._Regulate_0echelon_1rank(ref matrix, _rank );

			//return op_.indent_._DedundantX._Dedundant_0indent_1rank(matrix, _rank);

		}




	}
}
