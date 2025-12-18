using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.negsym_.ii_
{
	/// <summary>
	/// eg:
	///  rotation matrix is negsym:
	///		{
	///			cos(a), sin(a)
	///			cos(a+tau/4) = -sin(a), sin(a+tau/4) = cos(a)
	///		}
	///		,which is a rowwise morph where the vector must be multiplied from left; and this is an axis, not vector, rotation;
	///		,when the vector is multiplied from right, then the axis is rotated negAngle, and the vector is rotated to the other direction
	///	; to make it colwise:
	///		{
	///			cos(a), -sin(a)
	///			sin(a), cos(a)
	///		}
	///		, when vector is multiplied from left, it's a vector rotation, as the vector is projected to the 1st column newX, then to the 2nd column as newY.
	/// </summary>
	internal class IRotate
	{
	}
}
