using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.obj.matrix_.sq_.toeplitz_
{
	static public class _CirculantX
	{
		static public T[,] _ToCirculant_0row1st<T>(in T[] row)
		{
			var n = row.Length;

			///<see cref="num.real.expr_.polynom.matrix_.sq.be_._ToeplitzX"/>
			var m = new T[n, n];


			for (int i = 0; i<n; i++) /// the index of first row:
			{
				var pargon = row[ i];

				for (int r = 0, c = i;  c<n; r++, c++)
				{

					m[r, c] =  pargon;
					
				}

			}
			for (int i = 1; i<n; i++) /// the first col:
			{
				var pargon = row[i];

				for (int c = 0, r = i; r < n ; r++, c++)
				{

					m[r, c] =  pargon;
				}



			}
			return m;

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public T[,] _ToCirculant_0row1st<T>(in IEnumerable< T> row)
		{
			
			return _ToCirculant_0row1st(row.ToArray());

		}

	
	}
}
