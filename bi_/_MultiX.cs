using nilnul.obj.matrix.co.be_.multible.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
//using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.bi_
{
	/// <summary>
	/// throw exception if the input is not <see cref="matrix.re_.IMultible"/> ( the 1st's width doesnot equal to the height of the second matrix.)
	/// </summary>
	/// <see cref="matrix.co_.multible._MultiX"/>
	static public class _MultiX
	{


		/// <summary>
		/// a horizontal vector times a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[] _Multiply_1sociable(this double[] a, double[,] b)
		{
			double[] c = new double[b.GetLength(1)];//every element has been initialized to 0.
			for (uint j = 0; j < c.Length; j++)
			{
				for (uint i = 0; i < b.GetLength(0); i++)
				{
					c[j] += a[i] * b[i, j];
				}
			}
			return c;
		}

		public static Q[] _Multiply_1sociable(this Q[] a, Q[,] b)
		{
			int cols = b.GetLength(1);

			var c = new Q[cols];
			int rows = b.GetLength(0);

			for (int j = 0; j < cols; j++)
			{
				c[j] =0;

				for (int i = 0; i < rows; i++)
				{
					c[j] += a[i] * b[i, j];
				}
			}
			return c;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b">a col</param>
		/// <returns></returns>
		public static Q[] _Multiply_1sociable(this Q[,] a, Q[] b)
		{
			int rows = a.GetLength(0);
			var c = new Q[rows];

			int cols = a.GetLength(1);

			for (int j = 0; j < rows; j++)
			{
				c[j] =0;
				for (int i = 0; i < cols; i++)
				{
					c[j] += a[j, i]*b[i];
				}
			}
			return c;
		}




		public static double[,] _Multiply_1sociable(this double[,] a, double[,] b)
		{

			double[,] c = new double[a.GetLength(0), b.GetLength(1)];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{

				for (int j = 0; j < c.GetLength(1); j++)
				{
					c[i1, j] = nilnul.num.real.str.duo.sameLen.Multi._Eval(
						a, i1, b, j
					);

				}

			}

			return c;

		}
		public static Q[,] _Multiply_1sociable(this Q[,] a, Q[,] b)
		{

			int height = a.GetLength(0);
			int width = b.GetLength(1);

			var c = new Q[height, width];


			for (int i1 = 0; i1 < height; i1++)
			{

				for (int j = 0; j < width; j++)
				{
					c[i1, j] = nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(
						nilnul.obj.matrix._RowsX.Row(a, i1)
						,
						nilnul.obj.matrix._ExtensionsX.Col(b, j)

					);	/// this would be 0, when each arg is empty.

				}

			}

			return c;

		}

		public static R[,] _Multiply_1sociable(this R[,] a, R[,] b)
		{

			int rows = a.GetLength(0);

			int cols = b.GetLength(1);

			var c = new R[rows, cols];


			for (int i1 = 0; i1 < rows; i1++)
			{

				for (int j = 0; j < cols; j++)
				{
					c[i1, j] = nilnul.num.real.vec.co._InnerProductX._InnerProduct_assumeEquisize(

						nilnul.obj.matrix._RowsX.Row(a, i1)
						,
						nilnul.obj.matrix._ExtensionsX.Col(b, j)
					);

				}

			}

			return c;

		}
		public static int[,] _Multiply_1sociable(this int[,] a, int[,] b)
		{

			int rows = a.GetLength(0);

			int cols = b.GetLength(1);

			var c = new int[rows, cols];//every element has been initialized to 0.

			for (int i1 = 0; i1 < rows; i1++)
			{

				for (int j = 0; j < cols; j++)
				{
					c[i1, j] = nilnul.num.real.vec.co._InnerProductX._InnerProduct_assumeEquisize(

						nilnul.obj.matrix._RowsX.Row(a, i1)
						,
						nilnul.obj.matrix._ExtensionsX.Col(b, j)
					);

				}

			}

			return c;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="_b_lengthEqAWidth">col</param>
		/// <returns></returns>
		public static double[] _Multiply_1sociable(this double[,] a, double[] _b_lengthEqAWidth)
		{

			double[] r = new double[_b_lengthEqAWidth.Length];//every element has been initialized to 0.


			for (int i1 = 0; i1 < r.GetLength(0); i1++)
			{

				r[i1] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
					a, i1, _b_lengthEqAWidth
				);



			}

			return r;

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix">n*m</param>
		/// <param name="col">
		///m*1. as a vec, its arity is m
		/// </param>
		/// <returns>
		/// n*1; a vec of n.
		/// </returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IEnumerable<double> _Multiply_1sociable(
			this IEnumerable<IEnumerable<double>> matrix
			,
			 IEnumerable<double> col
		)
		{
			return matrix.Select(
				r =>
				num.real.str.co_.sameLen._InnerProductX._Eval(r, col)
			);
		}

		public static float[] _Multiply_1sociable(this float[,] a, float[] b)
		{

			float[] c = new float[a.Length];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{

				c[i1] += nilnul.num.real.str.duo.sameLen.Multi._Eval(
					a, i1, b
				);



			}

			return c;

		}


		public static uint[,] _Multiply_1sociable(this uint[,] a, uint[,] b)
		{

			uint[,] c = new uint[a.GetLength(0), b.GetLength(1)];

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < b.GetLength(1); j++)
				{

					for (int k = 0; k < a.GetLength(1); k++)
					{
						c[i, j] += a[i, k] * b[k, j];

					}

				}

			}
			return c;
		}

		public static int[,] Multiply(this int[,] a, int[,] b)
		{

			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception(" the length of a.component is not the same as that of b.component.");
			}

			return _Multiply_1sociable(a, b);


		}
		public static Q[,] Multiply(this Q[,] a, Q[,] b)
		{

			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception(" the length of a.component is not the same as that of b.component.");
			}

			return _Multiply_1sociable(a, b);


		}


		public static uint[,] Multiply(this uint[,] a, uint[,] b)
		{

			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception(" the length of a.component is not the same as that of b.component.");
			}

			return _Multiply_1sociable(a, b);


		}



		public static ulong[,] _Multiply_1sociable(this ulong[,] a, ulong[,] b)
		{




			ulong[,] c = new ulong[a.GetLength(0), b.GetLength(1)];

			for (int i = 0; i < c.GetLength(0); i++)
			{
				for (int j = 0; j < c.GetLength(1); j++)
				{

					for (int k = 0; k < a.GetLength(1); k++)
					{
						c[i, j] += a[i, k] * b[k, j];

					}

				}

			}
			return c;


		}

		public static ulong[,] Multiply(this ulong[,] a, ulong[,] b)
		{


			var gageLen = a.GetLength(1);

			if (gageLen != b.GetLength(0))
			{
				throw new Exception("a.N!=b.M.");

			}


			return _Multiply_1sociable(a, b);


		}

		public static double[,] Multiply(this double[,] a, double[,] b)
		{



			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new ArgumentException("a.N!=b.M.");

			}

			return _Multiply_1sociable(a, b);

		}
		public static double[] Multiply(this double[,] a, double[] b)
		{



			if (a.GetLength(1) != b.Length)
			{
				throw new ArgumentException("the column's length must be the width of the matrix;");

			}

			return _Multiply_1sociable(a, b);

		}
		public static double[] Multiply(this double[] a, double[,] b)
		{



			if (a.Length != b.GetLength(0))
			{
				throw new ArgumentException("the row's length must be the height of the matrix;");

			}

			return _Multiply_1sociable(a, b);

		}




	}
}
