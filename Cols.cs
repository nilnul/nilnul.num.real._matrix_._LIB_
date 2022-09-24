using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix
{
	/// <summary>
	/// convert <see cref="IMatrix"/> to a str of vec colwisely -- each col is a vec
	/// </summary>
	public interface ICols
		:
		num.real.vec.IStr
	{
	}
}
