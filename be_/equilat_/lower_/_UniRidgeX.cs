using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_.equilat_.lower_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _UniRidgeX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in int[,] matrix) {
			return nilnul.obj.matrix.be_._EquilateralX.Be(in matrix)
				&& nilnul.num.real.matrix_.sq.be_.triag_.lower_._UniRidgeX._IsUniLower_0equilat(in matrix)
				;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in Q[,] matrix) {
			return nilnul.obj.matrix.be_._EquilateralX.Be(in matrix)
				&& nilnul.num.real.matrix_.sq.be_.triag_.lower_._UniRidgeX._IsUniLower_0equilat(in matrix)
				;
		}


	}


}
