using nilnul.num.real.str.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.sel_.linear_
{



	/// todo: investigate
	/// <see cref="matrix.op_.IElementary"/>
	/// <summary>
	/// like the StructuredQueryingLanguage to select from one table:
	///		selec col1, col1, col2, col1 + col2
	///			from table1
	/// ;
	/// </summary>
	/// <remarks>
	/// conserving the <see cref="nilnul.num.real.vecs.IHull"/>
	/// eg:
	///	returning the new column/row by:
	///			aX 
	///				,where a is not 0, X is the old column
	///
	/// </remarks>
	/// vs:
	///		affine:
	///			returning the new column/row by:
	///			aX +b
	///				,where a is not 0, X is the old column
	///

	static public  class _UntriviaX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Stretch_1unnil(IEnumerable<double> vec, double coef
			///, double intercept
		) {
			return nilnul.num.real.str.op_._ScaleX.Scale(vec,coef);
		}

		/// <see cref="nilnul.num.real.vecs.to_."/>
		/// <see cref="nilnul.geometry"/>
		/// 
		/// <summary>
		/// absorb the other vec.
		/// 
		///  <see cref="matrix.op_.elem_.IAbsorbScaled"/> is a special case of this one by using the coefs(1, k)
		/// </summary>
		/// 
		/// <param name="vec">
		/// the vec to be replaced;
		/// </param>
		/// <param name="vec1"></param>
		/// <param name="coef">
		/// must be unnil; otherwise, this dimension would collapse/degress.
		/// </param>
		/// <param name="coef1">
		/// <see cref="nilnul.num.real.vec_.IUnnil"/> : (<paramref name="coef"/>,<paramref name="coef1"/>)
		/// </param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Swallow_2unnil(
			IEnumerable<double> vec,
			IEnumerable<double> vec1,

			double coef
			,
			double coef1
			///, double intercept
		) {
			return
				
				nilnul.num.real.str.op_._ScaleX.Scale(vec,coef).Zip(
					nilnul.num.real.str.op_._ScaleX.Scale(vec1,coef1)
					
					,
					(a,b) =>a+b

					)

				;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// to swallow only 1 others, <see cref="_Swallow_2unnil(IEnumerable{double}, IEnumerable{double}, double, double)"/>
		///;
		///to swap v1, v2
		///		, we cannot let v2 = v1, as that would collapse v1.
		///		, but we can do that by:
		///			,, v2' = v1+v2		; now v2'
		///			,, v1' = v2' -v1 = v2
		///			,, v2'' = v2' - v1' =  v1
		/// 
		/// </remarks>
		/// <param name="vec"></param>
		/// <param name="others"></param>
		/// <param name="coef">
		/// unnil, to uncollapse the dimension that is to be replaced;
		/// </param>
		/// <param name="coefs"></param>
		/// <returns></returns>
		/// alias:
		///		merge
		///		,
		///		combine

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Swallow_1unnil(
			IEnumerable<double> vec
			,
			double coef

			,
			IEnumerable<IEnumerable<double>> others
			,
			IEnumerable<double> coefs
		) {
			return

				nilnul.num.real.vec.bi_._AddX._Add_1equisize(
					vec.Scale(coef)
					,
					others.Zip( coefs, (v,s)=> v.Scale(s) ).Aggregate(
						Enumerable.Repeat(0d, vec.Count())
						,
						(a,c) => nilnul.num.real.vec.bi_._AddX._Add_1equisize(
							a,c
						)
					)
				);
				

		}



	}
}
