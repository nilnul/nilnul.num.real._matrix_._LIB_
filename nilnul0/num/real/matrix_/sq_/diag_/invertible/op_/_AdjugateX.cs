using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.diag_.invertible.op_
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
		/// [0,2] from [ 
		///		2,0
		///		0,1
		/// ]
		/// </returns>
		static public void _Adjugate_0diagInvertible(ref Q4[] a)
		{
			var product = a.Aggregate(
				Q4.One,
				(a, c) => a * c
			);

			var n = a.Length;

			for (int i = 0; i < n; i++)
			{
				a[i] = product/a[i];
			}
		}
	}
}
