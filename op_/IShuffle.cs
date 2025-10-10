using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// <summary>
	/// multiple (0,1, or more) <see cref="_indent.ISwap"/>.
	/// permutate the rows
	/// or permutate the cols
	/// <see cref="nilnul.obj.matrix.op_.unary_.Reshuffle"/>
	/// </summary>
	/// <remarks>
	///  this is rowwise; for colwise, <see cref="real.matrix.cols.op_.IShuffle"/>
	/// </remarks>
	/// <see cref="nilnul.num.real.matrix_.sq_.IShuffler"/>
	/// 
	/// 
	public interface IShuffle:matrix.IOp
	{
	}


}
