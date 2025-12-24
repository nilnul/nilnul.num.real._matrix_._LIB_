using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.op_.shuffle_.rowly_
{
	static public class _ReverseX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public void Reverse(ref Q4[,] matrix) {
			nilnul.obj.matrix.op_.shuffle_._FlipX._Flip(ref matrix);
		}
	}
	/// <summary>
	/// 
	/// </summary>
	public interface IReverse:IShuffle
	{
	}
}
