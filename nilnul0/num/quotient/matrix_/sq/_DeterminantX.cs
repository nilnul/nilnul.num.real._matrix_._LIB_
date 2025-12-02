using nilnul.bit0nul.re_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.matrix_.sq
{
	static public class _DeterminantX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">
		/// mutated equivolently
		/// </param>
		/// <returns></returns>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _Determinant_0sq(ref Q4[,] m)
		{
			
			return _determ_.by_._ByScaleX._Determinant_0sq(ref m);

		}
		static public Q4 _Determinant_0sq( Q4[,] m)
		{
			var c = (Q4[,])m.Clone();
			return _Determinant_0sq(ref c);


		}

		static public Q4 _Determinant_0sq(
			int[,] square
		)
		{
			Q4[,] m = nilnul.num.quotient.matrix.of_._OfIntegersX.OfIntegers(square);/// we need division.
			return _Determinant_0sq(
				ref m
			);

			//return _determ_.by_._BySubmatrixX._Determinant_0sq(square);
		}

	}
}
