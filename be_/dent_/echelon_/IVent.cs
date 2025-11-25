using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_.dent_.echelon_
{
	/// either <see cref="IRowwise"/>
	/// or <see cref="IColwise"/>"/>
	/// 
	/// <summary>
	/// eg:
	///		{
	///			1,1,0,0,1;
	///			0,0,1,1,0;
	///			0,0,0,0,0;
	///		}
	/// </summary>
	/// <remarks>
	/// <see cref="dent_.paragon_._ReducedEchelonX"/>
	/// </remarks>
	/// alias:
	///		recognized.
	///		echelon
	///			,as <see cref="be_.dent_.IEchelon"/> is not standard (<see cref="matrix.op_.dent_.IEchelon"/> would result into different matrix) 
	/// 

	public interface IVent: real.matrix.be_.dent_.IEchelon
	{
	}
}
