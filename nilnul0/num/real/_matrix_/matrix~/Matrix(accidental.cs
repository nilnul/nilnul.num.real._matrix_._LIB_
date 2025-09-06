using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.matrix._1
{
	public partial class Matrix
	{
		public void AsRowEchelon() {
			op.Gaussian.RowEchelon(_elements);
		}

		public void TransCononical() {
			op.Gaussian.Canonical(_elements);
		}
	}
}
