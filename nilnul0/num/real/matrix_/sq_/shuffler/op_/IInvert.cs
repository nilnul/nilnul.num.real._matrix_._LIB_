using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.shuffler.op_
{
	static public class _InvertX
	{
		///shuffler is <see cref="matrix_.sq_.IOrthoNormal"/>, which is <see cref="matrix_.sq_.orthonorm.op_.IInvert"/>
		/// 
		/// <summary>
		/// 
		/// </summary>
		/// <param name="shuffler"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _Invert_0shuffler(in Q[,] shuffler) {
			return nilnul.obj.matrix.op_._TransposeX.Transpose(shuffler);
		}
	}

	internal class IInvert
	{
	}
}
