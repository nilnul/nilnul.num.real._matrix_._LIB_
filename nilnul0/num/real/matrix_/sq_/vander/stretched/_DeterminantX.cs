using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vander.stretched
{
	/// <summary>
	/// <see cref="IStretched"/>, say:
	///		[
	///			a x, a x x,...
	///			a1 x1,a1 x1 x1,...
	///			...
	///			a[n] x[n], a[n] x[n]**2,...
	///		]
	/// 
	/// </summary>
	static public class _DeterminantX
	{


		static public Q4 _ToDeterminant_p1amplifiers(
			Q[] initials
			,
			params
			IEnumerable<Q4> x
		) {

			var r = Q4.One;
			int count = x.Count();

			for (int i = 0, iPlus=1; i < count;i=iPlus, iPlus++ )
			{
				r*=initials[i];
				for (int j = iPlus; j < count; j++)
				{
					r *= x.ElementAt(j) - x.ElementAt(i);
				}
			}
			return r;
		}

	


	}
}
