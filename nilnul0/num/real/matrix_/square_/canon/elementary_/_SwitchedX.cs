using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_.canon.elementary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		swap
	///			change with another. a change with external.
	///		switch
	///			means change inernally
	static public class _SwitchedX
	{
		static public double[,] _Generate_assumeValid(int size, int i, int j) {
			var r = square_.Canonic.Create(size);
			 real.matrix.op_.unary_.elementary_.rowwise_._ShuffleX._Shuffle_assumeValid(in r, in i, in j);
			return r;

		}
	}
}
