using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul.num.real.matrix_.sq.op_
{
	/// <summary>
	/// unlike <see cref="_NegateX"/> which adds to 0, here they adds to 1.
	/// </summary>
	static public class _ComplementX
	{

		static public void _Complement_0sq(ref Q4[,] m)
		{
			int w = m.GetLength(0);
			for (int i = 0; i < w; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					m[i, j] = -m[i, j];
				}
				m[i, i] = 1-m[i, i];
				j++;
				for (; j < w; j++)
				{
					m[i, j] = -m[i, j];
				}
			}
		}
		static public Q4[,] _Complement_0sq(Q4[,] m)
		{
			int w = m.GetLength(0);
			var o = new Q4[w, w];
			for (int i = 0; i < w; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					o[i, j] = -m[i, j];
				}
				o[i, i] = 1-m[i, i];
				j++;
				for (; j < w; j++)
				{
					o[i, j] = -m[i, j];
				}
			}
			return o;
		}

	}




}
