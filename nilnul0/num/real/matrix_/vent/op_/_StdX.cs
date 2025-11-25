using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.vent.op_
{

	/// <summary>
	/// 
	/// make the <see cref="IVent"/> as <see cref="matrix.be_.IStd"/>, by <see cref="real.matrix.op_.colwise_.IBasic"/>:
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
	/// <remarks>
	///  like <see cref="matrix.op_.dent_.echelon_.IVent"/> which keeps the <see cref="pred.ISlv"/> unchanged, this will change <see cref="pred.ISlv"/> but the change is a <see cref="nilnul._relation.map_.IBijection"/>, hence we can map back to the original slv.
	/// </remarks>
	/// <see cref="matrix_.sq.grid_.triag_.ISkew"/>
	/// 
	static public class _StdX
	{
		/// <summary>
		/// input would become std, and at the same time, another factor is returned.
		/// 
		/// V = V' * K * S
		///		,where V is the input, a vent
		///		,where V' is std after this operation
		///		,K is grid skew, a triag
		///		, S is colwise shuffler
		///		, KS is the returned
		/// </summary>
		/// <param name="vent"></param>
		/// <returns>
		/// 
		/// </returns>
		/// 
		/// <see cref="num.real.matrix.factorize_.triad_._lu_.by_._ByIndentX"/>
		/// 
		/// todo: make this a factor:<see cref="vent.factor_.triad_.IStdSlantShuffle"/>
		static public Q4[,] _StdIntoColwise_0vent(ref Q[,] vent) {
			///shuffle
			///
			var s= _std._LeftwardX._LeftwardForRank_0vent(ref vent, out var rank); /// vent * shuffle

			
			var w = vent.GetLength(1);
			int h = vent.GetLength(0);


			var k = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(
				w	
			);


			for (int c = rank; c < w; c++) {
				/// each col would be made 0.
				/// 

				for (int r = 0; r < rank; r++)
				{
					k[ r,c] = vent[ r,c]; /// <see cref="nilnul.num.real.matrix_.sq.grid_.triag_.skew.op_._InvertX"/>

					vent[ r,c] =0;

				}
				
			}

			return nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
				k,s
			);


		
		}
	}
}
