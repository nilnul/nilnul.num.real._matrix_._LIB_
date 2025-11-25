using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_._indent
{
	/// as we are now using matrix, hence this is defined as not only to operate once, but recursively multiple times, like done by an invertible matrix multiplication.
	/// <summary>
	/// basic operations that can be recursively applied to make <see cref="IIndent"/> or <see cref="dent_.IStd"/> or <see cref="dent_.echelon_.ICanonical"/>
	/// the basic operations proposed by Gausse or Cram:
	///		scale one row by unnil
	///		, swap two rows
	///		, suck another row (scaled by nil or unnil)
	///		
	/// </summary>
	///		
	/// <summary>
	/// elementary transformation. on rows , or cols.
	/// multiplied by an invertible matrix from left(rowwise elementary), or from right(colwise elementary);
	/// this is in fact a nonregressive linear span in different representations.
	/// </summary>
	/// 
	/// <remarks>
	/// this is used to solve linear equations.
	/// <see cref="op_.rowspan_.basic_"/>
	/// or <see cref="op_.colly"/>
	/// </remarks>
	/// <remarks>
	/// even <see cref="gaussian_.ISkew"/> is enough for <see cref="op_._indent.gauss_.IShed"/> and <see cref="gauss_.ISwap"/>, in algorithm <see cref="op_.dent_._EchelonX"/>, three operations are used.
	/// </remarks>
	/// alias:
	/// alias:
	///		elementray
	///		basic
	///		rudimental
	///		fundamental
	///		elementary
	///			,elem, in short
	///		gaussian gram
	///		
	public interface IElementary:matrix.IOp
	{
	}
}
