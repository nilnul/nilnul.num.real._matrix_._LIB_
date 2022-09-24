using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square.re_
{
	/// <summary>
	///  two square matrices A and B  are called similar if there exists an invertible matrix P  such that
	///  PA/P = B
	/// </summary>
	/// alias:
	///		相似变换
	///		相似
	///		A~B

	public interface ISimilar
		:
		nilnul.obj.re_.IEq1<ISquare>
	{
	}
}
