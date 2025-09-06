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
	/// </summary>
	/// <remarks>
	/// proof:
	///		;also due to <see cref="sq.calc_.mul.det.theorem_.Distro"/>, So AB=I, means, |B| !=0
	///		;
	///		So <see cref="matrix_.sq_.invertible.op_.IInvert"/>, we can find C= B^-1.
	///		; C = I *C  = AB * C= A(BC) = A.
	///		So BA = B(C) =I
	/// </remarks>
	/// alias:
	///		symmetric
	internal class Swappable
	{
	}



}
