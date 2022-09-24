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
	public class Tetra4dbl
		: nilnul.obj.matrix_.square_.Quatic<double>
	{
		public Tetra4dbl(double[,] val) : base(val)
		{
		}

		/// <summary>
		/// as in dotnet, the two-dimensional matrix is row-major, or row by row 
		/// </summary>
		/// <param name="v0"></param>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <param name="v3"></param>
		public Tetra4dbl(
			(double,double,double,double) v0
			,
			(double,double, double,double) v1
			,
			(double,double,double,double ) v2
			,
			(double,double,double,double ) v3

		):this(
			nilnul.obj.matrix.of_.vecs_._OfRowsX.OfVecs(
				new[] { v0, v1, v2,v3 }.Select(t=> new nilnul.obj.vec_.Quod<double>(t))
			)
		)
		{

		}

		static public Tetra4dbl OfCols(
			(double, double, double, double) v0
			,
			(double, double, double, double) v1
			,
			(double, double, double, double) v2
			,
			(double, double, double, double) v3

		)
		{
			return new Tetra4dbl(
				nilnul.obj.matrix.of_.vecs_._OfColsX.OfVecs(
					new[] { v0, v1, v2 ,v3}
					.Select(
						t => new nilnul.obj.vec_.Quod<double>(t)
					)
				)
			);


		}
	}
}
