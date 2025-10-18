using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.unfat.be_
{

	/// <summary>
	///  upper left submatrix is canonical; other cels are 0;
	/// 
	/// </summary>
	/// alias:
	/// 

	static public class _StdX
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsStd_0unfat(this Q[,] m)
		{

			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			bool nilHence = false;

			for (int c = 0
				; c < cols; c++)
			{


				int r = 0;
				for (; r < c; r++)
				{
					if (m[ r,c] != 0)
					{
						return false;
					}
				}

				if (nilHence)
				{
					if (m[ r,c]!=0)
					{
						return false;
					}

				}
				else
				{
					if (m[r, c] ==0)
					{
						nilHence =true;
					}
					else
					{
						if (m[r, c] !=1)
						{
							return false;
						}
					}
				}
				r++;
				for (; r < rows; r++)
				{
					if (m[r, c]!=0)
					{
						return false;
					}
				}

			}

			return true;

		}
	}
}
