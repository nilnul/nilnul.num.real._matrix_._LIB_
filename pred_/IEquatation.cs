using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_
{
	/// <see cref="num.real.pred_.simult_.IEquality"/>
	/// <summary>
	/// an equation.
	/// eg:
	///		AX +Y=C
	///		
	/// </summary>
	/// <remarks>
	/// in the form of <see cref="nilnul.obj.re_.IEq1{IMatrix}"/>
	///
	/// </remarks>
	/// alias:
	///		<see cref="real.matrix.IEquatation"/> when being solved, might be transformed to <see cref="pred_.ISimult"/> when a constrain of x!=0 is put forward. So this is better placed under the namespace of <see cref="real.matrix.pred_"/>, just like <see cref="num.real.pred_.IEquatation"/>
	public interface IEquatation:matrix.IPred
    {
    }


}
