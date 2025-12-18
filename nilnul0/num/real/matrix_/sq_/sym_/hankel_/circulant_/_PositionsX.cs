using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.sym_.hankel_.circulant_
{
	/// <see cref="obj.matrix_.IHankel"/>
	/// <see cref="obj.matrix_._HankelX"/>
	/// <see cref="obj.matrix_.sq_.hankel_._CirculantX"/>
	/// <see cref="obj.matrix_.sq_.hankel_._circulant_.by_._ByItersX"/>
	/// <summary>
	/// [
	///		1,2,3,...,n
	///		2,3,,...,1
	///		3,,,...,2
	///		...
	///		n,1,2,...,n-1
	/// ]
	/// , note where each row is  a left shift of the previous row., a shuffle.
	/// </summary>
	static public class _PositionalX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int[,] Generate(int n)
		{
			return nilnul.obj.matrix_.sq_.hankel_._CirculantX.ToCirculantHankel(
				Enumerable.Range(1, n)
			);
		}
	}
}
