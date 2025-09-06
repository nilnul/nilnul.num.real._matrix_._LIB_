using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{
	public class Approx4dbl1
		:nilnul.obj.ReI<
			double[,]
		>
		//,
		//nilnul.obj.re_.
	{
		private num.real.re_.Approx4dblI _approx;

		public num.real.re_.Approx4dblI approx
		{
			get { return _approx; }
			set { _approx = value; }
		}

		public Approx4dbl1(num.real.re_.Approx4dblI approx)
		{
			this._approx = approx;
		}

		public Approx4dbl1(double x):this(new num.real.re_.approx_.Ratio8dbl(x))
		{
				
		}

		[Obsolete(nameof(_re_1equisize))]
		public bool _re_assumeSameSize(double[,] a, double[,] b)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (!_approx.re(a[i,j],b[i,j]))
					{
						return false;
					}
				}
			}

			return true;
		}

		public bool _re_1equisize(double[,] a, double[,] b)
		{
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (!_approx.re(a[i,j],b[i,j]))
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

		static public readonly Approx4dbl1 KILOTH = new Approx4dbl1(
			 //nilnul.num.real.re_.approx_.ratio_.PerKilo4Dbl.Singleton

			 nilnul.num.real.re_.approx_.ratio_.PerKilo4Dbl.Singleton
		);

	}
}
