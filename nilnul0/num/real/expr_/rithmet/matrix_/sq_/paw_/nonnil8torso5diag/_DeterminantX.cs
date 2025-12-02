using nilnul.num.real.expr_.algebraic;
using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.rithmet.matrix_.sq_.paw_.nonnil8torso5diag
{

	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// each cel at the torso of the diagonal is not 0;
		/// </summary>
		/// <param name="fracs"></param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public expr_.algebraic.Frac _Determinant_0pawNonnil8diag5torso(num.real.expr_.algebraic.Frac[,] fracs)
		{

			int height = fracs.GetLength(0);
#if DEBUG && false
			for (int c = 1; c<height; c++)
			{
				var amplitude = fracs[c, 0]/fracs[c, c];
				///colwise
				///
				int r = 0;
				for (; r<c; r++)
				{
					fracs[r, 0] -= amplitude* fracs[r, c];
				}

				fracs[r++, 0] = num.real.expr_.algebraic.Frac.Nil;

				for (; r<height; r++)
				{
					fracs[r, 0] -= amplitude * fracs[r, c];
				}

			}/// it becomes upper:


#endif

			return nilnul.num.real.expr_.algebraic.frac.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(
				Enumerable.Range(1,height-1).Select(i=> fracs[i,i])	/// diag torso
				.Append(
					fracs[0,0]-nilnul.num.real.expr_.algebraic.frac.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
						Enumerable.Range(1,height-1).Select(i=> fracs[i,0] *  fracs[0,i] / fracs[i,i])
					)
					/// diag head
				)
			);



		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Frac _Determinant_0pawNonnil8diag5torso(A[,] m)
		{
			
			return _Determinant_0pawNonnil8diag5torso(
				matrix._OfX.ToFracs(m)
			);
		}
	}
}
