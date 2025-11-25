using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.dent_.dedund_
{

	static public class _EchelonX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// 
		/// 
		/// 
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] ToIndepEchelon( Q[,] m)
		{
			return dent_.echelon_._DedundantX.ToIndepEchelon( m);

		}





	}
}
