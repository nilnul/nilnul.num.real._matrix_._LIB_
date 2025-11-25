namespace nilnul.num.real.matrix_.triag_
{
	/// <summary>
	/// the matrix is trichnotomized into three parts:
	///		the two triangles, and the parallogram formed by the two main diagonals(one from the upper left corner, the other from the lower right corner);
	///	when only the lower triagonal is not nil, then it's lower triangle; 
	/// </summary>
	/// 
	/// <see cref="trigonal"/>
	public interface ILower:real.matrix_.ITriangular
	{
	}


}
