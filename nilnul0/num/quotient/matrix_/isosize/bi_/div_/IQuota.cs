using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.isosize.bi_.div_
{

	/// <summary>
	/// eg:
	///		Ax =b
	///		,then
	///		x = A\b
	///	;
	/// </summary>
	/// <remarks>
	/// <see cref="matrix_.sq_.isosize.bi_.div_.IQuota"/>
	/// </remarks>
	/// alias:
	///		quota
	///			,eg:
	///				RMB\USD
	///					, one rmb can buy/worth/value how much usd?
	///				,which is not Rmb/Usd
	///					, meaning how much rmb is needed per usd;
	/// when the divide is '\', not '/', it's denoting the share/quota one can get.
	///		worth
	///		share
	///		portion
	///		slice
	///		stake
	///		merit
	///		ration
	///		capability
	///		capacity
	///			, like the inverse of freq = duration
	///		
	///		

	public interface IQuota
		:IDivide
		,matrix_.isohigh.bi_.IDivide
	{
	}

}
