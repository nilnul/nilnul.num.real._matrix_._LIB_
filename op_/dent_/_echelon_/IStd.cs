using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.dent_.echelon_
{
	/// each is <see cref="num.real.vec_.unnil_.IStd"/>
	/// 
	/// <summary>
	/// the first nonnil cel (pivot) is 1, for each row.
	/// </summary>
	/// <remarks>
	/// this is neutral step after forward elimination <see cref="IIndent"/> , and before backward substitution:<see cref="dedund_.ICanonical"/>
	/// </remarks>
	/// alias:
	///		std
	///			,short for a simplified one
	///			,meaning std vertically, hence colwise standardized
	///		simple
	///		regular
	///		normal
	///		unital
	///		reduced row echelon
	///		
    public interface IStd:op_.dent_.IEchelon
    {
    }


}
