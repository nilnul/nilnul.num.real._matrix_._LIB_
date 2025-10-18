using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.unthin.be_
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
		static public bool _IsStd_0unthin(this Q[,] m)
		{

			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			bool nilHence = false;

			for (int i = 0
				; i < rows; i++)
			{


				int j = 0;
				for (; j < i; j++)
				{
					if (m[i, j] != 0)
					{
						return false;
					}
				}
				if (nilHence)
				{
					if (m[i, j]!=0)
					{
						return false;
					}

				}
				else
				{
					if (m[i, j] ==0)
					{
						nilHence =true;
					}
					else
					{
						if (m[i, j] !=1)
						{
							return false;
						}
					}
				}
				j++;
				for (; j < cols; j++)
				{
					if (m[i, j]!=0)
					{
						return false;
					}
				}

			}

			return true;

		}
	}
}
