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
	public class Secondary4dbl
		: nilnul.obj.matrix_.square_.Secondary<double>
	{
		public Secondary4dbl(double[,] val) : base(val)
		{
		}

		/// <summary>
		/// as in dotnet, the two-dimensional matrix is row-major, or row by row 
		/// </summary>
		/// <param name="v0"></param>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <param name="v3"></param>
		public Secondary4dbl(
			(double,double) v0
			,
			(double,double) v1
			

		):this(
			nilnul.obj.matrix.of_.vecs_._OfRowsX.OfVecs(
				new[] { v0, v1 }.Select(t=> new nilnul.obj.vec_.Co<double>(t))
			)
		)
		{

		}
		public Secondary4dbl(double a, double b, double c, double d):this(
			(a,b),(c,d)
		)
		{

		}

		static public Secondary4dbl OfCols(
			(double, double) v0
			,
			(double, double) v1
			

		)
		{
			return new Secondary4dbl(
				nilnul.obj.matrix.of_.vecs_._OfColsX.OfVecs(
					new[] { v0, v1}
					.Select(
						t => new nilnul.obj.vec_.Co<double>(t)
					)
				)
			);


		}

		static public Secondary4dbl OfCols(
			double v, double v0
			,
			double v1_0, double v1
			

		)
		{
			return OfCols(
				(v,v0)
				,
				(v1_0,v1)
			);


		}

	}
}
