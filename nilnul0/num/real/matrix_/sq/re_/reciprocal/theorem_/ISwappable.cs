using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.re_.reciprocal.theorem_
{
	///https://math.stackexchange.com/questions/3852/if-ab-i-then-ba-i?page=1&tab=scoredesc#tab-top
	///
	/// https://math.stackexchange.com/questions/470159/matrices-left-inverse-is-also-right-inverse
	/// 
	/// <summary>
	/// for sq matrix: A,B,
	/// if AB = I, then BA =I
	/// 
	/// proof:
	///		LM = I
	///			,where M is square.
	///			,hence L is M's left inverse.
	///		,then
	///			the columns of I are in the column space of L.  So L columns must be independent.
	///			hence Lx =0, means x =0; as x is to linearly combinate columns of L.
	///			
	///			LML = (LM)L = IL =L
	///			LML -L =0
	///			L(ML-I) = 0
	///			,as L is columnwise independent
	///			,hence each col of ML-I =0
	///			,hence ML = I.
	/// </summary>
	/// 
	/// <remarks>
	/// 
	/// 
	/// </remarks>
	/// 
	/// proof:
	///		;also due to <see cref="sq.calc_.mul.det.theorem_.Distro"/>, So AB=I, means, |B| !=0
	///		;
	///		So <see cref="matrix_.sq_.invertible.op_.IInvert"/>, we can find C= B^-1.
	///		; C = I *C  = AB * C= A(BC) = A.
	///		So BA = B(C) =I
	/// 
	/// 
	/// <see cref="real.matrix_.sq.op_._invert.semi.ITheorem"/>
	/// alias:
	///		symmetric
	internal class ISwappable
	{
	}



}
