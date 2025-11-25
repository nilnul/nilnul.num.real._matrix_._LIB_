using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.isosize.bi_.mul.ret.determ.be_.distro
{
	/// <see cref=""/>
	/// <summary>
	/// proof:
	///		for <see cref="matrix_.trape_.IRight"/>s | <see cref="matrix_.sq_.isosize_.triag_.IUpper"/>, the claim holds. <see cref="matrix_.sq_.isosize_.triag_.upper.bi_.mul.ret.determ.be_.distro.ITauto"/>
	///		for general matrix, we just transform <var>a</var> by:
	///			ca
	///				,where c means either: switch two rows, but change the sign of one row
	///				,or scale one row and add that to another row
	///				# <see cref="num.real.matrix.op_.IIndent"/>
	///			, c will not change the determ, but will change a to upper triag.
	///			
	///  | cab d^T  |
	///  = |ab|
	///  
	///   = |ca    (b d^T)|
	///   = |ca|  |b d^T|
	///   = |a| |b|
	///	;
	///	proof1:
	///		lemma:
	///		
	///		|EB| = |E||B|
	///			,where E is <see cref="num.real.matrix_.sq_.IElemental"/> 
	///		,as verified by <see cref="matrix_.sq.op_.gauss_"/>
	///		lemma1:
	///			|BE| = |E||B|
	///	; then if A is invertible, 
	///		, per: <see cref="num.real.matrix_.sq_.invertible."/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	/// 
	/// <see cref="sq_.isosize.calc_.mul.det.theorem_.IDistro"/>
	/// 
	/// corollary:
	///		det(AB) = det(BA)
	///			, <see cref="matrix_.sq.op_.transpose.ret.determ.theorem_.ISameAsUntransposed"/>
	///			, det(AB) = det( (AB)^T ) = det( B^T A^T)

	internal class ITauto
	{
	}
}
