namespace nilnul.num.real.matrix.pred_.equat_.linear_
{
	/// <summary>
	/// AX=B[r*c], where c is 0.
	/// ; X is a matrix with 0 columns, and t rows. It's unique
	///  ;
	///  eg:
	///		A[0*0] * X[0*0]   = B[0*0], a unique solvent
	///		R[0*1] * R[1*0]   = R[0*0], a unique solvent
	///		R[0*2] * R[2*0]   = R[0*0], a unique solvent
	///		R[1*0] * R[0*0]   = R[1*0], a unique solvent
	///				0=0.
	///		R[2*0] * R[0*0]   = R[2*0], a unique solvent
	///				0=0
	///				0=0
	/// </summary>
	/// <remarks>
	///  eg: when r = 3, c = 0, t =2
	///  So B = {
	///		[]
	///		,[]
	///		,[]
	///		}
	///	;
	/// then, X is [t*0], which is a matrix with 0 columns, and t rows, like:
	///		X = {
	///			[]
	///			,[]
	///		}
	///	;
	///	A is 3*2, like, say {
	///			[1,2]
	///			[3,4]
	///			[5,6]
	///		}
	///	;
	///	
	///	In all, X is already determined as [t*0], no matter what the A is.
	/// </remarks>
	/// alias:
	///		collapse
	///			:col lapsed
	///		accordion
	///

	public interface IColumnless
		:matrix.pred_.equat_.ILinear
	{ }
}
