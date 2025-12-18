using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.be_
{

	/// <summary>
	/// not invertible:<see cref="IInvertible"/>
	/// ; not rankful.
	/// </summary>
	/// alias:
	///		infertile
	/// vs:<see cref="IInvertible"/>
	/// 
	public interface IDegenerate { }
	static public class _DegenerateX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(ref Q[,] m)
		{
			return be_._ScaleneX.Be(in m) || real.matrix_.sq.be_._DegenerateX._Be_0sq(ref m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be( Q[,] m)
		{
			return be_._ScaleneX.Be(in m) || real.matrix_.sq.be_._DegenerateX._Be_0sq( m);
		}

	}


}
