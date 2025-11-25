using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_._invert_.by_.gauss_
{

	///	<see cref="real.matrix.op_.dent_.echelon_.IVent"/> so we can convert A to an echelon, by <see cref="real.matrix.op_.IGaussian"/>
	///		
	///<summary>
	///claim:
	///		if V !=I, then invert doesnot exist.
	/// proof:
	///			A\I
	///			=
	///			GA \G
	///			= V\G
	///		, where V is <see cref="real.matrix.op_.dent_.echelon_.IVent"/>
	///		,G is <see cref="real.matrix.op_.IGaussian"/>
	///	;
	///		if V is not rankful, that means :
	///			VX=I has no solvent
	///			GAX = I  has no solvent.
	///			AX = I/G  has no solvent.
	///			assuming A\1 exists:
	///			A\ AX = I/G 
	///			=> X =I/G has solvent, contradiction 
	///			hence the assumption is false.
	///			hence A\1 doesnot exist.
	/// </summary>
	/// 
	/// alternatively?:
	///			assume A\1 exists
	///			X = A\1
	///			
	///			AX=I 
	///			GAX = G
	///			
	///			VX = G has no solvent,
	///			
	///			
	///			hence AX= I has no solvent, contradict to the presumption that A is invertible.
	/// 

	internal class IRowly
	{
	}
}
