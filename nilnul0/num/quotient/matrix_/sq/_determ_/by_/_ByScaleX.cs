using nilnul.bit0nul.re_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq._determ_.by_
{
	/// <see cref="num.real.matrix_.sq_.diag_.scaler_.IUnnil"/>
	/// 
	/// <see cref="num.real.matrix_.sq_.diag_.IShred"/>
	/// <see cref="num.real.matrix_.sq.factorize_.IDeterminantPreserving"/>
	/// <summary>
	///  extract the scale when doing <see cref="sq.op_.IVertible"/>
	/// 
	/// </summary>
	static public class _ByScaleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// mutated equivolently
		/// </param>
		/// <returns>
		/// the spinoff. the extracted coef.
		/// </returns>
		static public Q4 _Determinant_0sq(ref Q4[,] m)
		{
			/// mutate the matrix as <see cref="num.quotient.matrix_.sq.be_.triag_.IUpper"/>
			/// 
			/// when one col start from the expected diag, is all 0:
			/// 

			/// swap two rows when the pivot of the next top row is 0:
			///		,at the same time: negate the new top row, so to keep the determ the same
			///		

			/// don't scale the row
			/// 

			/// merge rows, and the determ will remain unchanged.
			/// <see cref="nilnul.num.real.matrix.op_._DentX"/>


			// get the first col
			// long col = 0;
			//	long row = 0;

			var o = Q4.One;
			var rows = m.GetLength(0);

			//var rank = 0;

			for (int c = 0,cPlus=1; c < rows; c++,cPlus++)
			{
				int r = c;

				//Q4 pivot = 0;
				for (; r < rows; r++)
				{
					Q4 pivot = m[r, c];
					if (pivot!=0)
					{
						m[c, c] =1;

						///swap
						if (r == c)
						{
							for (int i = cPlus; i < rows; i++)
							{
								m[c, i] /= pivot;
							}
							o *= pivot;
						}
						else // scale the paragon.
						/// not at the diag
						{
							m[r, c] =0;
							/// swap while negating one to keep the determ 
							/// 
							for (int i = cPlus; i < rows; i++)
							{
								(m[c, i], m[r, i]) = (m[r, i]/pivot, m[c, i]);
							}
							o *= -pivot;
						}

						for (int remained = r+1; remained < rows; remained++)
						{
							//real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
							//	ref m
							//	, remained
							//	, c
							//	,
							//	m[remained, c]
							//);
							/// we don't need to tack previous columns
							/// 

							var pargonRemained = m[remained, c];

							if (pargonRemained == 0) continue;

							m[remained, c] = 0;
							for (int i = cPlus; i < rows; i++)
							{
								m[remained, i] -= m[c,i] * pargonRemained;
							}


						}
						break;
					}

				}
				if (r == rows)
				{
					return 0;
				}
			}

			//for (int i = 0; i < rows; i++)
			//{
			//	o*=m[i, i];
			//}
			return o;

		}
		static public Q4 _Determinant_0sq(Q4[,] m)
		{
			var c = (Q4[,])m.Clone();
			return _Determinant_0sq(ref c);


		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determinant_0sq(
			int[,] square
		)
		{
			Q4[,] m = nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(square);/// we need division.
			return _Determinant_0sq(
				ref m
			);

			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
		}

	}
}
