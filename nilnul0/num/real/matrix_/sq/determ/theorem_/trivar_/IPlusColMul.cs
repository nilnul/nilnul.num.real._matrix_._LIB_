using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.determ.theorem_.trivar_
{
	/// <summary>
	/// d( A + c r  ) = d(A) + r A* c
	///		,where c is <see cref="real.matrix_.ICol"/>
	///		,r is <see cref="real.matrix_.IRow"/>
	///		,A* is <see cref="real.matrix_.sq.op_.IAdjugate"/>
	///	;
	///	
	/// when A is invertible, A* = d(A) /A
	/// ,
	/// d(A+cr) = d(A) ( 1 + r A\ c )
	/// 
	///  when A = I, <see cref="theorem_.binary_.weinstein_.IPlusColMul"/>
	///	
	///  d ( I +cr ) 
	///  = 1+  rc 
	/// 
	/// </summary>
	/// <remarks>
	///  proof:
	///  when A is I, <see cref="binary_.weinstein_.IPlusColMul"/> 
	///  when A is invertible, 
	///		d(A+ cr) = d(A) d( 1 +  c A\ r )
	///		;
	/// 
	///  if A is not invertible, <see cref="num.real.matrix_.sq.grid_.plaid_.ii_.iabi.factorize_.tro_.ISchur"/>
	///  , let B = A-xI, where x is <see cref="num.real.expr_.Var1"/>
	///		,  |A-xI| is a <see cref="num.real.expr_.polynom_.univar_.IStd"/>
	///		， hence B is invertible.
	///		,hence
	///		|B + cr| = |B| + r B* c
	///		, a polynomial.
	///		now let x->0, as polynomial is continuous, hence 
	///		B ->A
	///		,hence 
	///		|A + cr| = |A| + r A* c
	///		
	///   
	///  
	///  
	///  
	/// 
	/// </remarks>
	/// alias:
	///		en.wikipedia.org/wiki/Matrix_determinant_lemma
	///		Sherman-Morrison-Woodbury
	///		<see cref="real.matrix.abgrebra_.field.theorem_.IShermanMorrison"/>
	internal class IPlusColMul
	{
	}


}
