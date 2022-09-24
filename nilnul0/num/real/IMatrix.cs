using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// real[,]
	/// </summary>
	public interface IMatrix
		:
		nilnul.obj.IMatrix
		,
		nilnul.num.real.vec.IStr /// defaulted as rowwise; for colwise <see cref="matrix.ICols"/>
	{
	}
}
