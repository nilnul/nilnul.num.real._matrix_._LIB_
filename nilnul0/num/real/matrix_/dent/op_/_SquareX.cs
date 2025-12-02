namespace nilnul.num.real.matrix_.dent.op_
{
	/// <summary>
	/// to square by padding or trimming.
	/// the unnil rows are unchanged;
	/// </summary>
	static public class _SquareX
	{

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

		static public Q4[,] _ToSquare_0dent(Q4[,] dent) {
			var width = dent.GetLength(1);

			var o = new Q4[width, width];

			var rank = num.real.matrix_.dent._RankX._Rank_0dent(dent);

			for (var i = 0; i < rank; i++) {
				for (var j = 0; j < width; j++)
				{
					o[i, j] = dent[i, j];
				}
			}

			#region latter rows

			for (int i = rank; i < width; i++)
			{
				for (var j = 0; j < width; j++)
				{
					o[i, j] = 0;
				}

			}

			#endregion
			return o;



		}
	}


}
