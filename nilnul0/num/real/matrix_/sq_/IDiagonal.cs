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
	///			,like <see cref="matrix_.sq_.diag_.IUniform"/>
	///	vs:
	///		scaler, which is <see cref="diag_.IUniform"/>
	///			,used in scale:<see cref="real.matrix.op_.IScale"/>
	public interface IDiagonal
		:
		triag_.ILower
		,
		triag_.IUpper
		//,
		//ITriangular
	{
	}
}
