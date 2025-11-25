using System.Linq;

namespace nilnul.num.real.matrix_.sq_.isosize.expr_.polynom_.unary_
{
	public class Std
	{
		/// <summary>
		/// lowest degree first; eg:
		///		[1,2,3] means 1+2x+3x^2+1*x^3
		///	; the highest degree is always 1, and is not here
		/// </summary>
		private Q[] _coefs;


		public Q[] coefs
		{
			get { return _coefs; }
			set { _coefs = value; }
		}

		//public Std(Q[] coefs)
		//{
		//		this._coefs = coefs;
		//}

		public Std(params Q[] coefs)
		{
			this._coefs = coefs;
		}

		public Std():this(new Q[0])
		{
				
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// alias:
		///		eval
		public Q[,] apply(Q[,] x) {

			var i = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(x.GetLength(0));

			foreach (var item in _coefs.Reverse())
			{


				i= nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(
					i
					, x
				);

				 nilnul.num.real.matrix_.sq.bi_.add_._RidgeX._Augment_0equilat(
						i, item
				);


			}

			return i;
		
		}

	}


}
