using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_.unary_.adjugate.ed.determ.theorem_
{
	
	/// <summary>
	///  det(A*) = |A|^(n-1)
	/// ,where |A*| = 1, when n lt 2
	///    |A*| = 0, when n>=2, and |A|=0
	/// 
	/// proof:
	/// 
	/// if n=0
	/// ,	|A*| =1 = 1^x= |A|^(n-1) 
	/// if n=1
	///		,|A*| =1 = x^0= |A|^(n-1)
	///	;
	///	when n>1,
	///	
	/// A A* = |A| I
	/// =>
	/// det(A) det(A*) = |A|^n
	/// 
	/// if |A| is not nil, then |A*| =|A|^(n-1);
	/// if |A| is 0, then:
	///		when A =0, then A* =0 (this is not true when n=1). |A*| = 0^(n-1)
	///		when A!=0, then
	///			,, if A* is invertible, then, 
	///				A A* /A* = |A|I/A*
	///				A = 0, contradiction. Hence A* is not invertible.
	///				thus |A*| =0
	///	;		
	/// 
	/// </summary>
	/// <remarks>
	///		
	/// </remarks>
	class IPowWidthMinus
	{

	}

}
