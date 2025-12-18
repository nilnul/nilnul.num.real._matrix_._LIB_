using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// every cel is 0.
	/// eg:
	///		<see cref="matrix_.IVacant"/> is 0.
	/// </summary>
	/// alias:
	///		nilful
	///		omninil
	///		pannil
	///		nilfil
	///		init
	///		initia
	///		nil
	///		zero
	///		all nil
	///		naught
	static public class _OmniNilX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns>
		/// true when input is the <see cref="real.matrix_.IVacant"/>, such as [], or 0*3 matrix, etc.
		/// </returns>
		static public bool Be(int[,] x){
			int rows = x.GetLength(0);
			int cols = x.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (x[i,col] !=0)
					{
						return false;
					}
				}

			}
			return true;
		}
		static public bool Be(Q[,] x){
			int rows = x.GetLength(0);
			int cols = x.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (x[i,col] !=0)
					{
						return false;
					}
				}

			}
			return true;
		}

		static public bool Be(double[,] x){
			int rows = x.GetLength(0);
			int cols = x.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (x[i,col] !=0)
					{
						return false;
					}
				}

			}
			return true;
		}



	}
}
