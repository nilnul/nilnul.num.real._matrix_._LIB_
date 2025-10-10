using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using P = nilnul.num.
using H = double;


namespace nilnul.num.real.matrix_.sq._determ_.by_
{
	static public class _BySubmatrixX
	{
		static public H _Determinant_0equilat_1rows_2cols(H[,] m, int[] rows, int[] cols)
		{

			int wide = rows.Length;

			if (wide ==0)
			{
				return 1;
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

			var r =	m[
					 row0, cols[0]
			] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);


			//bool neg = false;
			bool pos = false;

			for (int i = 1; i < wide; i++)
			{
				newCols = cols.Where((e, ind) => ind!=i).ToArray();

				if (pos)
				{
					r += m[
						row0, cols[i]
					] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);

				}
				else
				{
					r -= m[
						row0, cols[i]
					] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);

				}
				pos=!pos;
				//neg=!neg;
			}

			return r;


		}

		static public Q _Determinant_0equilat_1rows_2cols(Q[,] m, int[] rows, int[] cols)
		{

			int wide = rows.Length;

			if (wide ==0)
			{
				return 1;
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

			var r =	m[
					 row0, cols[0]
			] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);


			//bool neg = false;
			bool pos = false;

			for (int i = 1; i < wide; i++)
			{
				newCols = cols.Where((e, ind) => ind!=i).ToArray();

				if (pos)
				{
					r += m[
						row0, cols[i]
					] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);

				}
				else
				{
					r -= m[
						row0, cols[i]
					] * _Determinant_0equilat_1rows_2cols(m, newRows, newCols);

				}
				pos=!pos;
				//neg=!neg;
			}

			return r;


		}

		static public H _Determinant_0equilat(H[,] m)
		{
			var wide = Enumerable.Range(0, m.GetLength(0)).ToArray();
			return _Determinant_0equilat_1rows_2cols(
				m, wide	,wide
			);
		}
		static public Q _Determinant_0equilat(Q[,] m)
		{
			var wide = Enumerable.Range(0, m.GetLength(0)).ToArray();
			return _Determinant_0equilat_1rows_2cols(
				m, wide	,wide
			);
		}


	}
}
