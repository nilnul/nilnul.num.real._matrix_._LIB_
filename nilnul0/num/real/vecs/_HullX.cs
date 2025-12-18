using System.Runtime.CompilerServices;

namespace nilnul.num.real.vecs
{
	/// <summary>
	/// all linear combinations of the vec, which is a subspace.
	/// </summary>
	/// alias:
	///		hull
	///		span
	///		
	static public class _HullX
	{
		/// <summary>
		/// <see cref="real.matrix.rows.ISpan"/>
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] HullOfRows( Q[,] a) {
			//var cloned = (Q[,]) a.Clone();
			return nilnul.num.real.matrix.op_.vent_._indep_.by_._GaussianX.ToIndepVent(a);
			//return cloned;


			

		}

	

	}
}
