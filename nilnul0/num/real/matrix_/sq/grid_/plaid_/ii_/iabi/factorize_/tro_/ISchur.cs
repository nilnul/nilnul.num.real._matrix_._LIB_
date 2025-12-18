using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.grid_.plaid_.ii_.iabi.factorize_.tro_
{
	/// <summary>
	/// [
	///		1,	A
	///		B,	1
	/// ]
	///  =
	///  [
	///		1,	0
	///		B,	1
	///  ]
	///  [
	///		1,	0
	///		0,	1-BA
	///  ]
	///  [
	///		1,	A
	///		0,	1
	///  ]
	///  =
	///  [
	///		1,	0
	///		B,	1-BA
	///	][
	///		1,	A
	///		0,	1
	///	]
	///	=[
	///		1,	A
	///		B,	1
	///	]
	///	=
	///	[
	///		1,	A
	///		0,	1
	///	][
	///		1-AB,	0
	///		0,		1
	///	][
	///		1,	0
	///		B,	1
	///	]
	///	=[
	///		1-AB,	A
	///		0,		1
	/// ][
	///		1,	0
	///		B,	1
	/// ]
	/// =[
	///		1,	A
	///		B,	1
	/// ]
	/// </summary>
	/// <remarks>
	///  corollary:
	///		determ(
	///	[
	///		1,	A
	///		0,	1
	///	][
	///		1-AB,	0
	///		0,		1
	///	][
	///		1,	0
	///		B,	1
	///	]
	///		)= determ(1-AB)
	///		=determ(
	///  [
	///		1,	0
	///		B,	1
	///  ]
	///  [
	///		1,	0
	///		0,	1-BA
	///  ]
	///  [
	///		1,	A
	///		0,	1
	///  ]
	///		)= determ(1-BA)
	///		<see cref="matrix_.sq.determ.theorem_.binary_.weinstein_.IPlusColMul"/>
	/// </remarks>
	/// <see cref="determ.theorem_.binary_.IWeinsteinAronszajn"/>
	internal class ISchur
	{
	}
}
