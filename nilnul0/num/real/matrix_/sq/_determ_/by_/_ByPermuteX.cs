using System.Linq;
using System.Numerics;

namespace nilnul.num.real.matrix_.sq._determ_.by_
{
	static public class _ByPermuteX
	{
		static public Q4 _Determ_0sq(Q4[,] m)
		{
			var w = m.GetLength(0);
			System.Collections.Generic.IEnumerable<int> indexes = Enumerable.Range(0, w);


			///.eachCloned();

			return nilnul.num.quotient.str._SumX.Sum(

			new nilnul.set.permutate_.byLoop_._yield.Indexes(w).Select(
				p =>
				{
					Q4 denomNonnil = indexes.Select(
											r => m[r, p[r]]
										).Aggregate(Q4.One, (a, c) => a*c);
					return
									(nilnul.sortie.shuffle.be_.parity_._NegativeX._Negative_0shuffle(p) ? -denomNonnil
										:

										denomNonnil
									);
				}));



		}
		static public BigInteger _Determ_0sq(int[,] m)
		{
			var w = m.GetLength(0);
			System.Collections.Generic.IEnumerable<int> indexes = Enumerable.Range(0, w).ToArray();

			return nilnul.num.integer.bi_.add._CumulaX.Cumulate(
				new nilnul.set.permutate_.byLoop_._yield.Indexes(w).Select(
					p =>
					{
						var denomNonnil = indexes.Select(
												r => m[r, p[r]]
											).Aggregate(BigInteger.One, (a, c) => a*c);
						return
										(nilnul.sortie.shuffle.be_.parity_._NegativeX._Negative_0shuffle(p) ? -denomNonnil
											:

											denomNonnil
										);
					}));



		}

		static public double _Determ_0sq(double[,] m)
		{
			var w = m.GetLength(0);
			System.Collections.Generic.IEnumerable<int> indexes = Enumerable.Range(0, w);


			///.eachCloned();

			return nilnul.num.real.str._SumX.Sum(

			new nilnul.set.permutate_.byLoop_._yield.Indexes(w).Select(
				p =>
				{
					var denomNonnil = indexes.Select(
											r => m[r, p[r]]
										).Aggregate(1d, (a, c) => a*c);
					return
									(nilnul.sortie.shuffle.be_.parity_._NegativeX._Negative_0shuffle(p) ? -denomNonnil
										:

										denomNonnil
									);
				}));



		}
	}

}
