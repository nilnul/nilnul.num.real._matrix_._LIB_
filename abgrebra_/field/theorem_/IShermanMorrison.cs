using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.abgrebra_.field.theorem_
{
	///
	/// en.wikipedia.org/wiki/Sherman–Morrison_formula
	/// 
	/// <summary>
	/// 
	/// (A+ cr)\1 = A\ - A\cr A\ / (1+ rA\c)
	///		,where C is <see cref="real.matrix_.ICol"/>
	///		,	r is <see cref="real.matrix_.IRow"/>
	///	,which means:
	///		(A+ cr) * ( A\ - A\cr A\ / (1+ rA\c) ) = I
	///	
	///	;
	///	eg: when A =I
	///		(I+ cr)\1 = I  - cr/ (1+rc).
	///		,which means:
	///			
	///		(I+ cr) * ( I  - cr/ (1+rc) )
	/// </summary>
	/// <remarks>
	/// 
	/// if 1+rA\c is 0, then by<see cref="tetra_.IWoodbury"/>, det(A+cr) = det(A) (1+rA\c) =0, hence A+cr is not invertible.
	///			
	///		
	/// </remarks>
	/// alias:
	///		Sherman-Morrison-Woodbury
	///	 <see cref="real.matrix_.sq.determ.theorem_.trivar_.IPlusColMul"/>
	/// 
	public interface IShermanMorrison
	{
	}
}
