using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent_
{
	/// 
	/// <summary>
	/// no zerowS.
	/// eg:
	///		[
	///			0,1,0,3
	///		]
	///	;
	///	
	/// eg:
	///		[
	///			0,1,0,2
	///			0,0,1,3
	///		]
	/// eg: 
	/// 0, 1, 0,0,0,0,1
	/// 0, 0, 0,1,0,0,1
	/// 0, 0, 0,0,1,0,1
	/// 
	/// </summary>
	/// <remarks>
	/// this is the ultimate form of rowwise operation; to further process, we need then <see cref="real.matrix.op_.IColwise"/> which is a transformation of variable(columnwise)s in a <see cref="real.matrix.IPred"/>
	/// </remarks>
	/// alias:
	///		std, where 's' leads 'set', excluding zero vecs;
	///		paragon
	///	vs:
	///		<see cref="matrix_.ICanonical"/>
	///		<see cref="matrix_.indep_"/>
	///		<see cref=""/>
	///			
	public interface IIndependent:IVent
	{
	}
}
