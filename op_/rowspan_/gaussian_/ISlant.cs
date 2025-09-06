using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_
{
	/// <summary>
	/// <see cref="_SlantExceptSubtract"/>
	///  for a row A
	///		,changes it to A + kB, where B is not A.
	///	visually, this is to push a rectangle horizontally to change it into a parallelogram.
	/// </summary>
	/// <remarks>
	/// this one can derive <see cref="IScale"/> by <see cref="_scale_._BySlantX"/>
	///		, <see cref="ISkew"/> by <see cref="subtract_._BySlantX"/> and <see cref="ISlantButNotSubtract"/>
	///		, <see cref="ISwap"/> by <see cref="_swap_._BySlantX"/>
	/// </remarks>
	/// alias:
	///		skew
	///		slant
	///		slope
	///		
	public interface ISlantButNotSubtract:IRowly
    {
    }



}
