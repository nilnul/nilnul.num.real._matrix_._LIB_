using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.scale_
{
	/// as multiply is associable, any operation by divide is delegated under a multiplier.
	/// 
	/// but division will keep the hull; so???
	/// 
	/// by compromising, in <see cref="real.matrix_.sq_"/>, we keep multiplier in the top tier, as that's considered a matrix in product. in <see cref="real.matrix.op_"/>, we keep both, as here we emphasize op, which shall keep spanfulness in mind.
	/// 

	/// <summary>
	/// when the coef/amplifier is not 0
	/// </summary>
	/// <remarks>
	/// <see cref="real.matrix.op_.IShrink"/> is preferred, as it implies nonnil coefficient
	/// </remarks>
	/// alias:
	///		shred
	///		shrink
	///		<see cref="real.matrix.op_.IShrink"/>
	///		dilute
	///		slash
	///		stretch
	///		explode
	///		bloat
	///		
	public interface IByUnnil:IScale
	{
	}


}
