using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.vec.str.co
{
	///
	/// <see cref="num.real.vec.str.co."/>
	///<summary>
	///regard the right matrix as col major, thus a str of vecs in the form of cols
	/// </summary>
	/// alias:
	///		vecs1vecs
	///		vecs9vecs
	///		vecs2vecs
	///		vecs5vecs
	///			where 5 means vs.
	///		vecs7vecs
	///			whre 7 means vs or serving
	///		by cartesian product
	///		by split
	///


	static public class _CartesianProductX
	{




		///  [a,b,c] where a,b,c each is vector, of length n
		///  [d,e] , where d,e each is vector, of length n
		///   a
		///   b
		///   c    
		///   *
		///   [d,e]   #write down as colwise.
		///  =
		///  a.d, a.e
		///  b.d, b.e
		///  c.d, c.e
		/// the dimensions would be: 3*2. (As we enumerate, we select a, and for a, we enumerate thru d,e. So a.d, a.e shall be the first vec among the result; so in the above writing, it's rowmajor.)
		/// <summary>
		/// regard operand as seq of vecs.
		/// In convention, the left operand is written as rowmajor; the right operand is written as colmajor. But per this implementation, how to write is not essential.
		/// as long as the component's size is of a preset value (in other words, they are of the same arity.). The size of the major/minor can be arbitratry, and would determine the result's major size and minor size.
		/// </summary>
		///<param name="major">
		/// the size of the major is the size of the result.
		/// determines the whole structure: how many components do we have?
		/// Here we don't care about the inner of component or how many are there inner of the component.
		/// </param>
		/// <param name="minor_cols">
		///  the size of the minor is the size of the resulted component.
		/// </param>
		/// <returns>
		/// 
		/// the result's length is the same as the length of major.
		///  the component's length is the same as the length of minor.
		/// </returns>
		/// <remarks>
		/// the component of inputs are of the same size. upon returned, these sizes collapse and would obliterate, having no impact on the result anymore.
		/// </remarks>
		/// if major is empty, the result would be empty.
		///   eg: 0*3, where we can say 0*3 is different from 0*0.
		///		 the minor could be 7*3, where 7 is the major size. or in rowmajor world, 3*7, as this is to the right.
		///		the result of multiplication would be 0*7
		///		
		/// if minor is empty, the result would be str of 0ary vec.
		///		eg: major is 9*5， minor is 0*5, the result would be 9*0.
		static public IEnumerable<
			IEnumerable<(IEnumerable< double>,IEnumerable<double>)>
		> _Multi_vecsAssumeEquisize(
			IEnumerable<IEnumerable<double>> major
			,
			IEnumerable<IEnumerable<double>> minor_cols
		)
		{
			return major.Select(
				x => minor_cols.Select(y=>(x,y))
			);
		}

	}
}
