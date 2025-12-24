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



namespace nilnul.num.real.matrix_.sq_.antim_.iv
{
	static public class _DeterminantX
	{
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _ToDeterminant_p0rightCells(
			 Q4 a01, Q4 a02,Q4 a03
			,
					 Q4 a12, Q4 a13
			,
							Q4 a23
		)
		{
			Q4 t = a01* a23-a02*a13+a12*a03;
			return  t*t;
		}
	}





}
