using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.be
{
	[Obsolete()]
	public partial class Square

	{
		static public bool _Be(Matrix matrix_notNull) {

			return nilnul.collection.matrix.twoDimensionalArray._be.Square<double>.Eval(matrix_notNull.components);
		
		}


		static public bool Eval(double[,] _notNull) {
			return nilnul.collection.matrix.twoDimensionalArray._be.Square<double>.Eval(_notNull);
		
		}

		public class Be_ofDoubleArray
			:nilnul.bit.Be<double[,]>
		{

			public Be_ofDoubleArray()
				:base(Eval)
			{

			}
		}


		public class Asserted
			:nilnul.bit.be.Asserted<double[,],Be_ofDoubleArray >
		{

			public Asserted(double[,] array)
				:base(array)
			{

			}
		}





	

		
	}
}
