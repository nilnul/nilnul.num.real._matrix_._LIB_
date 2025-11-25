using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.pred_.rudic_.col_.equat_.invertible._slv_.by_
{
	internal class ISubstituteWithRighthand
	{

		/// note A\ = A*  / |A|
		/// 
		/// so A\b = A^*  b /|A|
		///		= |A|\ [
		///			[
		///				cofactor00, cofactor10, cofactor20,..., cofactor[n-1,0]    ] . b		# which is replace the first row of A^* with b; or, the determinant of A with the first col replaced by b
		///				,
		///				
		///				cofactor01, cofactor11, cofactor21,..., cofactor[n-1,1]    ] . b		# which is replace the second row of A^* with b; or, the determinant of A with the second col replaced by b
		///				,
		///				...
		///			]
		///		=



	}
}
