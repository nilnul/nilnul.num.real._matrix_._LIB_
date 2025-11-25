using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// [
	///		x0^0,x0^1, x0^2, .. x0^n
	///		x1^0, x1^1, ..., x1^n
	///		...
	///		xn^0, xn^1, ..., xn^n
	///		
	///	] =[
	///		y0
	///		y1
	///		.
	///		.
	///		.
	///		yn
	/// ]
	/// </summary>
	/// <remarks>
	/// for polynomial:
	///		a[0] + a[1] x + a[2] x^2 + ... + a[n] x^n
	///	, we know n+1 points, how to solve a[i]?
	///	;the pred is:
	/// [
	///		x0^0,x0^1, x0^2, .. x0^n
	///		x1^0, x1^1, ..., x1^n
	///		...
	///		xn^0, xn^1, ..., xn^n
	///	] 
	///	[
	///		a0,
	///		a1,
	///		a2,
	///		.
	///		.
	///		.
	///		a[n]
	///	]
	///	= [
	///		y0,
	///		y1,
	///		y2,
	///		.
	///		.
	///		.
	///		yn
	///	]
	///  , and we can solve a.
	///		
	/// </remarks>
	/// 
	/// <!---->
	static public class _VandermondeX
	{
		static public double[,] Matrix(IEnumerable<double> x) {

			int dimension = x.Count();

			//int dimensionMinus = dimension - 1;

			var r = nilnul.num.real.matrix_._SquareX.Init8dbl(
				dimension

			);
			//if (dimension==0)
			//{
			//	return r;
			//	//return new double[0,0];
			//}

			var enumerator = x.GetEnumerator();


			for (int row = 0; row < dimension; row++)
			{	
				enumerator.MoveNext();

				var val =
					//x.ElementAt(row)
					enumerator.Current
				;

				var cel = 1d;
				r[row, 0] = cel;
	
				for (int col = 1; col < dimension; col++)
				{
					r[row, col] = cel*= val;
				}
			}
			return r;
		}

		/// <summary>
		/// Product(
		///		x[j] - x[i]
		///	)
		///		,where j gt i
		///	; totally there are  w(w-1) /2 factors
		///		,where w is the width of the matrix.
		/// </summary>
		/// <param name="x">
		/// the length is the width of the matrix.
		/// </param>
		/// <returns></returns>
		static public Q[,] Generate(IEnumerable<Q> x) {

			int dimension = x.Count();

			//int dimensionMinus = dimension - 1;

			var r = nilnul.obj.matrix_._SquareX._Init_0width<Q>(
				dimension

			);

			//if (dimension==0)
			//{
			//	return r;
			//	//return new double[0,0];
			//}

			var enumerator = x.GetEnumerator();

			for (int row = 0; row < dimension; row++)
			{
				enumerator.MoveNext();
				var val = 
					///x.ElementAt(row)
					enumerator.Current
				;

				Q cel = 1;
				r[row, 0] = cel;
	
				for (int col = 1; col < dimension; col++)
				{
					r[row, col] = cel*= val;
				}
			}
			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Generate(params Q[] x) {

			return Generate(
				(IEnumerable<Q>)x	
			);
		}

	}
}
