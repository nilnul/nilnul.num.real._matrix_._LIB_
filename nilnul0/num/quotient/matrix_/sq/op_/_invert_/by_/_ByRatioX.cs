using System;

namespace nilnul.num.quotient.matrix_.sq.op_._invert_.by_
{

	/// <see cref="num.real.matrix_.sq.op_._invert_.by_.IGaussian"/>
	/// <see cref="num.quotient.matrix_.sq_.isosize.co.op_.IDivide"/>
	/// <see cref="num.quotient.matrix_.sq_.isosize.ratio.op_.IReduce"/>
	/// <see cref="num.quotient.matrix_.sq_.isosize.ratio_.quota_.invert.to_._ReduceX"/>
	/// 
	/// <summary>
	/// </summary>
	static public class _ByRatioX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns>
		/// if the divisor is 0, we terminate, as we cannot go on.
		/// 
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
				int r = rank;
				for (; r < width; r++)
				{
					var pivot = m[r, c];
					if (pivot != 0)     /// 
					{


						m[rank, c] =1;

						var cPlus = c+1;

						if (r!=rank)
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
						else
						{
							if (pivot!=1)
							{
								for (int i = cPlus; i < width; i++)
								{
									m[rank, i] /= pivot;
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
								m[remained, i] -= m[rank, i] * pivotRemained;
							}

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained, rank, pivotRemained
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
								m[remained, i] -= m[rank, i] * pivotRemained;
							}

							real.matrix.op_.basic_.skew_._BySubtractX._Skew_12row_3nilish(
								ref o, remained, rank, pivotRemained
							);
						}

						rank++;
						break;
					}
				} //rank unchanged, if the col is zero. 
				if (rank ==c)
				{
					throw new DivideByZeroException(
						$"{m} is not invertible"	
					);
					///  for invert, this shall throw exception. 
					///  
				}
			}
			return o;


		}


		static public Q4[,]  _Invert_0square(Q4[,] divisor)
		{

			var divisorCloned = (Q4[,])divisor.Clone();
			return  _Invert_0square(ref divisorCloned);


		}

	}
}
