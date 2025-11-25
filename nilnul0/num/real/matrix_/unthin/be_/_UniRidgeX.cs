using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.unthin.be_
{

	/// <summary>
	///  vals along diagonal are all 1s;
	/// 
	/// </summary>
	/// alias:
	///		unidiag, if a matrix is diagonal, then a uniridge diagonal matrix is unidiag

	static public class _UniRidgeX
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsUniridge_0unthin(in Q[,] m)
		{

			int rows = m.GetLength(0);

			for (int r = 0
				; r < rows; r++)
			{
				if (m[r,r]!=1)
				{
					return false;
				}


			}

			return true;

		}
	}
}
