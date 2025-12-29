using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// <see cref="real.matrix.rows.be_._OrthogonalX"/> and <see cref="real.matrix.cols.be_._OrthogonalX"/>
	/// ;
	/// eg:
	///		0 matrix
	///		<see cref="num.real.matrix_.IStandard"/>
	///		[
	///			0	1
	///			2	0
	///		]
	/// </summary>
	/// <remarks>
	///  A  A**T = <see cref="num.real.matrix_.sq_.IDiagonal"/>
	/// </remarks>
	public static  class _OrthicX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(in Q[,] m)
		{
			
			return real.matrix.rows.be_._OrthogonalX.Be(in m) && real.matrix.cols.be_._OrthogonalX.Be(in m);
		}

	}

}
