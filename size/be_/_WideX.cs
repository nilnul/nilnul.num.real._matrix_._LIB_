using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.size.be_
{
	/// <summary>
	/// eg:
	///		[1,2]
	/// </summary>
	/// alias:
	///		wide, where "w" is wide
	public class _WideX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(int rows, int cols) {
			return rows < cols;
		}
	}



}
