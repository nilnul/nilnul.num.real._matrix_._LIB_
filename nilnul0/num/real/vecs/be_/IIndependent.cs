using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs.be_
{
	/// <see cref="nilnul.num.real.vecs.be_."/>
	/// <see cref="nilnul.num.real.vec.set."/>
	/// <see cref="real.vec.str."/>
	/// <see cref="real.vec.compart."/>
	/// <summary>
	/// not <see cref="IDependent"/>
	/// better use <see cref="real.matrix.rows.be_.IIndependent"/> as in matrix, the vecs are of the same length.
	///  
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// 
	/// 线性无关
	///
	/// trivia vec ([] when it's in 0d) can be presented by summing of empty collection of vecs. Hence its appearance means, like matrix {[]}, not independent in that it's dependable on other vecs, an empty collection. <see cref="matrix.rows.be_.IIndependent"/>
	/// 

    public interface IIndependent
    {

		/// for 3d, or n dimensions
		/// ,we can find a vect that is perpendicular to n-1 vecs.
		/// by determinant
		///		[i,j,k]
		///		 a,b,c
		///		 d,e,f
		///	;
		///	for 2d,
		///		[i,j]
		///		 a,b
		///		 
		///	for 1d,
		///		[i]
		///
		/// , that means: for no vec can we find a perpendicular one. as perpendicular exists only for 2d or more dimensions;
		///
		/// for 0d, it's an error to ask such question.
		///	
    }


}
