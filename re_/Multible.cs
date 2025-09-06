using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{


	public class Multible
		:
			nilnul.num.real.matrix.Re8dblI
	{
		/// <summary>
		/// if we write the dimensions in the order of
		///		[r,c], where r as the major (eg: for x = a str of strs, then major is x.count) order is listed first,
		///	, then [r,c] * [c, d], where we can view the same 'c' as the hookup to chain.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool re(double[,] a, double[,] b)
		{
			return nilnul.obj.matrix.re_._MultibleX.Re(a, b);
			return a.GetLength(1) == b.GetLength(0);
		}


		static public Multible Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Multible>.Unison;
			}
		}

	}
}
