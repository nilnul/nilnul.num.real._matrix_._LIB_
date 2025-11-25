using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.dent_.indep_
{
	/// <summary>
	/// the first nonnil cel (pivot) is 1, for each row.
	/// </summary>
	/// <remarks>
	/// this is neutral step after forward elimination <see cref="IIndent"/> , and before backward substitution:<see cref="echelon_.ICanonical"/>
	/// </remarks>
	/// alias:
	///		simple
	///		regular
	///		normal
	///		unital
	///		reduced row echelon
	///		
    public interface IEchelon:op_.dent_.IDedundant
    {
    }


}
