using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.vec.co_.matrixMultible
{
	static public class _MultiComponentwiseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b">
		/// same size. each component is sociable with the corresponding component of <paramref name="a"/>
		/// </param>
		/// <returns>
		/// this doesnot gurantee that component is equisize.
		/// </returns>
		static public IEnumerable<double[,]> _Multi_assumeComponentwiseMultible(
			IEnumerable<double[,]> a
			,
			IEnumerable<double[,]> b
		) {

			return a.Zip(
				b
				,
				(x,y)=>
				matrix.co_.multible._MultiX._Multiply_assumeSociable(x,y)
			);

		}




	}
}
