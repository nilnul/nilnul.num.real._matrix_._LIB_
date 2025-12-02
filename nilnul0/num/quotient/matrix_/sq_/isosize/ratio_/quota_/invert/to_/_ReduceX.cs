namespace nilnul.num.quotient.matrix_.sq_.isosize.ratio_.quota_.invert.to_
{

	/// <see cref="num.real.matrix_.sq.op_._invert_.by_.IGaussian"/>
	/// <see cref="num.quotient.matrix_.sq_.isosize.co.op_.IDivide"/>
	/// <summary>
	///  note this is quota: A\I
	///  ,not per: A/I
	/// </summary>
	/// <remarks>
	/// this can be used to solve <see cref="num.real.matrix.pred_.rudic_.IEquatation"/>
	/// </remarks>
	static public class _ReduceX
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
		/// <remarks>
		/// 
		/// </remarks>
		/// <param name="m">
		/// when this method is complete, mutated is <see cref="real.matrix_.sq_.IVent"/>, either an ideal, or not. If it's not ideal, then the input is uninvertible.
		/// the returned is A\1, if mutated is ideal;
		/// the returned is R, if mutated is not ideal, and RA = mutated A`.
		///		,or R\A` =A
		///	;
		///	alias:
		///		denominator, but here it can be 0, and it is the divisor in a dividing.
		/// </param>
		/// 
		/// <returns>
		/// numerator in fraction;
		/// ;input is mutated as denominator.
		/// </returns>
		static public Q4[,] _Invert_0square(ref Q4[,] m)
		{

			int width = m.GetLength(0);
			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(width);  /// numerator

																		/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
																		/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
																		/// 

			var rank = 0;

			for (var c = 0; c < width; c++)
			{
				for (var r = rank; r < width; r++)
				{
					var pivot = m[r, c];
					if (pivot != 0)     /// as the input is invertible, hence at least one pivot is unnil
					{
						//obj.matrix.op_._SwapX._Swap_12row(
						//	ref m, diag, r
						//);

						m[rank, c] =1;

						var cPlus = c+1;

						if (r==rank)
						{
							if (pivot!=1)
							{
								for (int i = cPlus; i < width; i++)
								{
									m[rank, i] /= pivot;
								}

							}

						}
						else
						{
							m[r, c] =0;

							if (pivot ==1)
							{
								for (int i = cPlus; i < width; i++)
								{
									(m[rank, i], m[r, i]) = (m[r, i], m[rank, i]);
								}

							}
							else
							{
								for (int i = cPlus; i < width; i++)
								{
									(m[rank, i], m[r, i]) = (m[r, i]/pivot, m[rank, i]);
								}

							}

						}


						obj.matrix.op_._SwapX._Swap_12row(
							ref o, rank, r
						);  /// multiply by a common unnil multiplier

						real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
							ref o, rank, pivot
						);

						//real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
						//	ref o, diag, pivot
						//);


						for (var remained = 0; remained < rank; remained++)
						{
							var pivotRemained = m[remained, c];

							//real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
							//	ref m, remained, diag, pivotRemained
							//);
							if (pivotRemained == 0) continue;

							m[remained, c] =0;

							for (int i = cPlus; i < width; i++)
							{
								m[remained,i] -= m[rank,i] * pivotRemained;
							}

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o,  remained,rank, pivotRemained
							);

						}

						for (var remained = rank + 1; remained < width; remained++)
						{
							var pivotRemained = m[remained, c];

							//real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
							//	ref m, remained, diag, pivotRemained
							//);
							if (pivotRemained == 0) continue;

							m[remained, c] =0;

							for (int i = cPlus; i < width; i++)
							{
								m[remained,i] -= m[rank,i] * pivotRemained;
							}

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o,  remained,rank, pivotRemained
							);
						}

						rank++;
						break;
					}
				} //diag unchanged, if the col is zero. 
				///  for invert, this shall throw exception. but to solve <see cref="matrix.pred_.rudic_.univar_.col_.equit.ISolve"/>, we need go on. <see cref="num.quotient.matrix.factorize_.co_._VertibleVentX"/>

			}
			return o;


		}

		//static public void _Dividend_0divisor(ref Q4[,] divisor, out Q4[,] dividend) 
		//{



		//}


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
		///				]
		///		,from which we can judge whether the inversal is successful:
		///			if it's rankful, then it's successful.
		/// </returns>
		static public (Q4[,] vent, Q4[,] vertible ) _ToQuota_0divisor(Q4[,] divisor)
		{

			var divisorCloned = (Q4[,])divisor.Clone();
			return (divisorCloned, _Invert_0square(ref divisorCloned) );


		}

	}
}
