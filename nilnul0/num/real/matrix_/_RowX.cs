using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_
{

	static public class _RowX
	{
		static public double[,] Matrix4dbl(IEnumerable<double> str) {
			var c = str.Count();
			var r = new double[1, c];

			for (int i = 0; i < c; i++)
			{
				r[0, i] = str.ElementAt(i);

			}
			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Matrix4dbl(params double[] str) {
			return Matrix4dbl(
				(IEnumerable<double>)str
			);
		}

		static public Q[,] OfRow(IEnumerable<Q> str) {
			var c = str.Count();
			var r = new Q[1, c];

			var i= 0;
			foreach (Q q in str)
			{
				r[0,i] = q; i++;
			}
			return r;
	
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRow(params Q[] str) {
			return OfRow(
				(IEnumerable<Q>)str
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRow8quotient(IEnumerable< int> str) {
			return OfRow(
				str.Select(i=>(Q)i)
				//(IEnumerable<Q>)str
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRow8quotient(params int[] str) {
			return OfRow8quotient(
				(IEnumerable<int>)str
			);
		}


	}
}
