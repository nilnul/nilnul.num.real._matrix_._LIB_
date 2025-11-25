using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co.op_
{
	/// <see cref="nilnul.obj.matrix_.isohigh.bi_._JuxtaposeX"/>;
	/// <see cref="real.matrix_.isohigh.bi_.IJuxtapose"/>
	/// <summary>
	/// This can be understood as fraction:
	///		A|B = A\B
	///	; eg:
	///		Ax = b
	///		then 
	///		x = A\b
	///	; for A\b 
	///		,we use common multiplier:
	///			GA \ Gb
	///		; 
	///		it might be insolvent;
	///		or it might be infinite.
	///		; that means many solvent can be the quotient.
	///		,in other words, many solvent:x, such that Ax =b.
	///		and it can represented as fraction:
	///			GA \ Gb
	///		; which later can be transformed into a matrix, <see cref="real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/> which looks like remainder and quotient.
	/// </summary>
	public interface IDivide
	{
	}
}
