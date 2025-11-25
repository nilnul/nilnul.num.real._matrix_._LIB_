using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.rows.be_
{
	///  vecs.be_:
	///		linear span:
	///			each vec cannot be represented linearly by others.
	///				, hence 0 can not be in there.
	///			eg:
	///				{}, matrix[] is 1 in determinant;shall be understood as 0 of []s, that is {}.
	///				{ [1] }
	///			ex:	
	///				{ [] }, is in fact <see cref="matrix_.vacant_"/>:1*0, unsquare
	///				, and redundant (as [] can be represented as sum() ).it can be simplified as []. 
	///
	/// 
	/// <summary>
	///  
	/// 
	/// </summary>
	public interface IIndependent
	{
	}


}
