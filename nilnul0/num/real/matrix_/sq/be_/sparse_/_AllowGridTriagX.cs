using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq.be_.sparse_
{
	/// <summary>
	/// <see cref="nilnul.num.real.matrix_.sq.grid_.ITriag"/>
	/// </summary>
	static public class _AllowGridTriagX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _IsSparse_0sq(Q4[,] a)
		{

			var w = a.GetLength(0);
			/// .Cast<byte>() will convert the multi-dimensional array to a single dimension.
			/// This will do boxing, unboxing so isn't the most performant way, but is certainly the simplest and safest.
			/// /*Enumerable.Count<Q4>*/
			return 	a.Cast<Q4>().Count( x=> x == 0) >= w*(w) /4;
		}
	}
}
