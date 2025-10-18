using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	/// eg:
	///		[]
	///		[1]
	///		
	/// </summary>
	/// <see cref="num.real.matrix.be_.ICanonical"/>
	static public class _CanonicalX
	{



		/// <summary>
		/// </summary>
		/// <param name="sq"></param>
		/// <returns></returns>
		static public bool _Be_0square_1rows(in Q[,] sq, int rows)
		{

			for (int i = 0; i < rows; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					if (sq[i, j] != 0)
					{
						return false;
					}
				}


				if (sq[i, j++] != 1)
				{
					return false;
				}


				for (; j < rows; j++)
				{
					if (sq[i, j] != 0)
					{
						return false;
					}
				}



			}
			return true;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_0square(in Q[,] sq)
		{
			return _Be_0square_1rows(in sq, sq.GetLength(0));
		}


		//[Obsolete(nameof(real.matrix.be_._CanonicalX))]
		//static public bool Be(in Q[,] sq)
		//{
		//	int rows = sq.GetLength(0);
		//	return rows== sq.GetLength(1) && _Be_0square_1rows(in sq, rows);
		//}

	}

}
