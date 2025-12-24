using System.Linq;
using P = nilnul.num.real.expr_.Algebraic;

namespace nilnul.num.real.expr_.polynom.matrix_.sq._determ_.by_
{
	static public class _ByPermuteX
	{
		static public P _Determ_0sq(
			//in	/// cannot be used in lamda
			P[,] m)
		{
			var w = m.GetLength(0);
			System.Collections.Generic.IEnumerable<int> indexes = Enumerable.Range(0, w).ToArray();


			///.eachCloned();

			return nilnul.num.real.expr_.polynom.bi_.add.cumula.Cumulate.Singleton.cumulate(

			new nilnul.set.permutate_.byLoop_._yield.Indexes(w).Select(
				p =>
				{
					var denomNonnil = indexes.Select(
											r => m[r, p[r]]
										).Aggregate(P.One, (a, c) => a*c);
					return
									(nilnul.sortie.shuffle.be_.parity_._NegativeX._Negative_0shuffle(p) ? -denomNonnil
										:

										denomNonnil
									);
				}));



		}
	}

}
