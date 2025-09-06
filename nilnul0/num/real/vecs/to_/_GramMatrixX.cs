using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs.to_
{
	/// <summary>
	/// Converts a collection of vector sequences into a Gram matrix.
	/// </summary>
	/// <remarks>The Gram matrix is a symmetric matrix where each element is the inner product of two vectors. This method assumes that all input vectors have the same dimensionality.</remarks>
	static public class _GramMatrixX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vecs">
		///
		/// </param>
		/// <returns>
		/// 0*0 when the <paramref name="vecs"/> is empty;
		/// </returns>
		static public Q[,] ToGramMatrix(
			IEnumerable<Q>[] vecs
		)
		{
			int v = vecs.Count();
			var r = new Q[
				v
				,
				v
			];

			for (int i = 0; i < v; i++)
			{
				r[i, i] = nilnul.num.real.str.scala_._PotenceX.Potence(
					vecs[i]

				);
				for (int j = i + 1; j < v; j++)
				{
					Q denomNonnil = nilnul.num.real.vec.co._InnerProductX._InnerProduct_1equisize(
						vecs[i]
						,
						vecs[j]
					);
					r[i, j] = r[j,i]= denomNonnil;



				}
			}

			return r;

		}
	}
}
