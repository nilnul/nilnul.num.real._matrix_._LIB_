namespace nilnul.num.real.matrix_.dent.to_
{
	/// <summary>
	/// eg:
	///		[
	///			0,	2,	0	,3,	7
	///			0,	0,	0	,5,	0
	///			0,	0,	0,	0,	0
	///		]
	///	=  for any column that doesnot have the paragon, we add one in the later rows >
	///		[
	///			0,	2,	0	,3,	7
	///			0,	0,	0	,5,	0
	///			1,	0,	0,	0,	0
	///			0,	0,	1,	0,	0
	///			0,	0,	0,	0,	1
	///			
	///		]
	///	;
	/// eg:
	///		[
	///			0,	2,	0	,3,	7
	///			0,	0,	0	,5,	0
	///			0,	0,	0,	0,	0
	///			0,	0,	0,	0,	0
	///			0,	0,	0,	0,	0
	///			0,	0,	0,	0,	0
	///			0,	0,	0,	0,	0
	///			0,	0,	0,	0,	0
	///			
	///		]
	///	=>
	///		[
	///			0,	2,	0	,3,	7
	///			0,	0,	0	,5,	0
	///			1,	0,	0,	0,	0
	///			0,	0,	1,	0,	0
	///			0,	0,	0,	0,	1
	///			
	///		]
	///	
	///		
	/// </summary>
	/// 
	static public class _InvertibleX
	{
		static public Q4[,] _ToInvertible_0dent(Q4[,] dent)
		{

			var width = dent.GetLength(1);

			var o = new Q4[width, width];

			var rank = num.real.matrix_.dent._RankX._Rank_0dent(dent);

			for (var i = 0; i < rank; i++)
			{
				for (var j = 0; j < width; j++)
				{
					o[i, j] = dent[i, j];
				}
			}

			#region latter rows
			/// colwise:


			var unbasisDiag = 0; /// used for the '1' cel index.

			int p = -1;	/// the next pivot

			for (int p00 = 0; p00 < rank; p00++)
			{
				p = nilnul.num.real.matrix.row._PivotX.Pivot(
					in dent, p00
				);

				for (int c = 0; c < p; c++)
				{
					int r = rank;

					for (; r < rank + unbasisDiag; r++)
					{
						o[r, c] = 0;
					}
					o[r++, c]=1;

					for (; r < width; r++)
					{
						o[r, c] = 0;
					}

					unbasisDiag++;
				}

				/// for pivot col:
				for (int r = rank; r < width; r++)
				{
					o[r, p] =0;
				}
			}

			#region the columns after last pivot
			for (var c = p+1; c < width; c++)
			{
				int r = rank;
				for (; r < rank + unbasisDiag; r++)
				{
					o[r, c] = 0;
				}
				o[r++, c]=1;

				for (; r < width; r++)
				{
					o[r, c] = 0;
				}

				unbasisDiag++;

			}

			#endregion

			#endregion
			return o;



		}
	}


}
