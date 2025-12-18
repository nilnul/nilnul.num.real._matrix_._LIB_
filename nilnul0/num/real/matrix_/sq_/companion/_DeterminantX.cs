using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.companion
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///  for companion matrix, a0 is always standalone in a corner.
	/// </remarks>
	static public class _DeterminantX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="coefs"></param>
		/// <returns></returns>
		static public Q4 _OfStdCoefs(
			Q4[] coefs
		)
		{
			if (coefs.Any())
			{
				return coefs[0];	/// the companion matrix contains a0 somewhere like: [...a0]
			}

			/// the degree is 0; hence it's <see cref="num.real.expr_.polynom_.IPreliminary"/>. but it's standard, so it's 1.
			return 1;	/// the companion matrix is [].

		}
	}
}
