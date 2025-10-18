using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.be_
{

	/// <summary>
	///  upper left submatrix is canonical; other cels are 0;
	/// 
	/// </summary>
	/// alias:
	/// 

	static public class _StdX
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="m"></param>
		/// <returns></returns>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool IsStd(this Q[,] m) {


			return m.GetLength(0) >= m.GetLength(1)
				? nilnul.num.real.matrix_.unfat.be_._StdX._IsStd_0unfat(m)
				: nilnul.num.real.matrix_.unthin.be_._StdX._IsStd_0unthin(m);
		}
	}
}
