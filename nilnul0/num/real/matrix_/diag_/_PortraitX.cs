using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.diag_
{
	/// <summary>
	/// <see cref="real.matrix_.IPortrait"/>
	/// </summary>
	static public  class _PortraitX
	{


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _ToPortrait_1pad(
			
			IEnumerable<double> diagonal
			,
			int rowsPad
		)
		{

			return nilnul.obj.matrix_.diag_._PortraitX._ToPortrait_1pad(diagonal,rowsPad,0);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _ToPortrait_1pad(
			
			IEnumerable<Q> diagonal
			,
			int rowsPad
		)
		{ 
			return nilnul.obj.matrix_.diag_._PortraitX._ToPortrait_1pad(diagonal,rowsPad,0);

		}


		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
			,
			IEnumerable<Q> diagonal
		)
		{ 	
			var c = diagonal.Count();
			if (c==cols)
			{
				return _ToPortrait_1pad(
					diagonal
					,
					rows-cols
				);


			}

			return _ToPortrait_1pad(
				diagonal.Concat( Enumerable.Repeat( Q.Nil, cols-c) )
				,
				rows-cols
			);

			var r = new Q[rows, cols];

			for ( var col = 0; col < cols; col++ ) {

				var row = 0;

				while (row<col)
				{
					r[row++,col] =0;
				}
	
				/// here col might be greater than rows-1, . but as this is portrait, 
				r[row++, col] = diagonal.ElementAt(col);

				while (row<rows)
				{
					r[row++, col] = 0;
				}
			}
			return r;
		}

		static public double[,] OfRowsCols(
			int rows
			,
			int cols
			,
			IEnumerable<double> diagonal
		)
		{
			var c = diagonal.Count();
			if (c==cols)
			{
				return _ToPortrait_1pad(
					diagonal
					,
					rows-cols
				);
			}

			return _ToPortrait_1pad(
				diagonal.Concat(Enumerable.Repeat(0d, cols-c))
				,
				rows-cols
			);



			var r = new double[rows, cols];

			for ( var col = 0; col < cols; col++ ) {

				var row = 0;

				while (row<col)
				{
					r[row++,col] =0;
				}
	
				/// here col might be greater than rows-1, . but as this is portrait, 
				r[row++, col] = diagonal.ElementAt(col);

				while (row<rows)
				{
					r[row++, col] = 0;
				}
			}
			return r;
		}

	}
}
