using System.Linq;

namespace nilnul.num.real.matrix_.sq_.triag_.lower_.invertible.op_._invert_.by_
{
	static public class _ForwardSubstitutionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// eg:
		///		[
		///			10
		///			8,	9
		///			5	6,	7
		///			1,	2,	3,	4
		///		]
		/// </param>
		/// <returns>
		/// also a lower triag.
		/// </returns>
		/// <see cref="triag_.upper_.invertible.op_._invert_.by_._BackwardSubstitutionX"/>
		static public Q[,] _Invert_0lowerInvertible(Q[,] m)
		{
			var h = m.GetLength(0);
			//var w = m.GetLength(1);

			var o = 
				///(Q[,])m.Clone()
				new Q[h, h]
			;   ///todo: shall we do this on original matrix in place without creating new one?

			for (int c = 0; c < h; c++) /// the col of the ideal
			{
				int r = 0;
				for (; r < c; r++)
				{
					o[r, c] =0;
				}

				o[r, c] = m[r, c].toInverse();
				r++;

				for (; r < h; r++) {
					/// 
					/// we need sum up before dividing:
					/// 

					var s =  m[r, c] *o[c, c];

					for (var i = c+1; i< r; i++)
					{
						s += m[r, i] *o[i, c];
					}

					o[r, c] = -s/ m[r, r];

				}


			}

			return o;
		}
	}


}
