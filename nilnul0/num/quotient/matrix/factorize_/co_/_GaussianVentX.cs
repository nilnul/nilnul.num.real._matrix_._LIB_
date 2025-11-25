namespace nilnul.num.quotient.matrix.factorize_.co_
{
	/// <inheritdoc cref="matrix_.sq.op_._invert_.by_.IGaussian"/>
	/// <inheritdoc cref="quotient.matrix_.sq.op_._invert_.by_._ByGaussianX"/>
	/// 
	/// <summary>
	/// A = G A'
	///		,where G is <see cref="real.matrix_.sq_.IInvertible"/>
	///		A` is <see cref="real.matrix_.sq_.IVent"/>
	///	; note 
	///		  G A`  !=  A`G
	/// this is different from 
	///		A = A`G1
	///		,where G1 is different
	///		
	/// </summary>
	/// 
	static public class _GaussianVentX
	{
		/// <summary>
		/// 
		///	 A = G\ GA = G\ A`
		///		,where A` is <see cref="real.matrix_.sq_.IVent"/>, which is mutated A
		///		
		/// 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <returns>
		///  G\ in G\A'
		///  ; the input is mutated as A` in G\A`
		/// </returns>
		static public Q4[,] Factorize(ref Q4[,] m) {

			int h = m.GetLength(0);
			int w = m.GetLength(1);

			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(h );  ///  I m

			/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
			/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
			/// 

			var diag = 0;

			for (var col = 0; col < w; col++)
			{
				for (var row = diag; row < h; row++)
				{
					Q4 head = m[row, col];
					if (head != 0)		/// if the input is invertible, hence at least one pivot is unnil
					{
						obj.matrix.op_._SwapX._Swap_12row(
							ref m, diag, row
						);

						obj.matrix.op_._SwapX._Swap_12row(
							ref o, diag, row
						); /// the inverse of swap is still swap.

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref m, diag, head	
						);

						real.matrix.op_.basic_._ShedX._Shed_2unnilUnish(
							ref o, diag, head	
						);

						for (var remained = 0; remained < row; remained++)
						{
							Q4 pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained,diag,	pivotRemained
							);

							real.matrix.op_.basic_._SkewX._Skew_12row_3nilish(
								ref o, remained,diag,	pivotRemained
							);

						}

						for (var remained = row + 1; remained < h; remained++)
						{
							Q4 pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained,diag,	pivotRemained
							);

							real.matrix.op_.basic_._SkewX._Skew_12row_3nilish(
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
		static public (Q4[,] gaussian, Q4[,] vent) Factorize( Q4[,] m) {

			var cloned = (Q4[,]) m.Clone();
			return (Factorize(ref cloned), cloned);


		}

	}
}
