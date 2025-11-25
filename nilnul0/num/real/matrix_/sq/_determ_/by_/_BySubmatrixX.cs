using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using P = nilnul.num.
using H = double;


namespace nilnul.num.real.matrix_.sq._determ_.by_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		<see cref="by_._ByRegenerateX"/> whileas this also regenerates index. Is it cheaper than <see cref="by_._ByRegenerateX"/> which regenerates the submatrix itself? it might be so, as index regenerated is linear + linear, not linear * linear.
	static public class _BySubmatrixX
	{
		static public Q _Determinant_0sq_1rows_2cols(Q[,] m, int[] rows, int[] cols)
		{

			int wide = rows.Length;

			//if (wide ==0)
			//{
			//	return 1;
			//}

			switch (wide)
			{
				case 0:
					return 1;
				case 1:
					return m[rows[0], cols[0]];
				case 2:
					{
						int r0 = rows[0];
						int r1 = rows[1];

						int c0 = cols[0];

						int c1 = cols[1];

						return m[r0, c0] * m[r1, c1] -m[r0, c1] * m[r1, c0];
					}
				case 3:
					{
						int r0 = rows[0];
						int r1 = rows[1];
						int r2 = rows[2];

						int c0 = cols[0];
						int c1 = cols[1];
						int c2 = cols[2];


						return m[r0, c0] * m[r1, c1]* m[r2, c2]
							+
							m[r0, c1] * m[r1, c2]* m[r2, c0]
							+
							m[r0, c2] * m[r1, c0]* m[r2, c1]

							-
							m[r0, c2] * m[r1, c1]* m[r2, c0]
							-
							m[r0, c1] * m[r1, c0]* m[r2, c2]
							-
							m[r0, c0] * m[r1, c2]* m[r2, c1]
						;
					}
					/// todo: width =4

					//default:

					//	break;

			}



			//H.NIL				
				;

			var row0 = rows[0];
			/// remove this row:
			/// 
			int[] newRows =
				 //rows[1..]
				 rows.Skip(1).ToArray()
			;

			var newCols = cols.Skip(1).ToArray();

			var r = m[
					 row0, cols[0]
			] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);


			//bool neg = false;
			bool pos = false;

			for (int i = 1; i < wide; i++)
			{
				newCols = cols.Where((e, ind) => ind!=i).ToArray();

				if (pos)
				{
					r += m[
						row0, cols[i]
					] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);

				}
				else
				{
					r -= m[
						row0, cols[i]
					] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);

				}
				pos=!pos;
				//neg=!neg;
			}

			return r;


		}

		static public H _Determinant_0sq_1rows_2cols(H[,] m, int[] rows, int[] cols)
		{

			int wide = rows.Length;

			//if (wide ==0)
			//{
			//	return 1;
			//}

			switch (wide)
			{
				case 0:
					return 1;
				case 1:
					return m[rows[0], cols[0]];
				case 2:
					{
						int r0 = rows[0];
						int r1 = rows[1];

						int c0 = cols[0];

						int c1 = cols[1];

						return m[r0, c0] * m[r1, c1] -m[r0, c1] * m[r1, c0];
					}
				case 3:
					{
						int r0 = rows[0];
						int r1 = rows[1];
						int r2 = rows[2];

						int c0 = cols[0];
						int c1 = cols[1];
						int c2 = cols[2];


						return m[r0, c0] * m[r1, c1]* m[r2, c2]
							+
							m[r0, c1] * m[r1, c2]* m[r2, c0]
							+
							m[r0, c2] * m[r1, c0]* m[r2, c1]

							-
							m[r0, c2] * m[r1, c1]* m[r2, c0]
							-
							m[r0, c1] * m[r1, c0]* m[r2, c2]
							-
							m[r0, c0] * m[r1, c2]* m[r2, c1]
						;
					}
					/// todo: width =4

					//default:

					//	break;

			}


			//H.NIL				
				;

			var row0 = rows[0];
			/// remove this row:
			/// 
			int[] newRows =
				 //rows[1..]
				 rows.Skip(1).ToArray()
			;

			var newCols = cols.Skip(1).ToArray();

			var r = m[
					 row0, cols[0]
			] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);


			//bool neg = false;
			bool pos = false;

			for (int i = 1; i < wide; i++)
			{
				newCols = cols.Where((e, ind) => ind!=i).ToArray();

				if (pos)
				{
					r += m[
						row0, cols[i]
					] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);

				}
				else
				{
					r -= m[
						row0, cols[i]
					] * _Determinant_0sq_1rows_2cols(m, newRows, newCols);

				}
				pos=!pos;
				//neg=!neg;
			}

			return r;


		}

		static public H _Determinant_0sq(H[,] m)
		{
			var wide = Enumerable.Range(0, m.GetLength(0)).ToArray();
			return _Determinant_0sq_1rows_2cols(
				m, wide, wide
			);
		}
		
		static public Q _Determinant_0sq(Q[,] m)
		{
			var wide = Enumerable.Range(0, m.GetLength(0)).ToArray();
			return _Determinant_0sq_1rows_2cols(
				m, wide, wide
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Q4 _Determinant_0sq(int[,] square)
		{
			return _Determinant_0sq(
				nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(square)
			);
		}
	}
}
