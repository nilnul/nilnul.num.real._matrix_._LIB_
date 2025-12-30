using nilnul.num.quotient.str;
using nilnul.num.real.expr_.algebraic;
using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.matrix_.sq_.paw
{

	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// some cel at the torso of the diagonal might be 0;
		/// </summary>
		/// <param name="paw"></param>
		/// <param name="index">m[p,p] is 0</param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determinant_0paw(Q4[,] paw)
		{
			return paw.GetLength(0) == 0 ? (Q4.One) : sq_.dwelt_.paw._DeterminantX._Determinant_0paw(paw);

		}

	}
}
