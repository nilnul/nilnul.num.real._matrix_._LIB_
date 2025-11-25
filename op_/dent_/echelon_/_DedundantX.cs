using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.dent_.echelon_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		dedund
	///		std
	static public class _DedundantX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// 
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] ToIndepEchelon(ref Q[,] m)
		{
			/// here we need to keep the old matrix:
			/// 
			var r= dent_._EchelonX.EchelonForRank(ref m); /// mutated
			return dent_. _DedundantX._ToDedundant_0indent_1rank(m,r);
		}

		static public Q[,] ToIndepEchelon( Q[,] m)
		{
			/// here we need to keep the old matrix:
			/// 
			var m1 = (Q[,]) m.Clone();

			return ToIndepEchelon(ref m1);
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _ToStd_0echelon_1rank( Q[,] m, int rank)
		{
			return dent_. _DedundantX._ToDedundant_0indent_1rank(m,rank);
		}





	}
}
