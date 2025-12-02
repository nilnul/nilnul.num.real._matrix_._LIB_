using nilnul.bit0nul.re_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq._determ_.by_
{
	static public class _ByMutateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// mutated equivolently
		/// </param>
		/// <returns></returns>
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

			var width = m.GetLength(0);


			for (int c = 0,cPlus=1; c < width; c++,cPlus++)
			{
				int r = c;
				for (; r < width; r++)
				{
					var pivot = m[r, c];
					if (pivot!=0)
					{
						if (r != c)
						{

							/// swap while negating one to keep the determ 
							/// 
							m[c, c] = pivot;
							m[r, c] =0;
							for (int i = cPlus; i < width; i++)
							{
								(m[c, i], m[r, i]) = (m[r, i], -m[c, i]);
							}
						}

						for (int remained = r+1; remained < width; remained++)
						{
							var pargon = m[remained, c];

							//real.matrix.op_.basic_._SkewX._Skew_12row_3nilish(
							//	ref m, remained, c,

							//	-pargon/pivot
							//);
							/// previous columsn neednot change:
							/// 

							if (pargon == 0) continue;
							m[remained, c] = 0;

							for (int i = cPlus; i < width; i++)
							{
								m[remained, i] -= m[c,i]/pivot * pargon;
							}
						}
						break;
					}
				}
				if (r == width)
				{
					return 0;
				}
			}

			var o = Q4.One;
			for (int i = 0; i < width; i++)
			{
				o*=m[i, i];
			}
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
