using nilnul.bit0nul.re_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq.be_._invertible_.by_
{
	static public class _ByDeterminantX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// mutated as long as one col has 0 at the diagonal;
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		/// <see cref="nilnul.num.quotient.matrix_.sq._determ_.by_._ByScaleX"/>
		static public bool _IsInvertible_0sq(ref Q4[,] m)
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


			var rows = m.GetLength(0);

			for (int c = 0, cPlus = 1; c < rows; c++, cPlus++)
			{
				int r = c;
				for (; r < rows; r++)
				{
					var pivot = m[r, c];

					if (pivot!=0)
					{
						m[c, c] = 1;
						if (r == c)
						{
							if (pivot !=1)
							{
								for (int i = c+1; i < rows; i++)
								{
									m[c, i] /=pivot;
								}

							}

						}
						else
						{
							/// swap
							/// 
							m[r, c] =0;

							for (int i = c+1; i < rows; i++)
							{
								(m[c, i], m[r, i]) = (m[r, i]/pivot, m[c, i]);
							}
						}
						for (int remained = r+1; remained < rows; remained++)
						{
							Q4 pargon = m[remained, c];
							if (pargon == 0)
							{
								continue;
							}
							m[remained, c] =0;

							for (int i = cPlus; i < rows; i++)
							{
								m[remained, i] -= m[c,i] * pargon;
							}

							//real.matrix.op_.basic_._SkewX._Skew_12row_3nilish(
							//	ref m, remained, c,
							//	-pargon/pivot
							//);

						}
						break;
					}
				}
				if (r == rows)
				{
					return false; /// one col has 0 at the diagonal
				}
			}

			return true;

		}
		static public bool _IsInvertible_0sq(Q4[,] m)
		{
			var c = (Q4[,])m.Clone();
			return _IsInvertible_0sq(ref c);

		}
	}
}
