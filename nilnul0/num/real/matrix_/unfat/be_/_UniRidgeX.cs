using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.unfat.be_
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
		static public bool _IsUniridge_0unfat(in Q[,] m)
		{

			int cols = m.GetLength(1);

			for (int c = 0
				; c < cols; c++)
			{
				if (m[c,c]!=1)
				{
					return false;
				}


			}

			return true;

		}
	}
}
