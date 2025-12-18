using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using T1 = nilnul.num.real.expr_.Algebraic;
namespace nilnul.num.real.expr_.polynom.matrix_.sq_.sym_.toeplitz_
{
	/// <summary>
	/// [
	///		1,x,x^2,x^3,...,x^(n-1)
	///		x,x^2,x^3,x^4,...,x^(n-2)
	///		
	///		...
	///		x^(n-1),x^(n-2),x^(n-3),...,1
	/// ]
	/// </summary>
	/// alias:
	///		ponents
	///		kms
	static public class _KacMurdockSzegoX
	{
		/// <summary>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="m"></param>
		/// 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public T1[,] ToKms(int wide, nilnul.num.real.expr_.Var1 x) {

			return nilnul.obj.matrix_.sq_.toeplitz_._SymmetricX._ToSymmetricToeplitz_0row1st(
				Enumerable.Range(0,wide).Select(
					k => nilnul.num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(
						x
						,
						k
					)
				)
			);

		}
	}
}
