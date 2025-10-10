using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_._canon_.by_
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
	static public class _GaussianX
	{


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] ToCanonical(Q[,] m) {
			return nilnul.num.real.matrix.op_.indent_.echelon_.dedund_._RegulateX.Regulate(m);
		}




	}
}
