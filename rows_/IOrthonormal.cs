using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.rows_
{
	/// <see cref="num.real.vecs.be_.IIndependent"/>
	/// <summary>
	/// the rows are orthonormal;
	/// </summary>
	/// <remarks>
	/// this implies that the count of rows cannot exceed the width.
	/// So this matrix must be unthin:<see cref="nilnul.num.real.matrix_.unthin"/>.
	/// </remarks>
	public interface IOrthonormal:matrix.IRows
	{
	}
}
