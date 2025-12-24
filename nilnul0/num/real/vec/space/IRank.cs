using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.space
{
	/// <summary>
	/// the <see cref="vec.span.IRank"/> of the <see cref="vec.ISpace"/> is the <see cref="obj._vec_.IArity"/>
	/// ;
	/// eg: 
	///		for 3d vec, the arity is 3; <see cref="obj.vec.IArity"/>
	/// </summary>
	/// alias:
	///		<see cref="obj._vec_.IArity"/>
	///		
	public interface IRank:
		vec.span.IRank
		,
		nilnul.obj._vec_.IArity
	{
	}

}
