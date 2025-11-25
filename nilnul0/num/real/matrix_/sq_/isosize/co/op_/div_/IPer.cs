using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.co.op_.div_
{
	/// <summary>
	/// A/B
	/// = A * 1/B
	/// 
	/// </summary>
	/// <remarks>
	/// when the dividend is I, 
	/// I/A
	///	 =GI/GA
	///	 = G/GA
	///	 =G/A`
	///		,where A`:= GA
	///	 , when A` =I
	///	 , I/A = G/I =G	, the numerator is the 1/A. 
	///	 ;
	///	 when  A`, is <see cref="real.matrix_.sq_.IVent "/>
	///		
	///		=>A = G\A`
	///		
	///		I/A = GI/GA = G/ A` =  I / (G\A`)
	///		 
	///		<see cref="num.real.matrix_.sq.factorize_.co_.IGaussianVent"/>
	///	 
	/// </remarks>
	public interface IPer
		:op_.IDivide
	{
	}

}
