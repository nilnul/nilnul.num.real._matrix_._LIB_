using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co.op_.div_.per
{
	/// <summary>
	/// A/B
	/// ;eg: <see cref="num.real.matrix.pred_.rudic_.col_.IEquation"/> where xA = b => x = b/A
	/// ,then we do columnwise <see cref="real.matrix.op_.colwise_.IGaussian"/>
	/// 
	/// </summary>
	/// for:
	///		x=b/A
	///		= bG/AG
	///		=bG/C
	///			,where C is <see cref="real.matrix_.trape_.left_.colly_.ICascade"/>
	/// ; then x is got by colwise version of <see cref="num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/>, being 
	///		, nonexist (when C is less ranked columnly than bG), eg: 3/0, where 0x =3 has no solution.
	///		, exist (when C is same ranked as bG)
	///			,, unique (when C is I), eg； 0/2, where 2x =0 has a unique solution.
	///			,, or infinite (when C is not square, in this case, the quotient can be fully divided as a whole number|matrix, <see cref="nilnul.num.co.op_.IModulo"/>).
	///				,where 0/0,  0x =0 has many solvents.
	/// 
	internal class IRet
	{
	}
}
