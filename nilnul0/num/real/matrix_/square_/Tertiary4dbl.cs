using nilnul.obj.str.be_.count_.three.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		tertial
	///		third
	///		thrice
	public class Tertiary4dbl
		: nilnul.obj.matrix_.square_.Tertiary<double>
	{
		public Tertiary4dbl(double[,] val) : base(val)
		{
		}

		public Tertiary4dbl(
			(double,double,double) v0
			,
			(double,double, double) v1
			,
			(double,double,double ) v2
		):this(
			nilnul.obj.matrix.of_.vecs_._OfRowsX.OfVecs(
				new[] { v0, v1, v2 }.Select(t=> new nilnul.obj.vec_.Tro<double>(t))
			)
		)
		{

		}

		static public Tertiary4dbl OfCols(
			(double,double,double) v0
			,
			(double,double, double) v1
			,
			(double,double,double ) v2

		) {
			return new Tertiary4dbl(
				nilnul.obj.matrix.of_.vecs_._OfColsX.OfVecs(
					new[] { v0, v1, v2 }
					.Select(
						t => new nilnul.obj.vec_.Tro<double>(t)
					)
				)
			);
		}

		static public Tertiary4dbl OfCols(
			IEnumerable<(double,double,double)>  v0
			

		) {
			return OfCols(
				new nilnul.obj.str.be_.count_.three.vow.Ee<(double,double,double)>(v0)
			);
			
		}

		public static Tertiary4dbl OfCols(Ee<(double, double, double)> ee)
		{

			return OfCols(
				ee.ee.ElementAt(0)
				,
				ee.ee.ElementAt(1)
				,
				ee.ee.ElementAt(2)
			);
		}
	}
}
