using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.isowide_.vent.re_._equihull_.by_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="num.real.matrix.re_._EquiHullX."/>
	static public class _ByVentX
	{
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_0vent_1rank_2equiwideVent_3rank(in Q[,] a,int aRank, in Q[,] b, int bRank) {

			if (aRank != bRank) { return false; }

			var width = a.GetLength(1);
			if (aRank == width)
			{
				return true;
			}

			for (int i = 0; i < aRank; i++)
			{
				for (int j = 0; j < width; j++)
				{
					if (a[i, j]!=b[i,j])
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
