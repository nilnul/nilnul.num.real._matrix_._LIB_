using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.dwelt_
{
	static public class _PawX
	{
		static public Q[,] _ToPaw_0diag_1rowTorso_2colTorso(in Q[] diag, in Q4[] row1stTorso, in Q4[] col1stTorso) {


			//var r = num.real.matrix_.sq_._DiagonalX.OfDiagonal(diag);

			int width = diag.Length;

			var r = obj.matrix_.sq_._DefaultedX.Generate<Q4>(width);

			//int wMinus = wideth-1;
			//
			r[0,0] = diag[0];
			Q4 nil = Q4.Nil;

			for (int i = 0, iP=1; iP < width; i++, iP++)
			{
				r[0, iP] = row1stTorso[i];
				r[iP, 0] = col1stTorso[i];
				r[iP,iP] = diag[iP];
				for (int j = 1; j < iP; j++)
				{
					r[iP, j] =r[j,iP] = nil;
				}
			}
		
			return r;
		}





	}
}
