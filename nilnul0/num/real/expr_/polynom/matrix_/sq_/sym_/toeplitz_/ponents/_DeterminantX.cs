using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynom.matrix_.sq_.sym_.toeplitz_.ponents
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public nilnul.num.real.expr_.Algebraic Determinant(
			int wide, nilnul.num.real.expr_.Var1 x
		) {
			if (wide==0)
			{
				return 1;
			}
			return nilnul.num.real.expr_.polynom.calc.op_._PonentX._Pon_0num(
				new Algebraic(1)- x*x
				, wide-1
			);

			/// You can prove that this is true by induction. If you subtract from the first row the second row times x, all the entries of the first col after the first one become 0 (and the first one is 1−x^2). Therefore, f[n](x)=(1−x^2)f[n−1](x). Since f[1] =1, f[2](x)=1−x**2, you're done.
			/// 
			/// [
			///		1-x^2, x, x^2,x^3,...,x^(n-1)
			///		0, 1,x,x^2,...,			x^(n-2)
			///		,0, x,x^2,...	
			///		...
			///		0, x^(n-2), ...,			1
			/// ]
		}
	}
}
