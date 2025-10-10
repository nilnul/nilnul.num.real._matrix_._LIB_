using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{

	static public class _ColX
	{
		static public double[,] Matrix4dbl(IEnumerable<double> str) {
			var c = str.Count();
			var r = new double[ c,1];

			for (int i = 0; i < c; i++)
			{
				r[ i,0] = str.ElementAt(i);

			}
			return r;
		}
		static public double[,] Matrix4dbl(params double[] str) {
			return Matrix4dbl(
				(IEnumerable<double>)str
			);
		}


		static public Q[,] OfCol(IEnumerable<Q> str)
		{
			var c = str.Count();
			var r = new Q[c,1];

			var i = 0;
			foreach (Q q in str)
			{
				r[i, 0] = q; i++;
			}
			return r;

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfCol(params Q[] str)
		{
			return OfCol(
				(IEnumerable<Q>)str
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfCol8quotient(IEnumerable<int> str)
		{
			return OfCol(
				str.Select(i=> (Q)i)
				/// (IEnumerable<Q>)str
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfCol8quotient(params int[] str)
		{
			return OfCol8quotient(
				(IEnumerable<int>)str
			);
		}


	}
}
