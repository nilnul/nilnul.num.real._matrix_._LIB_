using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.num.real.expr_._algebraic;
using nilnul.obj.stream_.slider.to_;
using nilnul.num.real.expr_.polynom.matrix_.sq;
using nilnul.obj.str;
using nilnul.num.real.expr_;
using P = nilnul.num.real.expr_.Algebraic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;



namespace nilnul.num.real.matrix_.sq_.antim_.uniup
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _ToDeterminant_1uniupper(
			int wide, Q4 a
		)
		{
			if (wide%2 == 1) {
				return 0;
			}
			return num.quotient.op_._PonentX._Quotient_1natural(a, wide);
			/// [] =>1
			/// [0] =>0
			/// [0,a
			/// -a,0] => a**2
			/// [0,a,a
			///  -a,0,a
			///  -a,-a,0
			///  ] => 0
			///  
				
			/// proof:<see cref="num.real.expr_.polynom.matrix_.sq_.antim_.uniup.crest._DeterminantX"/>
			/// 2\ ( (0+a)**n + (a-0)**n ) = a**n
			/// ,where n is even.
		}
	}





}
