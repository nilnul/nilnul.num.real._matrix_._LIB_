using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.rel
{
	static public partial class EqX 
	{
		static public bool Eval(double[,] x,double[,] y) {
			return nilnul.collection.matrix.MatrixX.Eq(x, y);

		}

		public class ForDouble : IEqualityComparer<double[,]>
		{
			public bool Equals(double[,] x, double[,] y)
			{
				return Eval(x, y);
				throw new NotImplementedException();
			}

			public int GetHashCode(double[,] obj)
			{
				return nilnul.collection.matrix.rel.EqX.GetHashCode(obj);	
				throw new NotImplementedException();
			}
		}




	}
}
