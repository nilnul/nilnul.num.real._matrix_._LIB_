using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.canon.elementary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		swallow
	///		shear
	static public class _ShearX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="size"></param>
		/// <param name="i"></param>
		/// <param name="any">can be nil</param>
		/// <returns></returns>
		static public double[,] _Generate_assumeValid(int size, int i, int j, double any)
		{
			var r = square_.Canonic.Create(size);
			real.matrix.op_.unary_.elementary_.rowwise_._SlantX._Act_rowAssumeIn_ratioAssumeNonnil(
				in r
				,
				in i
				,
				in j
				,
				in any
			   );
			return r;

		}
	}
}
