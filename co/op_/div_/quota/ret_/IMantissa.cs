using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co.op_.div_.quota.ret_
{
	/// <see cref="num.quotient.co.op_.IModulo"/>
	/// <see cref="num.quotient_._as_.IFloored"/>
	/// <summary>
	///  Ax =b
	///  ,then 
	///  x = A\b
	///		= GA \Gb
	///			,by <see cref="num.real.matrix.pred_.rudic_.col_.equat._slv_.by_._ByRowReductionX"/>
	///		=> K, d
	///	 ; then, 
	///	   A(K + d) =b
	///	    AK +Ad =b
	///	   ,where AK =0
	///	   ;so 
	///	   Ad =b
	///	   d = A\b
	///	   ;
	///	   A\b
	///	   = A\( 0 +b )
	///	   = A\0 + A\b
	///	   
	///	   
	///		GA\Gb = K +A\b
	///		 = K + (GA)\Gb
	///		 = 
	///		; 
	///		GAK + GA  (GA)\Gb = Gb
	///			, where GA is <see cref="num.real.matrix_.IVent"/>
	///			
	///	eg:
	///		Ax=
	///		[
	///			1,2, 0,0
	///			0,0, 1,0
	///		] x = [1,1]^T=b
	///			, then K is 
	///				[
	///					-2 1,0,	0
	///					0,0,0,	1
	///				]^T
	///			, d= [1,0,1,0]
	///		;
	///		then A (K +d) = AK + Ad = 0
	///		 x=A\b
	///			=GA \ Gb
	///			= 
	///    
	/// 
	///		
	///		
	///	 
	/// </summary>
	/// alias:
	///		mantissa, similar to <see cref="op_.IModulo"/>
	///		
	internal class IMantissa
	{
	}
}
