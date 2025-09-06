using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_
{
	/// <summary>
	/// Ax +b
	/// , where x, b are matrix such as col
	/// </summary>
	/// <remarks>
	///  [], [0*c], [r*0] is considered unnil, hence Ax +b can always be transformed into A`x` +b`, where A` is still untrivia, and the expr is still linear, not preliminary (nihility like 3=0, or negligible like 0=0)
	/// </remarks>
	/// alias:
	///		linear
	///			, it's linear in that:
	///				+) R[0,0] X[0,1] = B[0,1] has an unnil coef;
	///				+) [0], or any other <see cref="nilnul.num.real.matrix.be_._OmniNilX"/>|<see cref="nilnul.num.real.matrix_.INilful"/>, still has a <see cref="real.matrix_.vacant_.ISquare"/> at the topleft corner, and can be transformed to have a core linear formula.
	///				+) <see cref="nilnul.num.real.pred_.simult_.ILinear"/> can have 0 count of constraints.
	///				+) R[0,0] X[0,1] + B[0,1]= 0, is still an affine formula.
	///				+) the linear space means the linear transformation, which is essentially a finite set of vars representing axis each, is *linearly* combinated, with no nonlinear transformation such as x^2. linear transformation of X, the definition includes 0coef, hence well defines this as linear.
	/// 
	/// <see cref="num.real.pred_.simult_.ILinear"/>
	public interface ILinear
		:matrix.IPred
	{
	}
}
