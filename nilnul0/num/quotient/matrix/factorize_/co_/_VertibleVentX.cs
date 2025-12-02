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
	static public class _VertibleVentX
	{
		/// <summary>
		/// 
		///	 A = G\ GA = G\ A` = G`A`
		///		,where A` is <see cref="real.matrix_.sq_.IVent"/>, which is mutated A
		///		, G` is <see cref="quotient.matrix_.sq_.IInvertible"/>
		///		
		/// 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <returns>
		///  G\ in G\A'
		///  ; the input is mutated as A` in G\A`
		/// </returns>
		static public Q4[,] Factorize(ref Q4[,] m)
		{

			int h = m.GetLength(0);
			int w = m.GetLength(1);

			var o = real.matrix_.sq_._CanonicalX.Generate8quotient(h);  ///  I * m

																		/// <see cref="real.matrix.factorize_.triad_._lu_.by_._ByEchelonX"/>
																		/// <see cref="real.matrix.op_.dent_.echelon_._VentX"/>
																		/// 

			var rank = 0;

			for (var c = 0; c < w; c++)
			{
				for (var r = rank; r < h; r++)
				{
					Q4 pivot = m[r, c];

					if (pivot != 0)     /// if the input is invertible, hence at least one pivot is unnil
					{
						m[rank, c] =1;

						//obj.matrix.op_._SwapX._Swap_12row(
						//	ref m, rank, r
						//);
						///, we can avoid previous columns:
						///
						var cPlus = c+1;
						if (r==rank)
						{
							if (pivot!=1)
							{
								for (int i = cPlus; i < w; i++)
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
								for (int i = cPlus; i < w; i++)
								{
									(m[rank, i], m[r, i]) = (m[r, i], m[rank, i]);
								}

							}
							else
							{
								for (int i = cPlus; i < w; i++)
								{
									(m[rank, i], m[r, i]) = (m[r, i]/pivot, m[rank, i]);
								}

							}

						}

						obj.matrix.op_.swap_._ColwiseX._Swap_12col(
							ref o, rank, r
						); /// the inverse of swap is still swap.

						//real.matrix.op_.basic_.shed_._ByDivideX._Shed_2divisorUnish(
						//	ref m, rank, pivot
						//);

						real.matrix.op_.basic_.shed_._ColwiseX._Shed_2unnilUnish(
							ref o, rank, pivot
						);

						for (var remained = 0; remained < rank; remained++)
						{
							Q4 pivotRemained = m[remained, c];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained, rank, pivotRemained
							);

							real.matrix.op_.basic_.skew_._ColwiseX._Skew_12col_3nilish(
								ref o, rank, remained, pivotRemained
							); /// <see cref="real.matrix_.sq_.basic_.skew.op_._InvertX"/>

						}

						for (var remained = rank + 1; remained < h; remained++)
						{
							Q4 pivotRemained = m[remained, c];

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref m, remained, rank, pivotRemained
							);

							real.matrix.op_.basic_.skew_._ColwiseX._Skew_12col_3nilish(
								ref o, rank, remained, pivotRemained
							); /// <see cref="real.matrix_.sq_.basic_.skew.op_._InvertX"/>
						}

						rank++;
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
		static public (Q4[,] vertible, Q4[,] vent) Factorize(Q4[,] m)
		{

			var cloned = (Q4[,])m.Clone();
			return (Factorize(ref cloned), cloned);


		}

	}
}
