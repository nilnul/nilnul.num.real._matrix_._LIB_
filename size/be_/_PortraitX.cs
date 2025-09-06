using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix.size.be_
{
	/// <summary>
	/// eg:
	///		[
	///			1;
	///			2
	///		]
	/// eg:
	///		[1]
	/// </summary>
	/// alias:
	///		unthin
	public class _PortraitX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(int rows, int cols) {
			return rows >= cols;
		}
	}


}
