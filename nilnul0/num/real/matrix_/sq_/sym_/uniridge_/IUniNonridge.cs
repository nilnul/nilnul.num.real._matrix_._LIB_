using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.sym_.uniridge_
{
	/// <summary>
	/// the vals off ridge are uniform;
	/// 
	/// note: the val off ridge might be different from that on ridge.
	/// eg:
	///		[
	///			0,	1,	1,	...,	1
	///			1,	0,	1,	...,	1
	///			1,	1,	0,	...,	1
	///			...,...,...
	///			1,	1,	1,	...,	0
	///		]
	/// </summary>
	/// alias:
	///		uniElse
	///		uniOther
	public interface IUniNonridge:sym_.IUniridge
	{
	}
}
