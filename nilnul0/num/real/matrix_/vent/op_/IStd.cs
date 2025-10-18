using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent.op_
{

	/// <summary>
	/// 
	/// make the <see cref="IVent"/> as <see cref="be_.IStd"/>, by <see cref="real.matrix.op_.colwise_.IElementary"/>:
	///		,shed one column:
	///			[
	///				1,	0	,2
	///				0,	1	,3
	///			]
	///			,to:
	///			[x0 +2 x2,		x1,	x2]	
	///			[	
	///				1,			0,	2- 1*2
	///				0,			1,	3-0*2		# by subtract 2* c[0]   
	///			] 
	///					#equiv * [
	///						1	0	-2
	///							1
	///								1
	///					] *[
	///						1	0	2
	///							1	0
	///								1
	///					] 
	///			=
	///			[
	///				1,	0,	0
	///				0,	1,	3		
	///			]
	///			,to:
	///				x0 +2 x2,	x1 + 3 x2,		x2
	///			[
	///				1,			0,				0- 0*3
	///				0,			1,				3-1*3		# by subtract 3* c[1]
	///			]
	///					#equiv * [
	///						1	0	0
	///							1	-3
	///								1
	///					] *[
	///						1	0	0
	///							1	3
	///								1
	///					] 
	///				
	///			=
	///			x0 +2 x2,	x1 + 3 x2,		x2
	///			
	///			[
	///				1,	0,	0
	///				0,	1,	0		
	///			]
	///		,
	///		so:
	///			x` = 
	///				[
	///					1	0	2
	///					0	1	0
	///					0	0	1
	///				]
	///				[
	///					1	0	0
	///					0	1	3
	///					0	0	1
	///				]x
	///				=
	///				[
	///					1	0	2
	///					0	1	3
	///					0	0	1
	///				]x
	///				=
	///					x0+2x2, x1+3x2 , x2
	///		,also,
	///			x=
	///				[
	///					1	0	-2
	///					0	1	-3
	///					0	0	1
	///				] x`
	///				=
	///				[
	///					1	0	-2
	///					0	1	0
	///					0	0	1
	///				]
	///				[
	///					1	0	0
	///					0	1	-3
	///					0	0	1
	///				] x`^T
	///				
	///				= x0` -2 x2`, x1` - 3x2`, x2`	
	///  
	/// </summary>
	/// 
	public interface IStd
	{
	}
}
