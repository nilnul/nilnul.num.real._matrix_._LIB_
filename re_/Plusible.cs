using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{
	public class Plusible
		:
			nilnul.num.real.matrix.Re8dblI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool re(double[,] a, double[,] b)
		{
			return nilnul.obj.matrix.re_._SameSizeX.Re(a, b);

			return a.GetLength(0) == b.GetLength(0)
				&& a.GetLength(1) ==b.GetLength(1);
		}


		static public Plusible Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Plusible>.Unison;
			}
		}

	}
}
