using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq.op_._invert_.semi_
{
	/// <summary>
	/// find G, such that 
	/// GA = A`, a vent, which might be degenerate. 
	///		if the vent is canonical, then G = A\1.
	///		if the vent is degenerate, then GA = A`, and it's not right ventilator.
	/// </summary>
	/// <remarks>
	/// <see cref="num.quotient.matrix_.sq_.isosize.co.op_.div_.quota_._InvertX._Dividend_0divisor(ref quotient_.DenomNonnil[,])"/>
	/// , it can judged by <see cref="num.real.matrix_.vent.be_."/>|<see cref="num.real.matrix_.dent.be_"/> to see whether this is inverse.
	/// 
	/// </remarks>
	/// 
	static public class _LeftVentilatorX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <exception cref="DivideByZeroException"></exception>
		/// 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _LeftVentilator_0sq(ref Q4[,] m)
		{
			/// I/A = G / GA = G/A`
			return matrix_.sq_.isosize.co.op_.div_.quota_._InvertX._Dividend_0divisor(ref m);
		}

	}
}
