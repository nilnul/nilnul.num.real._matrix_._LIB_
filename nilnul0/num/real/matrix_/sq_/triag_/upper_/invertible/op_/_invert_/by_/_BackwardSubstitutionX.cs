using System.Linq;

namespace nilnul.num.real.matrix_.sq_.triag_.upper_.invertible.op_._invert_.by_
{
	static public class _BackwardSubstitutionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// eg:
		///		[
		///			1,	2,	3,	4
		///				5	6,	7
		///					8,	9
		///						10
		///		]
		/// </param>
		/// <returns></returns>
		static public Q[,] _Invert_0upperInvertible(Q[,] m)
		{
			var h = m.GetLength(0);
			//var w = m.GetLength(1);

			var o = 
				///(Q[,])m.Clone()
				new Q[h, h]
			;   ///todo: shall we do this on original matrix in place without creating new one?

			for (int c = h; c-- > 0;) /// the col of the ideal
			{
				int r = h;
				for (; --r > c; )
				{
					o[r, c] =0;
				}
				o[r, c] = m[r, c].toInverse();

				for (; r-->0; )
				{
					/// 
					/// we need sum up before dividing:
					/// 

					var s = m[r, c] *o[c, c];

					for (var i = c		/// c-1 might be negative, hence it's unfavorable; 
						; i-->r+1; )
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
