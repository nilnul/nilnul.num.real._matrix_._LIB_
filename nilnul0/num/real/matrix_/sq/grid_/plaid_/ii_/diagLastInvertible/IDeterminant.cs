using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.grid_.plaid_.ii_.diagLastInvertible
{
	/// <summary>
	/// Y=
	///		A	B
	///		C	D
	///		,where A,D each is square
	///		,where D is invertible
	///	; then,
	///	X =
	///		E		-B/D
	///		0		E
	///	,
	///	Z =
	///		E			0
	///		-D\C		E
	/// ;
	/// 
	/// 
	/// XY =
	///		A-B/DC 				0
	///		C					D
	///;
	///
	/// XY Z =
	///		A-B/DC		0
	///		0			D
	/// 
	///	; then the determinant is:
	///		 | A - B /D  C|  |D|
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	internal class IDeterminant
	{
	}
}
