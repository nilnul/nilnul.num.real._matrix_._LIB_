namespace nilnul.num.real.matrix_.sq_.invertible.op_._invert_.by_
{
	///math.stackexchange.com/questions/4613823/how-does-the-gaussian-elimination-method-work-to-find-the-inverse-matrix/4831395#4831395
	///
	/// <summary>
	/// Augmenting a square matrix (LHS) with an identity matrix (RHS) and then reducing the square matrix to an identity matrix and performing the same operations on the identity matrix using elementary row operations give the inverse matrix on the (RHS)
	/// </summary>
	/// 
	static public class _ByGaussianX
	{
		/// <summary>
		/// the input will be transformed as <see cref="matrix_.sq_.ICanonic"/>
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public Q4[,] _Invert_0invertible(ref Q4[,] m) {

			int w = m.GetLength(0);
			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(w );

			/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
			/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
			/// 

			var diag = 0;

			for (var col = 0; col < w; col++)
			{
				for (var row = diag; row < w; row++)
				{
					Q head = m[row, col];
					if (head != 0)		/// as the input is invertible, hence at least one pivot is unnil
					{
						obj.matrix.op_._SwapX._Swap_12row(
							ref m, diag, row
						);

						obj.matrix.op_._SwapX._Swap_12row(
							ref o, diag, row
						);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref m, diag, head	
						);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref o, diag, head	
						);

						for (var remained = 0; remained < row; remained++)
						{
							Q pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained,diag,	pivotRemained
							);

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained,diag,	pivotRemained
							);

						}

						for (var remained = row + 1; remained < w; remained++)
						{
							Q pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained,diag,	pivotRemained
							);

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained,diag,	pivotRemained
							);

						}


						diag++;
						break;
					}
				}

			
			}
			return o;


		}

		/// <summary>
		/// the input will be intact
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		static public Q4[,] _Invert_0invertible( Q4[,] m) {

			var cloned = (Q4[,]) m.Clone();
			return _Invert_0invertible(ref cloned);


		}

	}
}
