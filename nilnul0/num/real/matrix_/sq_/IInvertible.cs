using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// fully ranked
	/// or
	/// equivalently the determinant is nonnil
	/// </summary>
	/// <remarks>
	/// spanful linear combinate/transformation. 
	/// </remarks>
	/// This covers all <see cref="matrix.op_._indent.IElementary"/> operations;
	/// 
	/// alias:
	///		invertible
	///		,	independent
	///		nonsingular
	///		spanful linear combinate
	///		rankful
	///			,but in context of <see cref="nilnul.num.real.vecs"/>
	///		basis
	///		hully
	///		gaussian, as it is <see cref="matrix.op_.IGaussian"/>
	///		
	///
	//[Obsolete]
	public interface IInvertible
		:ISquare
		,
		matrix_.IIndependent
	{
	}



}
