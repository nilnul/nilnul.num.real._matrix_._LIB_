using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.fn_.linear.of_
{
	/// <summary>
	/// regression is projection:
	///  Y =aX +b = aX + b[1,...] =aX + bU
	///  , where X, Y, U is vect
	///  , then:
	///		X,U forms a plane. Y would project onto that plane. The shadow (<see cref="nilnul.num.real.vec.op_._proj."/>) is what we seek. 
	/// 
	/// 
	/// 
	/// ;eg for three datapoints (x1,y1),(x2,y2),(x3,y3)  space, let's find a linear equation such that:
	///  Y= a + bX
	///		=  [a,a,a] + bX
	///		,where X = (x1,x2,x3) and Y = (y1,y2,y3), A =[a,a,a]
	///	;
	///	then the projection of Y onto the plane defined by X and A, denoted as Y', shall be the linear function we seek.
	///	Y - Y' would be the rejection. and it's the least in square sense;
	///	
	/// </summary>
	/// then 
	/// [a,b] = (W^T W )\W^T Y
	///		,where W = [1 X]
	/// 
	/// <see cref="num.real.matrix.optim_.ILinearLeastSquare"/>
	internal class ILeastSquare
	{
	}
}
