namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// eg:
	///		[]
	///		[1]
	///		
	/// </summary>
	public static partial class _CanonicalX
	{

		static public bool Be(in Q[,] m)
		{
			int rows = m.GetLength(0);
			return rows== m.GetLength(1) && real.matrix_.sq.be_._CanonicalX._Be_0square_1rows(in m, rows);
		}

	}

}
