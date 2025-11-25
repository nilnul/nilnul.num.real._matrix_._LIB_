using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.dent.be_
{

	/// <summary>
	///  
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="matrix_.sq.grid_.triag_.ISkew"/>
	/// 
	static public class _IndependentX
	{
		static public bool _IsIndependent_0dent(in Q[,] vent)
		{
			int h = vent.GetLength(0);
			var w = vent.GetLength(1);

			h--;

			for (int c = 0; c < w; c++)
			{
				if (vent[h, c]!=0)
				{
					return true;
				}
			}


			return false;
		}
	}
}