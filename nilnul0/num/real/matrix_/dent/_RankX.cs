using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.dent
{

	/// <summary>
	///  
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="matrix_.sq.grid_.triag_.ISkew"/>
	/// 
	static public class _RankX
	{
		static public int _Rank_0dent(in Q[,] vent)
		{
			var w = vent.GetLength(1);
			int h = vent.GetLength(0);

			while (h-->0)
			{
				for (int j = 0; j < w; j++)
				{
					if (vent[h, j]!=0)
					{
						return ++h;
					}
				}
			}

			return 0;
		}
	}
}