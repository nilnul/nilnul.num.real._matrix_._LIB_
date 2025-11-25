using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag_.invertible_
{
	/// <summary>
	/// at most one cel at the diagonal is not 1
	/// eg:
	///		[]
	///		[1]
	///		[3]
	///		[
	///			1,0
	///			0,1
	///		]
	///		[
	///			1,0
	///			0,1/2
	///		]
	///	;exclude:
	///		[
	///			3,0
	///			0,5
	///		], which is <see cref="diag_.IInvertible"/>
	/// </summary>
	/// alias:
	///		shed, in water shed, which is related to water in  dilute water
	///			:water down meant by dilute
	///			: sounds like "泄"
	///			,<see cref="matrix.op_.dilute_."/>
	///		diminish
	///		
	///		
	public interface IShed
		:diag_.IShred
	{
	}



}
