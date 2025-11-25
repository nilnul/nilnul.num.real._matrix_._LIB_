using System;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// under as well as above the diagonal line are all nils
	/// </summary>
	/// alias:
	///		stretch
	///			,like <see cref="matrix_.sq_.diag_.IScaler"/>
	///			,<see cref="real.matrix.op_.IStretch"/>
	///	vs:
	///		shrink, which is <see cref="matrix_.sq_.diag_.IInvertible"/>
	///		scaler, which is <see cref="diag_.IScaler"/>
	///			,used in scale:<see cref="real.matrix.op_.IScale"/>
	public interface IDiagonal
		:
		triag_.ILower
		,
		triag_.IUpper
		//,
		//ITriangular
		,real.matrix_.IDiagonal
	{
	}
}
