using static System.Collections.Specialized.BitVector32;

namespace nilnul.num.real.matrix.op_._pinv_.by_
{
	///
	/// <summary>
	///  Pseudo-inverse by SVD (Singular Value Decomposition).
	///  by first computing the Svd ofA as A = UΣ V^T
	///		and
	///  then by theorem  A^+ = V Σ^+ U^T ,where
	///  
	///  Σ^+
	///		=
	///		[  S^−1	0	]
	///		[  0		0	]
	///  
	/// </summary>
	/// where V^T can be replaced by V^*, as the inverse is simultaneously multiplied.
	/// <remarks>
	/// multiple svds give the same pinv.
	/// </remarks>
	/// 
	///  This is the way it’s done in Matlab; the command is called mpp.
	class BySvd
    {
    }


}
