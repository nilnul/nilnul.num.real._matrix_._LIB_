using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq_.isosize.ratio.op_
{
	/// <summary>
	/// for A:B
	///		= GA:GB
	///			,where G is <see cref="num.quotient.matrix.op_.rowly_.IInvertible"/>
	///		= A`:B`
	///		,where A` is <see cref="quotient.matrix_.IVent"/>
	///	; 
	///	it can be interpretated as A\B the default, or A/B.
	///	find the common factor to make the denominator simple
	/// </summary>
	/// <remarks>
	/// for Ax=b
	/// ,x = A\b
	/// ,then we can simplify it to:
	///		GA\Gb
	///			,where GA is <see cref="quotient.matrix_.IVent"/>
	///	; when it's 0\1, it means no solvents;
	///	when it's 1\b=b such as 1\0=0, it means unique solvent
	///	;when it's 0\0, it means infinite solvents;
	///	<see cref="ratio_.quota_.invert.to_._ReduceX"/>
	/// </remarks>
	/// alias:
	///		约分
	///		reduce
	///		cancel
	///		ISimplify
	///	<see cref="real.matrix.pred_.rudic_.equat.ISolve"/>
	///	<see cref="real.matrix.pred_.rudic_.col_.equat.slv"/>
	///	<see cref="num.quotient.matrix.pred_.rudic_.univar_.equat.ISolve"/>
	///		AX=B
	///		,the X = A\B
	///		, if A is less rankful than B, then no X can make AX=B
	///		, otherwise we can have solvents:
	///			,, when A is rankful, then the solvent is unique.
	public interface IReduce
	{
	}
}
