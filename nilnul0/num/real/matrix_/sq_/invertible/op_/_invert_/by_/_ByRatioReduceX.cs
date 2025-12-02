using System;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.sq_.invertible.op_._invert_.by_
{
	///math.stackexchange.com/questions/4613823/how-does-the-gaussian-elimination-method-work-to-find-the-inverse-matrix/4831395#4831395
	///
	/// <summary>
	/// Augmenting a square matrix (LHS) with an identity matrix (RHS) and then reducing the square matrix to an identity matrix and performing the same operations on the identity matrix using elementary row operations give the inverse matrix on the (RHS)
	/// </summary>
	/// <see cref="quotient.matrix_.sq_.invertible.op_._InvertX"/>
	/// 
	static public class _ByRatioReduceX
	{
		/// <summary>
		/// the input will be transformed as <see cref="matrix_.sq_.ICanonic"/>
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		/// 
		//[Obsolete(nameof(nilnul.num.quotient.matrix_.sq_.isosize.ratio_.quota_.invert.to_._ReduceX) + " is preferred")]
		[MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
		static public Q4[,] _Invert_0invertible(ref Q4[,] m)
		{
			return nilnul.num.quotient.matrix_.sq_.invertible.op_._invert_.by_._ByRatioX._Invert_0invertible(ref m);//// as it's invertible, hence no xpn will be thrown;

			int width = m.GetLength(0);
			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(width);

			/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
			/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
			/// 

			var rank = 0;

			for (var col = 0; col < width; col++)
			{
				var row = rank;
				for (; row < width; row++)
				{
					var pivot = m[row, col];
					if (pivot != 0)      /// as the input is invertible, hence at least one pivot is unnil
					{
						obj.matrix.op_._SwapX._Swap_12row(
							ref m, rank, row
						);



						obj.matrix.op_._SwapX._Swap_12row(
							ref o, rank, row
						);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref m, rank, pivot
						);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref o, rank, pivot
						);

						for (var remained = 0; remained < row; remained++)
						{
							Q pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained, rank, pivotRemained
							);

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained, rank, pivotRemained
							);

						}

						for (var remained = row + 1; remained < width; remained++)
						{
							Q pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained, rank, pivotRemained
							);

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained, rank, pivotRemained
							);

						}


						rank++;
						break;
					}
				}

				//if (row ==width)
				//{
				//	throw new DivideByZeroException($"the matrix is not invertible");
				//}


			}
			return o;


		}

		/// <summary>
		/// the input will be intact
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public Q4[,] _Invert_0invertible(Q4[,] m)
		{

			var cloned = (Q4[,])m.Clone();
			return _Invert_0invertible(ref cloned);


		}

	}
}
