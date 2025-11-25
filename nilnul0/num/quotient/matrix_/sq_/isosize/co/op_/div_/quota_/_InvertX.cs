namespace nilnul.num.quotient.matrix_.sq_.isosize.co.op_.div_.quota_
{

	/// <see cref="num.real.matrix_.sq.op_._invert_.by_.IGaussian"/>
	/// <see cref="num.quotient.matrix_.sq_.isosize.co.op_.IDivide"/>
	static public class _InvertX
	{
		/// <summary>
		/// try to make the divisor to be I, by multiplying both dividend and divisor by a invertible matrix.
		/// if divisor becomes I, then dividend becomes inverse. 
		/// if divisor cannot becomes I, then dividend is not inversible.
		/// 
		/// the input will be transformed as <see cref="matrix_.sq_.ICanonic"/>; if the input fails such transformation, then the input is uninvertible, and this shall throw.
		/// 
		///	 A\I 
		///	 =>
		///	 
		/// G [A\I]
		///   = GA \ GI
		///   =GA \ G
		///   = A' \ R
		///   ,where 
		///		R is the returned
		///		, A' would be A mutated
		///		G is <see cref="real.matrix.op_.rowwise_"/><see cref="real.matrix.op_.IGaussian"/>
		///   ,GA would be <see cref="matrix_.sq_.diag_.IBoolish"/>
		///   ,G is invertible.
		///  ; if A' is ideal, then R is A\1
		///  , otherwise, A is not invertible.  then mutated A' is <see cref="matrix_.sq_.diag_.boolish_.IDegenerate"/>, and returned R is invertible. and RA=A'
		/// 
		/// </summary>
		/// <param name="m">
		/// when this method is complete, mutated is <see cref="real.matrix_.sq_.IVent"/>, either an ideal, or not. If it's not ideal, then the input is uninvertible.
		/// the returned is A\1, if mutated is ideal;
		/// the returned is R, if mutated is not ideal, and RA = mutated A`.
		///		,or R\A` =A
		///	;
		///	alias:
		///		denominator, but here it can 0, and it is the divisor in a dividing.
		/// </param>
		/// 
		/// <returns>
		/// numerator in fraction;
		/// ;input is mutated as denominator.
		/// if the divisor is 0, we cannot go on.
		/// </returns>
		static public Q4[,] _Dividend_0divisor(ref Q4[,] m) {

			int w = m.GetLength(0);
			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(w );	/// numerator

			/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
			/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
			/// 

			var diag = 0;

			for (var col = 0; col < w; col++)
			{
				for (var row = diag; row < w; row++)
				{
					var head = m[row, col];
					if (head != 0)		/// as the input is invertible, hence at least one pivot is unnil
					{
						obj.matrix.op_._SwapX._Swap_12row(
							ref m, diag, row
						);

						obj.matrix.op_._SwapX._Swap_12row(
							ref o, diag, row
						);	/// multiply by a common unnil multiplier

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref m, diag, head	
						);

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref o, diag, head	
						);


						for (var remained = 0; remained < row; remained++)
						{
							var pivotRemained = m[remained, col];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained,diag,	pivotRemained
							);

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained,diag,	pivotRemained
							);

						}

						for (var remained = row + 1; remained < w; remained++)
						{
							var pivotRemained = m[remained, col];

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
		/// <param name="divisor"></param>
		/// <returns>
		/// a fraction.
		/// .dividend is gaussian
		///		<see cref="real.matrix_.sq_.IInvertible"/>
		/// 
		/// .divisor
		///		<see cref="real.matrix_.IVent"/>
		///			eg:
		///				[
		///					1,2, 0
		///					0,0, 1
		///					0,0, 0
		/// </returns>
		static public (Q4[,] dividend, Q4[,] divisor) _Divide_0divisor( Q4[,] divisor) {

			var divisorCloned = (Q4[,]) divisor.Clone();
			return (_Dividend_0divisor(ref divisorCloned), divisorCloned );


		}

	}
}
