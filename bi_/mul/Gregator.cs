using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using T = double[,];
using I = int[,];

namespace nilnul.num.real.matrix.bi_.mul
{
	/// <see cref="nilnul.obj.op_.binary_.associative"/>
	/// <summary>
	/// exception would be thrown if the adajcent opearands are not chainable.
	/// </summary>
    static public class _GregatorX
    {
		static public int[,] Gregate(int[,] a, IEnumerable< int[,]> torso) {
			var r = a;
			foreach (var item in torso)
			{
				r = matrix.bi_._MultiX.Multiply( r, item);
			}
			return r;
		}


		static public double[,] Gregate(double[,] a, IEnumerable< double[,]> torso) {
			var r = a;
			foreach (var item in torso)
			{
				r = matrix.bi_._MultiX.Multiply( r, item);
			}
			return r;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Gregate(double[,] a, params T[] torso)
		{
			return Gregate(a, (IEnumerable<double[,]>)torso);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int[,] Gregate(int[,] a, params I[] torso)
		{
			return Gregate(a, (IEnumerable<int[,]>)torso);
		}

	}
}
