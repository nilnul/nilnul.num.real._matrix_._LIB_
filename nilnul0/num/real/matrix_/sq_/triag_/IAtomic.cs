using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.triag_
{
	/// <summary>
	/// An atomic (lower or upper) triangular matrix is a special form of unitriangular matrix, where all of the off-diagonal elements are zero, except for the entries in a single column. 
	/// Such a matrix is also called a Frobenius matrix:<see cref="matrix_.sq_.triag_.lower_.IFrobenius"/>, a Gauss matrix, or a Gauss transformation matrix:<see cref="sq_.triag_.lower_.IGaussTransformationMatrix"/>.
	/// </summary>
	/// alias:
	///		slant,<see cref="real.matrix.op_.basic_.ISkew"/>
	///		
	/// vs:
	///		<see cref="real.matrix_.sq_.basic_.skews_.ISlant"/> to allow unnil cels on the whole row; for the colwise one, <see cref="real.matrix_.sq_.basic_.skews_.colwise_.ISlant"/>
	internal class IAtomic
	{
	}

}
