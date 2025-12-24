using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// each row is the same.
	/// </summary>
	static public class _IsorowX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns>
		/// true when input is the <see cref="real.matrix_.IVacant"/>, such as [], or 0*3 matrix, etc.
		/// </returns>
		static public bool Be(int[,] x){
			int h = x.GetLength(0);
			if (h == 0) return true;

			int w = x.GetLength(1);

			for (int i = 1; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					if (x[i, j] !=x[0, j])
					{
						return false;
					}
				}

			}
			return true;
		}
		static public bool Be(Q[,] x){
			int h = x.GetLength(0);
			if (h == 0) return true;

			int w = x.GetLength(1);

			for (int i = 1; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					if (x[i,j] !=x[0,j])
					{
						return false;
					}
				}

			}
			return true;
		}

		static public bool Be(double[,] x){
			int h = x.GetLength(0);
			if (h == 0) return true;

			int w = x.GetLength(1);

			for (int i = 1; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					if (x[i, j] !=x[0, j])
					{
						return false;
					}
				}

			}
			return true;
		}



	}
}
