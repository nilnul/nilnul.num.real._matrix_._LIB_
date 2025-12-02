using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:<see cref="IIndependent"/> which can be nonsquare

	static public class _InvertibleX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(ref Q[,] m)
		{
			return m.GetLength(0)== m.GetLength(1) && real.matrix_.sq.be_._InvertibleX._Be_0sq(ref m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be( Q[,] m)
		{
			return m.GetLength(0)== m.GetLength(1) && real.matrix_.sq.be_._InvertibleX._Be_0sq( m);
		}

	}


}
