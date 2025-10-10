using System;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// the resulted matrix is the hull of the input; in other words, they define the same space;
	/// </summary>
	/// <remarks>
	/// keep/maintain the hull
	/// </remarks>
	/// 
	[Obsolete(nameof(ISpanful))]
	public interface IHull
		:
		ISpanful
		,
		op_.IRowly
	{
	}





}
