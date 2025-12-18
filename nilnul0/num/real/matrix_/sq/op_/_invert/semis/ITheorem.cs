using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_._invert.semi
{
	/// proof:
	///		;also due to <see cref="sq.calc_.mul.det.theorem_.Distro"/>, So AB=I, means, |B| !=0
	///		;
	///		So <see cref="matrix_.sq_.invertible.op_.IInvert"/>, we can find C= B^-1.
	///		; C = I *C  = AB * C= A(BC) = A.
	///		So BA = B(C) =I
	/// 
	/// if left inverse exists, then right inverse exists;
	/// note: for unsquare matrix, this is not true, <see cref="real.matrix_.fat.to_.IRightInverse"/>.

	/// <summary>
	///		<see cref="real.matrix_.sq.re_.reciprocal.theorem_.ISwappable"/>
	/// <see cref="num.real.matrix_.sq_.isosize.re_.reciprocal.theorem_.ISwappable"/>
	/// 
	/// 
	/// ;claim: left inverse = right inverse.
	/// proof:
	///		LA = I
	///		AR = I
	///	,then 
	///		LAR = LI = L
	///		(LA)R = IR = R
	///		,hence L=R
	///	;
	///	
	/// 
	///	
	/// ;claim: uniqueness:
	/// proof:
	///		
	///			MA=I
	///			MB =I
	///			,then AM =I 
	///			, AMB = AI
	///			(AM)B = IB = AI
	///			A=B
	///	;
	///	
	/// claim: invertible  <see cref="nilnul.bit.bi_.IEq"/>|iif  independent|<see cref="matrix_.sq_.IInvertible"/>
	/// claim:
	///		invertible = determinantUnnil
	/// ;proof:
	///		per <see cref="matrix_.sq_.invertible.op_._InvertX"/>, if its determinant is unnil, we can find its inverse. hence (determinant is not 0) derives invert.
	///		on the other hand, if it is invertible, then is its determinant unnil?
	///		<see cref="matrix_.sq.op_._invert_.by_.IByRatio"/>
	///		,GA =I ( byproduct:  GI = 1/A )
	///		but <see cref="matrix_.sq.op_.basic.ret.determ.be_.distro.ITauto"/>, 
	///		hence |G||A| = |I|, hence |A| !=0.
	///		
	/// </summary>
	/// <see cref="matrix_.sq.re_.reciprocal.theorem_.ISwappable"/>
	internal class ITheorem
	{
	}
}
