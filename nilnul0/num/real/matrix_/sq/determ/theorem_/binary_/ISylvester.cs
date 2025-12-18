using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.determ.theorem_.binary_
{
	/// this is not en.wikipedia.org/wiki/Sylvester%27s_determinant_identity
	/// <see cref="IWeinsteinAronszajn"/>
	/// 
	/// 
	/// <summary>
	/// det(1+AB) = det(1+BA)
	/// </summary>
	/// <remarks>
	/// proof:
	///		[
	///			1,	-A
	///			B,	1
	///		][
	///			1,	A
	///			0,	1
	///		]=[
	///			1,	0
	///			B,	BA+1
	///		]
	///		vs:
	///		[
	///			1,A
	///			0,1
	///		][
	///			1,	-A
	///			B,	1
	///		]=[
	///			1+AB,	0
	///			B,	1
	///		]
	///		
	/// ,their determinants are the same.
	/// hence:
	///		qed
	/// </remarks>
	/// <see cref="matrix_.sq.grid_.plaid_.ii_.iabi.factorize_.tro_.ISchur"/>
	internal class ISylvester
	{
	}

}
