using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vander
{
	static public class _DeterminantX
	{
		static public double Determinant(
			IEnumerable<double> x
		) {

			var r = 1d;
			int count = x.Count();

			for (int i = 0, iPlus=1; i < count;i=iPlus, iPlus++ )
			{
				for (int j = iPlus; j < count; j++)
				{
					r *= x.ElementAt(j) - x.ElementAt(i);
				}
			}
			return r;
		}


		static public Q4 Determinant(
			IEnumerable<Q4> x
		) {

			var r = Q4.One;
			int count = x.Count();

			for (int i = 0, iPlus=1; i < count;i=iPlus, iPlus++ )
			{
				for (int j = iPlus; j < count; j++)
				{
					r *= x.ElementAt(j) - x.ElementAt(i);
				}
			}
			return r;
		}

	


	}
}
