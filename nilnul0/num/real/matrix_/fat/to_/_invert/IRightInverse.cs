using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.fat.to_
{
	/// <summary>
	/// eg:
	///		M = [1,0]
	///	,then
	///		A = [
	///			1
	///			,0
	///		]
	///		MA =  [1]
	///	,hence A is the right inverse. 
	///	
	/// also:
	///		A` =[
	///			1,2
	///		] is also the right inverse. So we have may right inverse.
	///	Note M is rowwise independent.
	///	but AM
	///		= [
	///			1,0
	///			0,0
	///		]
	///	,actually M has no left inverse. 
	/// </summary>
	/// <see cref="matrix_.fat_.indep.to_.IRightInverse"/>
	/// 
	public interface IRightInverse
	{
	}


}
