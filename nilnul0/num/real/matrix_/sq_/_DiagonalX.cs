using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_
{
	static public class _DiagonalX
	{
		static public Q[,] OfDiagonal(IEnumerable<Q> diag) {

			
			var r = num.real.matrix_._SquareX.Init8quotient(diag.Count());
			var i = 0;
			foreach (var x in diag)
			{
				r[i, i] = x;
				i++;

			}
			return r;
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfDiagonal(params Q[] diag) {
			return OfDiagonal(
				(IEnumerable<Q>) diag
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfDiagonal8quotient(IEnumerable<int> diag) {
			//return OfDiagonal((IEnumerable<Q>)diag); /// exception

			return OfDiagonal(diag.Select(x=>(Q)x ));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfDiagonal8quotient(params int[] diag) {
			return OfDiagonal8quotient(
				(IEnumerable<int>) diag
			);
		}


		static public double[,] OfDiagonal(IEnumerable<double> diag) {

			
			var r = num.real.matrix_._SquareX.Init8dbl(diag.Count());
			var i = 0;
			foreach (var x in diag)
			{
				r[i, i] = x;
				i++;

			}
			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfDiagonal(params double[] diag) {
			return OfDiagonal(
				(IEnumerable<double>) diag
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfDiagonal8dbl(IEnumerable<int> diag) {

			return OfDiagonal(diag.Cast<double>());
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfDiagonal8dbl(params int[] diag)
		{
			return OfDiagonal8dbl(
				(IEnumerable<int>)diag
			);
		}


	}
}
