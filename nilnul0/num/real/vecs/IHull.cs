using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vecs
{
	/// <see cref="num.real.IVecs"/>
	/// 
	/// this is bettered defined as <see cref="real.matrix.rows.ISpan"/>
	/// how to define a space?
	///		we can use the linear combination of vecs.
	///	how to find the regular/std/normal/canonical form of a space?
	///		, as many equivalent set of vecs can define the same space, hence there is no unique way to represent a space.
	///			,,eg:
	///				for 1d,  {1, -1} can be chosen, and we prefer 1.
	///				for 2d, we need a std form of a matrix of two rows, that is a matrix 2*n. the <see cref="real.matrix.op_.IRowSpan"/> operation can be carried out, resulting in a <see cref="real.matrix.op_.rowspan_.indent_.std_.IChimney"/>. 
	///
	/// 
	///
	/// <summary>
	/// all linear combinations.
	/// </summary>
	/// <remarks>
	/// hull is more like a family of vecs, each of which is equivalent to describe the same subspace.
	/// </remarks>
	/// 
	/// alias:
	/// 
	///		hull
	///			,somewhat like null.
	///		frame
	///		environment
	///		platform
	///		,plat
	///		husk
	///		kernel
	///		space
	///		subspace
	///		span
	///			,which means spanning the space, like in spanning tree.
	///		linear, not good, as linear can also mean 1d, while this space can be 2d, 3d, ...
	///		linear span
	///		linear combinate
	///		basic combinate
	///		basis
	///		cone
	///		affine, which means a shift from origin, but originated is a special case of it.
	///		radiant
	///		beam
	///		simplex, which means boundaried.
	///
	///		<see cref="num.real.matrix.rows.ISpan"/>
	///	vs:
	///		span
	///			,<see cref="real.matrix.to_.ISpan"/> which means only columns hull, not rows hull
	///			, whileas this is a linear combination where coefficients cannot be negative?
	///			
	///
	/// <see cref="num.real.vecs.to_.ILinearCombinate"/>
	///		
    public interface IHull
		:vec.ISubSpace
    {
    }



}
