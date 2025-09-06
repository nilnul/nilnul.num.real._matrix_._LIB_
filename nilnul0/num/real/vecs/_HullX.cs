namespace nilnul.num.real.vecs
{
	static public class _HullX
	{
		/// <summary>
		/// <see cref="real.matrix.rows.ILinearCombinate"/>
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		static public Q[,] HullOfRows( Q[,] a) {
			var cloned = (Q[,]) a.Clone();
			nilnul.num.real.matrix.op_.rowspan_._GaussianX.Canonical(cloned);
			return cloned;


			

		}

	

	}
}
