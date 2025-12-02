using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vander_
{
	/// <summary>
	/// [
	///		1	,x	,x^2
	///		1	,x1	,x1^2
	///		1,	x2	,x2^2
	///	]
	///	=A
	///	, hence 
	///	A [a,b,c] = [y,y1,y2]
	///		,gives us the coefficients of the original polynomial:
	///			a for degree 0
	///			b for degree1
	///			c for degree2
	/// </summary>
	/// <remarks>
	/// transposal of <see cref="IRowwise"/>
	/// </remarks>
	public interface IColwise:IVandermonde
	{
	}


}
