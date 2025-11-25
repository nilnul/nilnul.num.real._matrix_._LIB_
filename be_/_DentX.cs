using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	///		
	/// </summary>
	static public class _DentX
	{



		static public bool Be(in Q[,] m)
		{


			//var rank = 0;

			var minPivot4nextCol = 0;

			var rows = m.GetLength(0);

			var cols = m.GetLength(1);
			var row = 0;

rowLoop:
			for (
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
					if (m[row, col]!=0)
					{
						minPivot4nextCol = col+1; /// row rank

						row++;
						goto rowLoop;

						break;
					}
				}


			}
			return true;
		}
	}

}
