using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.re_.reciprocal.theorem_
{
	///https://math.stackexchange.com/questions/3852/if-ab-i-then-ba-i?page=1&tab=scoredesc#tab-top
	///
	/// https://math.stackexchange.com/questions/470159/matrices-left-inverse-is-also-right-inverse
	/// 
	/// <summary>
	/// this re is symmetric, that is: BA=I is implied; 
	/// 
	/// for sq matrix: A,B,
	///  AB = I, if and only if  BA =I
	/// 
	/// proof:
	///		AB = I
	///			
	///		,then
	///			the columns of I are in the column space of A.  So A columns must be independent.
	///			hence Ax =0, means x =0; as x is to linearly combinate columns of A.
	///			
	///			ABA = (AB)A = IA =A
	///			ABA - A =0
	///			A(BA-I) = 0
	///			,as A is columnwise independent
	///			,hence each col of BA-I =0
	///			,hence BA-I =0
	///			,so BA= I.
	///	 on the other hand, if BA=I, per the above infer, AB=I
	///	 
	/// </summary>
	/// 
	/// <remarks>
	/// 
	/// </remarks>
	/// 
	/// 
	/// <see cref="real.matrix_.sq.op_._invert.semi.ITheorem"/>
	/// alias:
	///		symmetric
	internal class ISwappable
	{
	}



}
