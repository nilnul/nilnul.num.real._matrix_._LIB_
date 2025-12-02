using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix.pred_
{
	/// <summary>
	/// Ax =b
	/// , then x = A:\b
	/// ;
	/// eg:
	///		0x = 0, then x = 0:\0, hence x can be any value, the full scope:<see cref="_pred.IScope"/>;
	///	eg:
	///		0x =1, then x= 0:\1, hence the solvent is empty.
	/// eg:
	///		1x =0, then x = 0.
	///	;
	///	note:
	///		0x =0
	///		,is different from <see cref="obj.pred_.conjunct_.IVacuous"/>
	///		, or <see cref="obj.pred_.INary"/> where the scope is <see cref="obj._pred.scope_.INonevariate"/>, and for matrix, it's 
	///		Ax =b, where A is m*0, x is 0*n, b is m*n:<see cref="num.real.matrix.co_.multible_.IFlicker"/>
	/// </summary>
	/// <remarks>
	///  for xA =b, <see cref="rudic_."/>
	/// </remarks>
	/// alias:
	///		ratio, like <see cref="num.real.pred_.ISubliminary"/>
	///		
	public interface IRudimental:matrix.IPred
	{
	}
}
