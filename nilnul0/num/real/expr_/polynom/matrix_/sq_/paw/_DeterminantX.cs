using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.paw
{


	/// <see cref="num.real.matrix_.sq_.paw._DeterminantX"/>
	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public expr_.algebraic.Frac _Determinant_0paw(num.real.expr_.Algebraic[,] m)
		{

			IEnumerable<int> torso = Enumerable.Range(1, m.GetLength(0)-1);
			return bi_.mul.cumula.Cumulate.Singleton.cumulate(
					obj.matrix_.sq._DiagonalX._Diagonal_0sq(m)
				)
				-/// the permutation each is negative, as two inside are swapped:
				bi_.add.cumula.Cumulate.Singleton.cumulate(
					torso.Select(
						t=> m[0,t]
						*m[t,0]
						*
						bi_.mul.cumula.Cumulate.Singleton.cumulate(
							torso.Where( j=>j!=t).Select(
								k => m[k,k]
							)
						)
					)
			);
		}
	}
}