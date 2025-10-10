using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.co_.multible.prod.transposed.be_.backdist
{
	/// <summary>
	/// (ab)^T = b^T a^T
	///		,just like back walking an elbow
	/// ,
	///  for sizes:
	///		left hand side: (m*n, n*p  )^T = (m*p)^T = p*m
	///		right hand side: (p*n, n*m) = p*m
	/// </summary>
	public interface ITheorem
	{
	}
}
