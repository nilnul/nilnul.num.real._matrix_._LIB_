using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix_.dent_.paragon.be_
{
	/// <summary>
	/// </summary>
	///	

	static public class _ReducedEchelonX
	{

		static public bool _IsReducedEchelon_0paragon(in Q[,] _rowEchelon)
		{
			var h = _rowEchelon.GetLength(0);

			for (var i = 0; i < h; i++) { 
				var p =  num.real.matrix.row._PivotX.Pivot(in _rowEchelon, i);
				if (p<0)
				{
					return true;
				}

				for (var j = 0; j < i; j++) {
					if (_rowEchelon[j,p]!=0)
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		/// as only operations closed in quotient are used, hence double type here is strictly dealt as on quotient
		/// </summary>
		/// <param name="_rowEchelon"></param>
		/// <returns></returns>
		static public bool _IsReducedEchelon_0paragon(in double[,] _rowEchelon)
		{
			var h = _rowEchelon.GetLength(0);

			for (var i = 0; i < h; i++) { 
				var p =  num.real.matrix.row._PivotX.Pivot(in _rowEchelon, i);
				if (p<0)
				{
					return true;
				}

				for (var j = 0; j < i; j++) {
					if (_rowEchelon[j,p]!=0)
					{
						return false;
					}
				}
			}

			return true;
		}




	}
}
