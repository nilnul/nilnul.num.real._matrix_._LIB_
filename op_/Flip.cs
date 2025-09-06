using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// horizontally mirror
	/// </summary>
	public class Flip
		: num.real.matrix.Op4dblI
	{
		public double[,] op(in double[,] obj)
		{
			int row = obj.GetLength(0);
			int col = obj.GetLength(1);
			var r = new double[row, col];

			 col--;

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j <= col; j++)
				{
					r[i, j] = obj[i, col - j];
				}
			}
			return r;
		}


		static public Flip Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Flip>.Unison;
			}
		}

	}
}
