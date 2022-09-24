using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{
	public class Approx4dbl
		:nilnul.obj.ReI<
			double[,]
		>
		//,
		//nilnul.obj.re_.
	{

		public bool _re_assumeSameSize(double[,] a, double[,] b)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (!nilnul.num.real.re_.approx_.ByInjected.Singleton.re(a[i,j],b[i,j]))
					{
						return false;
					}
				}
			}

			return true;
		}

		public bool re(double[,] a, double[,] b)
		{
			if (a.GetLength(0) ==b.GetLength(0) && a.GetLength(1) == b.GetLength(1) )
			{
				return _re_assumeSameSize(a, b);

			}
			return false;
		}

		static public Approx4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Approx4dbl>.Instance;
			}
		}

	}
}
