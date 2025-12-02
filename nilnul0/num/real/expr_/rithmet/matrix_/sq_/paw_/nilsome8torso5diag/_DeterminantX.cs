using nilnul.num.real.expr_.algebraic;
using nilnul.txt_.names.fro_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.rithmet.matrix_.sq_.paw_.nilsome8torso5diag
{

	/// <summary>
	/// </summary>
	static public class _DeterminantX
	{
		/// <summary>
		/// some cel at the torso of the diagonal is 0;
		/// </summary>
		/// <param name="fracs"></param>
		/// <param name="p">m[p,p] is 0</param>
		/// <returns></returns>
		/// <see cref="real.matrix_.sq_.triag._DeterminantX"/>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public expr_.algebraic.Frac _Determinant_0paw_1nil8torso5diag(num.real.expr_.algebraic.Frac[,] fracs, int p)
		{

			//int height = fracs.GetLength(0);
			int heightMinus = fracs.GetLength(0)-1;

#if DEBUG && false || true0
			/// <see cref="num.real.matrix_.sq._determ_.by_.IByPermutation"/>:
			/// 
			return real.expr_.algebraic.frac.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(
				Enumerable.Range(0, height).Select(i => fracs[i, i])  /// diag 
			) - 
			real.expr_.algebraic.frac.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
					Enumerable.Range(1, height-1).Select(
							i => fracs[i, 0] 
							*  fracs[0, i]  /// the two swapped, hence the permutation is negated
							*
							real.expr_.algebraic.frac.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(
								Enumerable.Range(1, height-1).Where( j=> j!=i).Select(
									k=> fracs[k,k]
								)
							)
					)
				/// diag head
			)
			;  /// when fracs[i,i] is 0, then this becomes:

#endif

			return -fracs[p, 0] 
					*  fracs[0, p]  /// the two swapped, hence the permutation is negated
					*
					real.expr_.algebraic.frac.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(
						Enumerable.Range(1, heightMinus).Where( j=> j!=p).Select(
									k=> fracs[k,k]
						)
					)
			;  /// only this permutation is not 0. 
			/// per another perspective, if a[p,p] is 0, then for the r[p], we have only m[p,0] as not 0. and once we choose m[p,0], the for col p, the only unnil is m[0,p]. Then the only permutation is:
			/// m[p,0] m[0,p] m[1,1]...m[p-1,p-1] m[p+1,p+1]...m[n-1,n-1]

			/// when there are two 0s at the torso, then the determinant is 0



		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Frac _Determinant_0paw_1nil8torso5diag(A[,] m, int indexOfNil)
		{
			
			return _Determinant_0paw_1nil8torso5diag(
				matrix._OfX.ToFracs(m),indexOfNil
			);
		}
	}
}
