using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_.sel_.linear_.span_
{
	/// transpose equivalent to <see cref="IRowwise"/>
	///
	/// <summary>
	/// if we swap two cols, we swap the position of the two coefs of the linear transforming;
	/// if we scale one col, which is originally
	///		c x, where c is the column,
	///		,to:
	///		c s x/s ,where s is the scale
	///		, then:
	///			x' = x/s
	///	;
	///	if we linear combinate two cols untrivialy, which is originally :
	///		cx + dy
	///		,to:
	///		(c  + d t) x + d y, where (s,d) is untrivia
	///			, which is also:
	///		 c x + d (tx+y)
	///		,
	///		then:
	///			 x= x'
	///			 y = tx' + y'
	///		,thus
	///			x' =x
	///			y' = y -tx
	///
	/// ;
	///	for multiple columns,
	///		C X
	///		=
	///		CXJ/J
	///			,where J would do some <see cref="matrix.op_.sel_.linear_.span_.IColwise"/>
	///		=
	///		(E Y + 0Z ) /J
	///		=
	///		[E , 0] [ Y;Z ] /J
	///			,where Z is the dimensions of subspace
	///
	///		CXJ/J = C X/J J
	///			  = C W J
	///				,where X/J = W, and X=WJ
	///			 = [E , 0] [ U,V ]^T
	///				, where W =[U;V], V is the dimensions of subspace that is free, U is the restricted dimensions; the total space is dimensioned at the rank of E, spanned by E.
	///
	/// eg:
	///			[1,0,0,   1, 0, 0
	///			 0,1,0,   0, 1, 0
	///			0, 0, 1,  0, 0, 0
	///
	///          special:  x,y,z,0,0,0 = b
	///          homoSlv:  x= -u, y= -v, z =0, u, v, w
	///				, the slv is 6d. spanning: 3d space.
	///				
	/// eg:
	///			[1,0,0,   1, 1, 0
	///			 0,1,0,   0, 1, 0
	///			0, 0, 1,  0, 0, 1
	///
	///          special:  x,y,z,0,0,0 = b
	///          homoSlv:  x= -u-v, y= -v, z =-w, u, v, w
	///				, the slv is 6d. spanning: 3d space.
	///				
	/// eg:
	///			[1,0,0,   1, 1, 0, 0
	///			 0,1,0,   0, 1, 0, 0
	///			0, 0, 1,  0, 0, 0, 0
	///
	///          special:  x,y,z,0,0,0,0 = b
	///          homoSlv:  x= -u-v, y= -v, z =0, u, v, w, s
	///				, the slv is 7d. spanning: 4d space.
	///				
	/// eg:
	///			[1,0,0,   1, 1, 0, 0
	///			 0,1,0,   0, 0, 0, 0
	///			0, 0, 1,  0, 0, 0, 0
	///
	///          special:  x,y,z,0,0,0,0 = b
	///          homoSlv:  x= -u-v, y= 0, z =0, u, v, w, s
	///				, the slv is 7d. spanning: 4d space.
	///	; rowwise is like changing the basis of the span;
	///	colwise is like changing the axis of slv Space.
	///          
	/// </summary>
	/// <remarks>
	/// we multiply from right a matrix to transform the columns:
	///	; to make the multiplier invertible so we can move that to the other side, we need that matrix to be square.
	///	
	/// </remarks>
	internal class IColwise
	{
	}

}
