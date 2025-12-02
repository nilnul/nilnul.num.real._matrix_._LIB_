using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.be_.triag_
{

	/// <summary>
	/// only upper are immune from nil;
	/// </summary>
	/// <see cref="real.matrix.be_.trape_._UpperX"/>
	static public class _UpperX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsUpper_0fair(in Q[,] m) {

			int rows = m.GetLength(0);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (m[i,j]!=0)
					{
						return false;
					}
				}
			}

			return true;

		}
		static public bool _IsUpper_0equilat(in int[,] m) {

			int rows = m.GetLength(0);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < i; j++)
				{
					if (m[i,j]!=0)
					{
						return false;
					}
				}
			}

			return true;

		}


	}
}
