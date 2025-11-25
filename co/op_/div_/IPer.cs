using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co.op_.div_
{
	/// A/B = C
	///		,hence 
	///			A = BC
	///		,where B is m*s, C is s*n
	///		,A is m*n
	///	;
	///		C = C * I = C/I 
	///			,where I is n*n
	///	; so
	///		A/B = C/I
	///		
	///		,hence 
	///		AQ/BP 
	///			,where Q is n*n, P is s*s
	///	,Q/P is malformed.
	///	
	/// let's make B square.
	/// <summary>
	/// 
	///	
	///  A/B = C 
	///		,hence 
	///		A = BC=
	///		,hence
	///  ,where A is m*n, B is m*m, C is m*n
	///  ;
	///   Now 
	///			A * 1/B = C
	///		;and 
	///		B * 1/B = I
	///   we need to get the right inverse of B, a square matrix. <see cref="num.real.matrix_.sq.op_._invert.semi_.IRight"/>
	///		
	///	 
	/// </summary>
	public interface IPer
	{
	}

}
