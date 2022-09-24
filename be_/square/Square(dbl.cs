using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix
{
	[Obsolete()]
	public  class Square
		:nilnul.bit.AdjectiveI3<Matrix>

	{
		static public bool _Be(Matrix matrix_notNull) {

			return nilnul.collection.matrix.twoDimensionalArray._be.Square<double>.Eval(matrix_notNull.components);
		
		}


		static public bool _Be(double[,] _notNull) {
			return nilnul.collection.matrix.twoDimensionalArray._be.Square<double>.Eval(_notNull);
		
		}


		static public nilnul.bit.Assertion_FroAdj2<double[,]> AssertionOfDouble = new bit.Assertion_FroAdj2<double[,]>(_Be);




		private bool _be(Matrix obj_notNull)
		{
			return _Be(obj_notNull);

			throw new NotImplementedException();
		}

		public bool be(NotNull2<Matrix> val)
		{
			return _Be(val.val);

			throw new NotImplementedException();
		}

		
	}
}
