using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.calc_.mul.det.theorem_
{
	/// <summary>
	/// f (ab) = f(a) f(b)
	/// ,
	/// |ab| =|a| |b|
	/// </summary>
	/// <remarks>
	///  proof:
	///		for <see cref="matrix_.trape_.IRight"/>s, the claim holds.
	///		for general matrix, we just transform a by:
	///			ca
	///				,where c means either: switch two rows, but change the sign of one row
	///				,or scale one row and add that to another row
	///			, c will not change the determ, but will change a to upper triag.
	///			
	///   cab d^T  
	/// </remarks>
	/// <see cref="bi_.mul.result.determ.be_.distro.ITauto"/>
	internal class Distro
	{
	}
}
