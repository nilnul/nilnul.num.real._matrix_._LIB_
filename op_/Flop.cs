using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// vertically mirrow;
	/// </summary>
	public class Flop 
		: num.real.matrix.Op4dblI
	{
		public double[,] op(in double[,] obj)
		{
			int row = obj.GetLength(0);
			int col = obj.GetLength(1);
			var r = new double[row, col];

			 row--;

			for (int i = 0; i <= row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					r[i, j] = obj[row- i,  j];
				}
			}
			return r;
		}


		static public Flop Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Flop>.Unison;
			}
		}

	}
}
