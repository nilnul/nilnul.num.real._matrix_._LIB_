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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="torso"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate( IEnumerable< Q[,]> torso) {
			return torso.Aggregate(
				(a,c) =>  matrix.bi_._MultiX.Multiply( a, c)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate(Q[,] head, IEnumerable< Q[,]> torso) {
			return torso.Aggregate(
				head,
				(a,c) =>  matrix.bi_._MultiX.Multiply( a, c)
			);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate(int[,] head, IEnumerable< Q[,]> torso) {
			return Gregate(
				nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(head)
				,
				torso
			);
	
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate(params Q[][,] staked) {
			return Gregate((IEnumerable<Q[,]>)staked);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate(Q[,] head, params Q[][,] tail) {
			return Gregate(head,(IEnumerable<Q[,]>)tail);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] Gregate(int[,] head, params Q[][,] tail) {
			return Gregate(head,(IEnumerable<Q[,]>)tail);
		}


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
