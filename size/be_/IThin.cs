using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.size.be_
{
	/// <summary>
	/// eg:
	///		[
	///			1;
	///			2
	///		]
	/// </summary>
	/// alias:
	///		thin
	///		lean
	public class _ThinX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Be(int rows, int cols) {
			return rows > cols;
		}
	}

    class IThin
    {
    }
}
