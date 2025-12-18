using M = nilnul.num.quotient_.DenomNonnil[,];

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix
{
	/// <see cref="num.quotient.matrix.IRank"/>
	/// <see cref="num.real.vecs.IRank"/>
	/// 
	/// <summary>
	/// as <see cref="real.matrix.rows.IRank"/> = <see cref="real.matrix.cols.IRank"/>
	/// , here we use <see cref="real.matrix.rows.IRank"/>, as matrix is row major:<see cref="obj.matrix.be_.IRowMajor"/>
	/// </summary>
	static public class _RankX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Rank(ref M m)
		{
			return rows._RankX.Rank(ref m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Rank(Q[,] m)
		{
			return rows._RankX.Rank( m);
		}
	}
}
