using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.diag_
{
	/// <summary>
	/// <see cref="nilnul.num.real.matrix_.ILandscape"/>
	/// </summary>
	static public  class _LandscapeX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] _ToLandscape_1pad(
			IEnumerable<Q> diagonal
			,
			int colsPad
		)
		{
			return nilnul.obj.matrix_.diag_._LandscapeX._ToLandscape_1pad(diagonal, colsPad, 0);
			var h = diagonal.Count();

			int w = h+ colsPad;

			var o = new Q[h, w];

			for (var i = 0; i < h; i++)
			{
				var j = 0;
				while (j<i)
				{
					o[i, j++] =0;

				}

				/// here j might be greater than cols. but as this is landscape, 
				o[i, j++] = diagonal.ElementAt(i);

				while (j<w)
				{

					o[i, j++] = 0;
				}


			}

			return o;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _ToLandscape_1pad(
			IEnumerable<double> diagonal
			,
			int colsPad
		)
		{
			return nilnul.obj.matrix_.diag_._LandscapeX._ToLandscape_1pad(diagonal, colsPad, 0);

			var h = diagonal.Count();

			int w = h+ colsPad;

			var o = new double[h, w];

			for (var i = 0; i < h; i++)
			{
				var j = 0;
				while (j<i)
				{
					o[i, j++] =0;

				}

				/// here j might be greater than cols. but as this is landscape, 
				o[i, j++] = diagonal.ElementAt(i);

				while (j<w)
				{

					o[i, j++] = 0;
				}


			}

			return o;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,] OfRowsCols(
			int rows
			,
			int cols
			,
			IEnumerable<Q> diagonal
		)
		{
			var c = diagonal.Count();
			if (c==rows)
			{
				return _ToLandscape_1pad(
					diagonal
					,
					cols-rows
				);


			}
			return _ToLandscape_1pad(
				diagonal.Concat( Enumerable.Repeat( Q.Nil, rows-c) )
				,
				cols-rows
			);

			var r = new Q[rows, cols];

			for (var i = 0; i < rows; i++)
			{
				var j = 0;
				while (j<i)
				{
					r[i, j++] =0;

				}

				/// here j might be greater than cols. but as this is landscape, 
				r[i, j++] = diagonal.ElementAt(i);

				while (j<cols)
				{

					r[i, j++] = 0;
				}


			}

			return r;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfRowsCols(
			int rows
			,
			int cols
			,
			IEnumerable<double> diagonal
		)
		{

			var c = diagonal.Count();
			if (c==rows)
			{
				return _ToLandscape_1pad(
					diagonal
					,
					cols-rows
				);


			}
			return _ToLandscape_1pad(
				diagonal.Concat(Enumerable.Repeat(0d, rows-c))
				,
				cols-rows
			);


			return _ToLandscape_1pad(
				diagonal.Concat( Enumerable.Repeat(0d, rows) )
				,
				cols-rows
			);

			var r = new double[rows, cols];

			for (var i = 0; i < rows; i++)
			{
				var j = 0;
				while (j<i)
				{
					r[i, j++] =0;
				}

				/// here j might be greater than cols. but as this is landscape, 
				r[i, j++] = diagonal.ElementAt(i);

				while (j<cols)
				{

					r[i, j++] = 0;
				}


			}

			return r;
		}

	}
}
