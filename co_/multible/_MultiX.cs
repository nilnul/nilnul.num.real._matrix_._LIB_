using nilnul.obj.matrix.co.be_.multible.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using R2 = nilnul.num.Real;


namespace nilnul.num.real.matrix.co_.multible
{
	static public class _MultiX
	{

		public static R2[,] _Multiply_assumeSociable(this R2[,] a, R2[,] b)
		{

			var c = new R2[a.GetLength(0), b.GetLength(1)];//every element has been initialized to 0.


			for (int i1 = 0; i1 < c.GetLength(0); i1++)
			{

				for (int j = 0; j < c.GetLength(1); j++)
				{
					c[i1, j] = new R2(nilnul.num.real.str.co_.sameLen._MultiX._Multi_ofTwoSameLengthStr(
						nilnul.collection.matrix.MatrixX.Row(
						a, i1).Select(x => x.boxed)
						,
						nilnul.collection.matrix.MatrixX.Column(
						b, j).Select(x => x.boxed)
					));

				}

			}

			return c;

		}
		public static Matrix4dbl Multi(Ee<double> ee)
		{
			return _Multiply_assumeSociable(ee.eeByRef.Item1, ee.eeByRef.Item2);
		}

		public static Matrix4dbl Multi(Matrix4dbl a, Matrix4dbl b)
		{
			return Multi(
				new obj.matrix.co.be_.multible.vow.Ee<double>(a,b)
			);

		}


		/// <summary>
		/// a horizontal vector times a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[] _Multiply_assumeSociable(this double[] a, double[,] b)
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


		public static double[,] _Multiply_assumeSociable(this double[,] a, double[,] b)
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="_b_lengthEqAWidth">col</param>
		/// <returns></returns>
		[Obsolete(nameof(num.real.vec.str.accumulate_._LinearCombinateX._LinearCombinateAsNulable_assumeEquicount))]
		public static double[] _Multiply_assumeSociable(this double[,] a, double[] _b_lengthEqAWidth)
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
		public static IEnumerable<double> _Multiply_assumeSociable(
			this IEnumerable<IEnumerable<double>> matrix
			,
			 IEnumerable<double> col
		)
		{
			return matrix.Select(
				r=>
				num.real.str.co_.sameLen._InnerProductX._Eval(r,col)
			);
		}

		public static float[] _Multiply_assumeSociable(this float[,] a, float[] b)
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


		public static uint[,] _Multiply_assumeSociable(this uint[,] a, uint[,] b)
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

		public static uint[,] Multiply(this uint[,] a, uint[,] b)
		{

			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception(" the length of a.component is not the same as that of b.component.");
			}

			return _Multiply_assumeSociable(a, b);





		}


		public static ulong[,] _Multiply_assumeSociable(this ulong[,] a, ulong[,] b)
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


			return _Multiply_assumeSociable(a, b);


		}


	}
}
