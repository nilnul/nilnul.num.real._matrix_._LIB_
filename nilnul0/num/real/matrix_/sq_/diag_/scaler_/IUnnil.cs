using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag_.scaler_
{
	/// <summary>
	/// no 0s on the diagonal;
	/// </summary>
	/// <remarks>
	/// can be considered as A / (1/x)
	/// </remarks>
	/// alias:
	///		shrink:<see cref="matrix_.sq_.IShrinker"/>
	///		
	///		shred, reserved for <see cref="diag_.IShred"/>
	///			,like shrink
	///		shard
	///		scold
	///		squeeze
	///		invertible
	///		
	///	vs:
	///		<see cref="real.matrix.op_.stretch_.squash_"/>, implying arbitrary/random/various/disproportion
	public interface IUnnil:sq_.diag_.IScaler
	{
	}
}
