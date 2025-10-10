using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.pseudoplane.to_.vec_
{

	/// <see cref="nilnul.num.complex.op_"/>
	/// for vector3d,
	///		i,j,k
	///		a1,a2,a3
	///		b1,b2,b3
	///	the crossProduct is nominal determinant:
	///		i* determinantOf(
	///			a2,a3
	///			b2,b3
	///		)
	///		+
	///		j * -determinant (
	///			a1,a3
	///			b1,b3
	///		)
	///		+
	///		k * determinant(
	///			a1,a2
	///			b1,b2
	///		)
	///
	/// for vector2d, we only keep the above "k" part
	///		that is:
	///			determinant(
	///				a1,a2
	///				b1,b2
	///			)
	///		the original 3d matrix is:
	///			i，j, k
	///			a1,a2,0
	///			b1,b2,0
	///
	/// for vector 2d, in 2d space
	///		i,j
	///		a1,a2
	///	we can calculate the nominal determinant:
	///		i* a2 + j *(-a1)
	///		(a2,-a1)
	///
	/// for two vector, the cross product is the area.
	/// for one vector, the cross product keeps the length.
	///
	///  i, j
	///  a1,0
	///  the cross product of a1 is a1.
	///  
	/// ; this is the hypeParallelogram's hyperVolume(meansure:area, volume)
	///
	/// 
	/// <summary>
	/// </summary>
	/// vs:
	///		<see cref="num.real.matrix.op_.IKernel"/>
	internal class _CrossX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pseudoplane"></param>
		/// <returns>
		/// for matrix 0*1  :  [1]
		///		,what is this? unit? 
		/// for matrix 1*2 [a,b]:  [b, -a]
		///		,perpendicular, of the length.
		/// for matrix 2*3 :  the cross product of the two rows
		///		,perpendicular, of the area.
		/// 
		/// </returns>
		static public double[] _Cross_0pseudoplane(double[,] pseudoplane) {
			var high = pseudoplane.GetLength(0);
			var wide = high+1; /// pseudoplane.GetLength(1);
			var cross = new double[wide];

			var rows = Enumerable.Range(0, high).ToArray();
			var cols = Enumerable.Range(0, wide).ToArray();

			var neg = false;
			for (var i = 0; i < wide; i++) {
				if (neg)
				{
					cross[i] =  -nilnul.num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0equilat_1rows_2cols(
							pseudoplane,
							rows
							,
							cols.Where(x => x!=i).ToArray()
					);
				}
				else
				{
					cross[i] =  nilnul.num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0equilat_1rows_2cols(
							pseudoplane,
							rows
							,
							cols.Where(x => x!=i).ToArray()
					);

				}
				neg=!neg;
			}

			return cross;

		
		}
	}
}
