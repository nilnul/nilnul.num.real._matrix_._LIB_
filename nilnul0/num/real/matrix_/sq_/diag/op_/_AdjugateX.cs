using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag.op_
{
	static public  class _AdjugateX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>
		/// [] from []
		/// [1] from [x]
		/// [1,0
		/// [0,0] from [ 
		///		0,0
		///		0,1
		/// ]
		/// </returns>
		static public Q4[] _AdjugateAsDiag_0diag(Q4[] a)
		{
			var n = a.Length;

			var r = new Q4[n];

			var indexes = Enumerable.Range(0, n);

			for (int i = 0; i < n; i++)
			{
				r[i] = indexes.Where(
					d => d!=i
				).Aggregate(
					Q4.One, 
					(a, c) => a * c
				);
			}
			return r;
		}
	}
}
