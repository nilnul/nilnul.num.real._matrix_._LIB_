using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._patch_.by_;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.factorize_.triad_._lu_.by_
{
	/// <see cref="matrix.op_.IIndent"/>
	///
	/// <summary>
	/// M=PLU
	/// ;
	/// permutation:<see cref="matrix_.sq_.IPermutational"/> 
	/// *
	/// lower *
	/// * upper|indent (which is not only upper, but also indent)
	/// ;
	/// where permutation * lower is a lower triangle, but shuffled, visually like a multimodal statistical histogram;
	/// </summary>
	/// <remarks>
	/// if the input is already an upper where the pivot is not 1, we keep the input unchanged. On the contrary, byEchelon will make the pivot as 1;
	/// 
	/// </remarks>
	/// alias:
	/// 
	/// <see cref="num.real.matrix_.vent.op_._StdX"/>
	/// <see cref="real.matrix_.vent.factor_.triad_.IStdSlantShuffle"/>
	static public class _ByIndentX
	{

		/// <summary>
		/// </summary>
		/// <remarks>
		/// the main use for this is to <see cref="matrix.factorize_.catalyst_.ILowerUpperDecompose"/>, whence <see cref="indent_.IEchelon"/> is not used, as it involves <see cref="matrix.op_.basic_.sheds_.IShrink"/>
		/// </remarks>
		/// <param name="m">
		/// it will become an upper matrix
		/// </param>
		/// <returns> 
		/// p:
		///		<see cref="matrix_.sq_.IShuffler"/>
		///	;
		///	l:
		///		rankful
		/// 
		/// out:
		/// rank
		/// </returns>
		/// alias:
		/// 
		static public (int[,] permute, Q[,] lower) Factorize(ref Q[,] m, out int rank)
		{
			 rank = 0;

			var rows = m.GetLength(0);

			var cols = m.GetLength(1);

			var permutation = nilnul.num.real.matrix_.sq_._CanonicalX.GenerateAsInts(
				rows
			);

			var lower = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(
				rows
			);

			for (var col = 0; col < cols; col++)
			{
				for (var row = rank; row < rows; row++)
				{
					Q head = m[row, col];
					if (head != 0)
					{
						//if (rank!=row)
						{
							op_._indent._GaussGramX._Swap(ref m, rank, row);  /// might be the same row; to make the row move upward.

							///  PL  Sm
							///  , where S is the previous swap matrix
							///  ,where L the lower is:
							/// [
							///		...
							///		...		1	0
							///		...		k1	1	0
							///		...		k2	0	1
							///		...		k3	0	0	1
							/// ]
							///;
							///To compensate the 'S', a swp,
							///PL S\  Sm
							///;
							/// Now consider S\1, which is about the last 3 columns only. So we can move it to the left of 'L';
							/// PS\L Sm
							/// = PS\  L  Sm
							/// , where S\ is <see cref="matrix_.sq_.basic_.swap.op_._InvertX"/> 
							/// ; the PS\ becomes:
							/// 


							obj.matrix.op_.swap_._ColwiseX._Swap_2dif
							(
								ref lower
								, rank
								, row
							);  
							/// [
							///		...
							///		...		1	0
							///		...		k1	0	1
							///		...		k2	1	0
							///		...		k3	0	0	1
							/// ]


							obj.matrix.op_._SwapX._Swap_2dif
							(
								ref lower
								, rank
								, row
							);  
							/// [
							///		...
							///		...		1	
							///		...		k2	1	
							///		...		k1	0	1
							///		...		k3	0	0	1
							/// ]

							obj.matrix.op_.swap_._ColwiseX._Swap_2dif
							(
								ref permutation
								, rank
								, row
							);  /// this is the inverse matrix of the previous line
							///
							/// hence the expression becomes:
							///		P` L` M`


						}

						/// make all other|lower rows 0
						///

						for (var remained = row + 1; remained < rows; remained++)
						{
							Q scale = m[remained, col]/head;

							op_._indent._GaussGramX._Skew_12row_3nilish(
								ref m, remained, rank,
								-scale
							);   ///<see cref="nilnul.num.real.matrix.op_."/>


							///  PL  Wm
							///	, where W is the just applied Skew matrix:
							///					rank
							///		{
							///			
							///	remained:		k	1
							///		
							///		}
							///  ,where L the lower is:
							/// [
							///		...
							///		...		1	0
							///		...		k1	1	0
							///		...		k2	0	1
							///		...		k3	0	0	1
							/// ]
							///;
							///To compensate the 'W', a skew,
							///P	L W\	  Wm
							///;
							/// Now consider W\1, which is multiplying L from right, changing the last 3 columns only, keeping LW\ still as a lower triag matrix. 
							/// ;W\ is:
							///					rank
							///		{
							///					1
							///	remained:		-k	1
							///		
							///		}
							/// 
							/// , the LW\  (note now it's colwise)becomes:
							/// 

							op_.basic_.skew_._ColwiseX._Skew_12col_3nilish(
								ref lower
								, rank
								, remained
								,
								scale
							);

							//op_._indent._GaussGramX._Skew_12row_3nilish(
							//	ref lower, remained, rank,
							//	scale
							//);

						}
						rank++;
						break;
					}
				}
			}
			return (permutation,lower);
		}

		static public (int[,] permute, Q[,] lower, Q[,] indent) Factorize( Q[,] m, out int rank)
		{
			 var cloned = (Q[,])  m.Clone();

			var t= Factorize(ref cloned, out rank);
			return (t.permute,t.lower,cloned);


		}

	}
}
