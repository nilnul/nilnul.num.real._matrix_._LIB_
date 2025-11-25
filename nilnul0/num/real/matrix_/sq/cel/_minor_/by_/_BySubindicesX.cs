using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.RealI;
using R2 = nilnul.num.Real;
using System.Runtime.CompilerServices;



namespace nilnul.num.real.matrix_.sq.cel._minor_.by_
{
	/// <summary>
	/// first minor. minor means minus something: here we remove some rows and columns. 
	/// Note this is a mutual recursion with determinant.
	/// </summary>
	/// <remarks>
	///	not signed. for signed <see cref="remnant.minor._CofactorX"/>
	/// </remarks>
	/// alias:
	///		余子式, 不添加符号
	///		子, means only one cel is crossed out
	public static  class _BySubindicesX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _AssumeValid(in double[,] matrix,int i,int j) {
			var full = Enumerable.Range(0, matrix.GetLength(0));


			return num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq_1rows_2cols(
				matrix,
				full.Where(x=>x!=i).ToArray()
				,
				full.Where(x => x!=j).ToArray()
			);
			
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q _AssumeValid(in Q[,] matrix,int i,int j) {
			var full = Enumerable.Range(0, matrix.GetLength(0));


			return num.real.matrix_.sq._determ_.by_._BySubmatrixX._Determinant_0sq_1rows_2cols(
				matrix,
				full.Where(x=>x!=i).ToArray()
				, 
				full.Where(x => x!=j).ToArray()
			);


			
		}





	}
}
