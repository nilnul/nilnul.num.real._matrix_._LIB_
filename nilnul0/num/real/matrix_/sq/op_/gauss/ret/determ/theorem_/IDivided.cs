using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_.gauss.result.determ.theorem_
{
	/// <summary>
	/// if 
	///	   gauss(A ) = B,
	///	   then:
	/// det(A) = det(B)/c
	///		 
	///	
	///	proof:
	///		<see cref="sq.op_.basic.ret.determ.be_.distro.ITauto"/>
	///		gauss(A) = GA = B[0] B[1] ... B[n] A
	///		|GA| =  | B[0] B[1] ... B[n] A | 
	///			= | B[0] |  *  | B[1] ... B[n] A |
	///			= | B[0] |  *  | B[1]| ... |B[n]|  | A |
	///			= c|A|
	///			,where c!=0, per:<see cref="matrix_.sq_.basic_."/>
	/// </summary>
	internal class IDivided
	{
	}
}
