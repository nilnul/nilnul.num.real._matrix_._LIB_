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



namespace nilnul.num.real.matrix_.sq_.antim_.uniup.crest
{
	static public class _DeterminantX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _ToDeterminant_1uniupper(
			int wide, Q4 a, Q4 x
		)
		{
			return (
				num.quotient.op_._PonentX._Quotient_1natural(x+ a, wide)
				+
				num.quotient.op_._PonentX._Quotient_1natural(x - a, wide)
			)
			/2;
			/// proof:<see cref="num.real.expr_.polynom.matrix_.sq_.antim_.uniup.crest._DeterminantX"/>
		}
	}





}
