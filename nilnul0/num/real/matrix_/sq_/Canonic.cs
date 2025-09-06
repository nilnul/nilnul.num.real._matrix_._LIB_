using nilnul.num.real.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.sq_
{

	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(sq_._CanonicalX))]
	public class Canonic
		:
		orthonorm_.axial_.positive_.IUnshuffled
	{
		static public double[,] Create(int size) {
			var raw = new double[size,size];

			for (int i = 0; i < size; i++)
			{
				raw[i, i] = 1;
				
			}
			return raw;
		}
	}
}
