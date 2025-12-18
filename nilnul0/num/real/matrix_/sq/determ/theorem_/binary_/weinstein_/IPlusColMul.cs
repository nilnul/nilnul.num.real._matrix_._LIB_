using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.determ.theorem_.binary_.weinstein_
{
	///  <see cref="trivar_.IInvertiblePlusMulti"/>
	/// <summary>
	/// d( I + c r  ) = d(1+rc) = 1 + r c
	///		,where c is <see cref="real.matrix_.ICol"/>
	///		,r is <see cref="real.matrix_.IRow"/>
	///	;
	/// </summary>
	/// <remarks>
	///  <see cref="theorem_.binary_.IWeinsteinAronszajn"/>
	///  ,
	///    I 0
	///    v 1
	///    *
	///    I+uv,	u
	///    0,		1
	///    *
	///    [
	///		I	0
	///		-v	1
	///		]
	///   = 
	///   [
	///		I+uv,		u
	///		v+ vuv,		vu +1
	///		]
	///    *
	///    [
	///		I	0
	///		-v	1
	///		]
	///		=
	///		[
	///			I,	u
	///			0,	vu+1
	///		]
	///	;
	///	,hence:
	///		det (I + uv) = vu+1
	///	;
	/// </remarks>
	/// alias:
	///		en.wikipedia.org/wiki/Matrix_determinant_lemma
	///	for general case:
	///		<see cref="theorem_.trivar_.IPlusColMul"/>
	internal class IPlusColMul
	{
	}
}
