using System;

namespace nilnul.num.real.vecs.be_
{
	/// non-trivial combination is zero
	/// ;
	/// eg:
	///		{}, the trivial combination is nil. we can find no nontrial combination. Hence it's independent.
	///		{ []}, the non trivial combination, 1*[],  is nil the []. Hence it's dependent.
	///		
	///
	/// <summary>
	/// when  one vec is a linear combination of other vecs.
	/// eg:
	///		{}, not dependent.
	///		{[]}
	/// </summary>
	/// <remarks>
	/// for 1d, we need only one independent(unnil) vec to represent all vecs.
	///		, in matrix {[1]}, while {[0]} is dependent.
	/// for 2d, we need only 2 independent vecs to represent all vecs.
	/// 
	/// for 0d, we need 0 vecs: {}, which can represent all vecs {[]}. that is [] can be represented as sum({}).
	///		,in matrix []
	///		but {[]} is dependent, as [] can be represented by other vecs(empty vec)
	///			, in analogy, {[0]} is dependent.
	/// 
	/// </remarks>
	///
	///
	/// 
	///

	[Obsolete(nameof(real.matrix.rows.be_.IIndependent))]
	public interface IDependent
    {
		///
    }


}
