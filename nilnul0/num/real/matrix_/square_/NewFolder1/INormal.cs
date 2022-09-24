using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// If A^*  A = A  A^*
	/// we avoid this term as it might be consused with <see cref="invertible_.orthic_.INorm"/>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	[Obsolete(@"we avoid this term as it might be consused with <see cref=""rankful_.orthic_.INorm""/>")]
	public interface INormal
		:
		matrix_.ISquare
	{
	}
}
