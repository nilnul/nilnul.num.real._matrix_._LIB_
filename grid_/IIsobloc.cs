using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid_
{
	/// <summary>
	/// the blocks of this grid has same size.
	/// </summary>
	public interface IIsoblok
	{
	}
	static public class _IsoblokX
	{
		static public double[,][,] _Of_inited(int belts,int buncs, int rows, int cols) {
			var r= new double[belts, buncs][,];
			for (int i = 0; i < belts; i++)
			{
				for (int j = 0; j < buncs; j++)
				{
					r[i, j] = new double[rows,cols];
				}
			}
			return r;
		}
	}
}
