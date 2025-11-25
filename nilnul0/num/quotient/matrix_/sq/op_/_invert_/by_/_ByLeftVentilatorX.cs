using System;

namespace nilnul.num.quotient.matrix_.sq.op_._invert_.by_
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
	static public class _ByLeftVentilatorX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// <exception cref="DivideByZeroException">
		///  when the input is degenerate.
		/// 
		/// </exception>
		static public Q4[,] _Invert_0sq(ref Q4[,] m)
		{
			var dividend = matrix_.sq_.isosize.co.op_.div_.quota_._InvertX._Dividend_0divisor(ref m);
			if (nilnul.num.real.matrix_.dent.be_._IndependentX._IsIndependent_0dent(m))
			{
				return dividend;
			}

			throw new DivideByZeroException(
				$"{m} is not invertible"
			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// <exception cref="DivideByZeroException">
		///  when the input is degenerate.
		/// </exception>
		static public Q4[,] _Invert_0sq( Q4[,] m)
		{
			var c = (Q4[,])m.Clone();

			return _Invert_0sq(ref c);
			

		}


	}



}
