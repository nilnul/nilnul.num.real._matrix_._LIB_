namespace nilnul.num.real.matrix.factorize_.triad_
{
	/// <summary>
	/// PA =LU
	///		,where P is a <see cref="matrix_.sq_.IShuffler"/> to make unnil cel at the left column float upward. P here means reordering rows; 
	/// 
	/// <see cref="real.matrix_.sq_.triag_.ILower"/>
	/// *
	/// <see cref="nilnul.num.real.matrix_.trape_.IRight"/>
	/// </summary>
	/// <remarks>
	///  <see cref="num.real.matrix.op_.rowspan_.IIndent"/>, would result the upper triag,
	///  and the transformations would compound as a <see cref="num.real.matrix_.sq_.triag_.ILower"/>
	/// , but that would require the unfactorized matrix to be invertible, and a shuffling is required to make the indent possible. When the indent is possible, then this LuDecomposition is possible
	/// </remarks>
	/// alias:
	///		lu
	///		
	public interface ILowerUpperDecompose:matrix.IFactorize
		,
		matrix.factorize_.ITriad
    {
    }



}
