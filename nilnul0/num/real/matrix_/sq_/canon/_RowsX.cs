using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.canon
{
	static public  class _RowsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="wide"></param>
		/// <returns>
		/// empty, when <paramref name="wide"/>=0
		/// 
		/// </returns>
		static public IEnumerable<int[]> _Rows8int_0wide(int wide) {
			for (int i = 0; i < wide; i++)
			{
				var o=new int[wide];
				int j = 0;
				while ( j < i)
				{
					o[j++] =0;
				}

				o[j++] = 1;

				while ( j < wide)
				{
					o[j++] =0;
				}


				yield return o;
			}
		} 
	}
}
