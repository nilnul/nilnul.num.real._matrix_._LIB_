using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.vander.stretched_.torso
{
	/// <summary>
	/// <see cref="_TorsoX"/>, say:
	///		[
	///			x,  x x,...
	///			x1, x1 x1,...
	///			...
	///			x[n], x[n]**2,...
	///		]
	/// can be augmented as <see cref="sq_.IVandermonde"/>:
	///		[
	///			1,	0,	0,	0,	0,
	///			1,  x0, x x,...
	///			1,  x1, x1 x1,...
	///			...
	///			1,  x[n], x[n]**2,...
	///		]
	///	,where the amplitude of row0 is 0;
	///	then it determinant is: <see cref="num.real.matrix_.sq_.vander._DeterminantX"/>:
	///		(x0-0)(x1-0)...(x[n]-0) determVander(x,x1,...x[n])
	/// </summary>
	static public class _DeterminantX
	{

		static public Q4 _ToDeterminant_0amplifiers(
			IEnumerable<Q4> x
		) {

			var r = Q4.One;
			int count = x.Count();

			for (int i = 0, iPlus=1; i < count;i=iPlus, iPlus++ )
			{
				r*= x.ElementAt(i);
				for (int j = iPlus; j < count; j++)
				{
					r *= x.ElementAt(j) - x.ElementAt(i);
				}
			}
			return r;
		}

	


	}
}
