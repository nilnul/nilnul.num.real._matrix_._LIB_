using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{

	/// <summary>
	///  vals along diagonal are all 1s;
	/// 
	/// </summary>
	/// alias:
	///		unidiag, if a matrix is diagonal, then a uniridge diagonal matrix is unidiag

	static public class _UniRidgeX
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="m"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool IsUniridge(in Q[,] m)
		{

			return m.GetLength(0) <= m.GetLength(1)
				? nilnul.num.real.matrix_.unthin.be_._UniRidgeX._IsUniridge_0unthin(in m)
				: nilnul.num.real.matrix_.unfat.be_._UniRidgeX._IsUniridge_0unfat(in m);
		}
	}
}
