using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.sq.scala_
{
	/// <summary>
	/// the sum of trails/diag
	/// the sum of all numbers in the diagonal from the upper left to lower right.
	/// </summary>
	/// alias:
	///		trace
	///			,tr
	///			
	static public  class _TraceX
	{
		static public double _Trace_0sq(this double[,] m)
		{
			var w= m.GetLength(0);
			var r = 0d;
			for (int i = 0; i < w; i++)
			{
				r+=m[i, i];
				
			}
			return r;
		}
	}
}
