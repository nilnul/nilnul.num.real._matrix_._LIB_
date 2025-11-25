using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.be_.dent_
{
	/// <summary>
	///		
	/// </summary>
	static public class _EchelonX
	{


		static public bool Be(in Q[,] m)
		{

			var minPivot4nextCol = 0;

			var rows = m.GetLength(0);

			var cols = m.GetLength(1);

			for (
				var row = 0
				;
				row < rows
				;
				row++
			)
			{

				var col = 0;

				for (; col < minPivot4nextCol; col++)
				{
					if (m[row, col]!=0)
					{
						return false;
					}
				}

				for (; col < cols; col++)
				{
					if (m[row, col]!=0) {
						break;
					}
				}

				if (col < cols)
				{
					if (m[row, col]!=1)
					{
						return false;
					}
				}
				minPivot4nextCol = col;
			}

			return true;
		}
	}

}
