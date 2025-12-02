using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.quotient.matrix_.sq_.invertible.op_._invert_.by_
{
	/// <summary>
	/// find G, such that 
	/// GA = A`, a vent, which might be degenerate. 
	///		if the vent is canonical, then G = A\1.
	///		if the vent is degenerate, then GA = A`, and it's not right ventilator.
	/// </summary>
	/// <remarks>
	/// <see cref="num.quotient.matrix_.sq_.isosize.co.op_.div_.quota_._ReduceX._Dividend_0divisor(ref quotient_.DenomNonnil[,])"/>
	/// , it can judged by <see cref="num.real.matrix_.vent.be_."/>|<see cref="num.real.matrix_.dent.be_"/> to see whether this is inverse.
	/// 
	/// </remarks>
	/// <see cref="nilnul.num.real.matrix_.sq_.invertible.op_._InvertX"/>
	/// alias:
	///		_ByLeftVentilatorX
	///		
	static public class _ByRatioX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _Invert_0invertible(ref Q4[,] m)
		{


			return matrix_.sq_.isosize.ratio_.quota_.invert.to_._ReduceX._Invert_0square(ref m);


			
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _Invert_0invertible(Q4[,] m)
		{
			var c = ( Q4[,]) m.Clone();
			return _Invert_0invertible(ref c);
			
		}
	}



}
