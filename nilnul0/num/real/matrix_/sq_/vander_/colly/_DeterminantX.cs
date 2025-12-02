using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vander_.colly
{
	static public class _DeterminantX
	{
	


		static public Q4 _Determinant_0vandermondeColly(
			in Q4[,] vandermonde
		) {

			int count = vandermonde.GetLength(0);
			if ( count < 2 )
			{
				return 1;
			 }

			var r = Q4.One;
			for (int i = 0, iPlus=1; i < count;i=iPlus, iPlus++ )
			{
				for (int j = iPlus; j < count; j++)
				{
					r *= vandermonde[j,1] - vandermonde[i,1];
				}
			}
			return r;
		}



	}
}
