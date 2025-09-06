using nilnul.num.real.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.sq_
{


	/// <summary>
	/// 
	/// </summary>
	static public class _CanonicalX
	{
		static public double[,] Generate(int size) {


			var raw = _DefaultedX.Generate(size);

			for (int i = 0; i < size; i++)
			{
				raw[i, i] = 1;
				
			}
			return raw;
		}
		static public Q[,] Generate8quotient(int size) {

			var r = new Q[size, size];

			for (int i = 0; i < size; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					r[i, j] = 0;
				}
				r[i, j++] = 1;

				for (; j < size; j++)
				{
					r[i, j] = 0;
				}


			}
		
			return r;
		}


		static public R[,] GenerateAsReals(int size) {

			var r = new R[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					r[i, j] = nilnul.num.real_.Quotient_denomNonnil.Nil;
				}

				r[i, i] = nilnul.num.real_.Quotient_denomNonnil.One;

				for (int j = i+1; j < size; j++)
				{
					r[i, j] = nilnul.num.real_.Quotient_denomNonnil.Nil;
				}

			}

			return r;

		}
		static public int[,] GenerateAsInts(int size) {

			var r = new int[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					r[i, j] = 0;
				}

				r[i, i] =1;

				for (int j = i+1; j < size; j++)
				{
					r[i, j] = 0;
				}

			}

			return r;

		}


	}




}
