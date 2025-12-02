using System.Linq;

namespace nilnul.num.real.matrix_.sq_.isosize.expr_.polynom_.unary_.std._eval_.by_
{
	static public class _PowX
	{
		/// <summary>
		/// lowest degree first; eg:
		///		[1,2,3] means 1+2x+3x^2+1*x^3
		///	; the highest degree is always 1, and is not here
		/// </summary>
		/// alias:
		///		eval
		static public Q[,] Eval(Q[] _coefs,Q[,] x) {

			int size = x.GetLength(0);
			var monic = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(size);

			var r = nilnul.num.real.matrix_.sq_._NilX.Generate8quotient(
				size	
			);

			foreach (var item in _coefs)
			{

		

				nilnul.num.real.matrix.bi_._AddX._Augment_1equisize(
					r
					,	
					nilnul.num.real.matrix.op_._ScaleX.ScaleAsNew(
						monic, item
					)
				);

				monic= nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
					monic
					, x
				);

		


			}

			/// now the highest degree is 1, so add x^n
			/// 

				nilnul.num.real.matrix.bi_._AddX._Augment_1equisize(
					r
					,	
					
						monic
					
				);


			return r;
		
		}

	}


}
