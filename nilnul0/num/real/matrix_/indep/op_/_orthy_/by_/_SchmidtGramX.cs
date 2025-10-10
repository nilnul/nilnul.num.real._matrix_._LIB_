using nilnul.collection.matrix;
using nilnul.num.real.str.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs_.indep.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="real.matrix_.indep.op_.IOrthonormal"/>
	/// <see cref="real.vecs.to_._ortho_.by_.IGramSchmidt"/>
	/// <see cref="nilnul.num.real.matrix.op_.IOrthic"/>
	static public class _SchmidtGramX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="rows">
		/// can be empty, whence the result is empty.
		/// </param>
		/// <returns>
		/// each is not normalized to avoid the sqrt.
		///
		/// </returns>
		static public List<IEnumerable<Q>> _Ortho_0indep(/*IEnumerable<Q>  head,*/ IEnumerable<IEnumerable<Q>> rows) {

			var r = new List<IEnumerable<Q>>()
			//{
			//	head
			//	}
			;

			for (int i = 0; i < rows.Count(); i++)
			{
				var enumerable = rows.ElementAt(i);

				foreach (var item in r)
				{
					enumerable = nilnul.num.real.vec.bi_._MinusX._Minus_1equisize(
						enumerable
						,
						nilnul.num.real.vec.bi_._ProjectionX._Projection_1unnil(
							enumerable, item
						)
					);
				}
				r.Add(enumerable);

			}
			return r;
		}

		static public List<IEnumerable<double>> _Ortho_0indep( IEnumerable<IEnumerable<double>> rows) {

			var r = new List<IEnumerable<double>>()
			//{
			//	head}
			;


			for (int i = 0; i < rows.Count(); i++)
			{
				
				var enumerable = rows.ElementAt(i);

				foreach (var item in r)
				{
					enumerable = nilnul.num.real.vec.bi_._MinusX._Minus_1equisize(
						enumerable
						,
						nilnul.num.real.vec.bi_._ProjectionX._Projection_1basis(
							enumerable, item
						)
					);
				}
				r.Add(enumerable);

			}
			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public List<IEnumerable<Q>> _Ortho_0indep(IEnumerable<Q[]> rows) {


			return _Ortho_0indep((IEnumerable<IEnumerable<Q>>)rows);
			
		}
		



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public List<IEnumerable<Q>> _Ortho_0rows8indep(Q[,] rows) {



			return _Ortho_0indep(rows.Rows());
		}


	}
}
