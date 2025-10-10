using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.rowspan_.indent_.std_.canon_
{
	/// <summary>
	/// remove any vec that is all nils;
	/// the ending matrix might be 0*n:<see cref="nilnul.obj.matrix_.vacant_.IRowless"/>
	/// </summary>
	/// <remarks>
	/// the resulted is now unique, and can identify a space that is n dimensional, where n is the count of cols.
	/// But the rows are not orthonormal. We can further make the rows orthonormal:<see cref="real.vecs_.indep.op_._SchmidtGramX"/>.
	/// </remarks>
	internal class IDedundant
	{
	}


}
