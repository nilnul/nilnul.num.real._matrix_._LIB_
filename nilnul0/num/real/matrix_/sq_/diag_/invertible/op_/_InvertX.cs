using System.Linq;

namespace nilnul.num.real.matrix_.sq_.diag_.invertible.op_
{
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// eg:
		///		[
		///			1,	
		///				5	
		///					8,	
		///						10
		///		]
		/// </param>
		/// <returns></returns>
		static public void _Invert_0diagInvertible(ref Q[,] m)
		{
			var h = m.GetLength(0);

			for (int i = 0; i < h; i++) {
				//m[i, i].inverse();// = m[i, i].toInverse(); /// todo: invert quotient in place
				m[i, i] = m[i, i].toInverse(); /// 


			}

		}
	}


}
