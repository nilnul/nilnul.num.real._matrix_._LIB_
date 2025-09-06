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
	/// <see cref="real.matrix.be_.triag_._UpperX"/>
	static public class _UpperX
	{
		/// <summary>
		/// all upper cels are 0;
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool _IsUpper_0fair(Q[,] m) {

			int rows = m.GetLength(0);

			for (int i = 0, iP=1; i < rows; i++, iP++)
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
