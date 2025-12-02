using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq.be_
{

	/// 
	static public class _InvertibleX
	{
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		//static public bool _IsInvertible_0sq(ref Q4[,] m)
		//{
		//	return _invert_.by_._ByLeftVentilatorX._IsInvertible_0sq(ref m);
			

		//}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsInvertible_0sq(ref Q4[,] m)
		{
			return _invertible_.by_._ByDeterminantX._IsInvertible_0sq(ref m);

			//return _invert_.by_._ByLeftVentilatorX._IsInvertible_0sq(m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsInvertible_0sq( Q4[,] m)
		{
			return _invertible_.by_._ByDeterminantX._IsInvertible_0sq(m);

			//return _invert_.by_._ByLeftVentilatorX._IsInvertible_0sq(m);
		}


	}



}
