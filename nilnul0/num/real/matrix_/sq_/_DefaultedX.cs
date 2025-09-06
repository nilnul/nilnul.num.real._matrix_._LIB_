using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_
{
	static public class _DefaultedX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] Generate(int size) {
			return  nilnul.obj.matrix_._SquareX._Init_0width<double>(size);
		}

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R[,] GenerateAsReals(int size) {
			var r = new R[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					r[i, j] =  nilnul.num.real_.Quotient_denomNonnil.Nil;
				}

			}

			return r;

		}
		static public Q[,] Generate8quotient(int size) {
			var r = new Q[size, size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					r[i, j] =  Q.Nil;
				}

			}

			return r;

		}


	}
}