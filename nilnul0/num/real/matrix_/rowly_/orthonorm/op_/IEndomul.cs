using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.rowly_.orthonorm.op_
{
	/// <see cref="num.real.matrix.op_.IEndoMultiply"/>
	/// <summary>
	/// A A^T, which is <see cref="real.matrix_.sq_.ICanonic"/>
	/// </summary>
	/// <remarks>
	/// the result:<see cref="matrix_.sq_.ICanonic"/> is also <see cref="rowly_.IOrthonormal"/>
	/// </remarks>
	public interface IEndomul
		:num.real.matrix.op_.IEndoMultiply
	{
	}
}
