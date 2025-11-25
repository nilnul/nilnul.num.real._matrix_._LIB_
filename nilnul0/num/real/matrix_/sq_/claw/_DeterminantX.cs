using System.Linq;

namespace nilnul.num.real.matrix_.sq_.claw
{
	/// <summary>
	/// eg:
	///		[
	///			a0,		b1,b2,...,b[n-1]
	///			c1,		a1,0,...,0
	///			c2,		0,a2,...,0
	///			......
	///			c[n-1],	0,0,...,a[n-1]
	///		
	///		]
	///	;
	///	将第i列乘以 -m[i,0]/m[i,i]  都加到第一列上,即可化为上三角行列式
	/// ;
	/// 
	///  
	/// </summary>
	/// 

	static public class _DeterminantX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="claw">
		///  at least 1 wide. 
		/// </param>
		/// <returns></returns>
		static public Q _Determ_0claw(Q[,] claw) {
			int wMinus = claw.GetLength(0);

			var torso = Enumerable.Range(
				1, wMinus
			).ToArray();

			return torso.Select(i => claw[i, i]).Aggregate(Q.One, (a, c) => a*c)
				*
			(
				claw[0,0] 
				-
				torso.Select( 
					i=> claw[0,i] * claw[i,0] / claw[i,i]
				).Aggregate(Q.Nil, (a,c) => a+c) 
			);	/// 其算法为：将第i列乘以-bi /ai  （i=2,3,…n）都加到第1列上,将其化为上三角行列式.

		}
	}
}
