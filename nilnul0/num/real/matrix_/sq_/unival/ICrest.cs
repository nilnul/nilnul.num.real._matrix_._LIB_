using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.unival
{
	/// <see cref="sq_.IUnival"/>
	/// <summary>
	/// [
	///		a+x,	a,		a,...,	a,		a
	///		a,		a+x,	a,		a,		a
	///		a,		a,		a+x,	...,	a
	///		...
	///		a,		a,		a		...		a+x
	///		
	/// ]
	/// </summary>
	public interface ICrest
		:num.real.matrix_.ISquare
	{
	}
}
