using nilnul.num.real.stream_.slider._series_._nextAugend_;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.matrix_.fat.to_
{
	static public class _RemoveLastColumnX
	{
		//[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q[,]  _RemoveLastColumn_0fat(
			 Q[,] fat
		)
		{


			var wideMinus = fat.GetLength(1) -1;
		
			int high = fat.GetLength(0);


			var unaugmented = new Q[
				high, wideMinus	
			];

			for (int r = 0;r< high; r ++) {
				for (int c = 0; c<wideMinus; c++)
				{
					unaugmented[r, c] = fat[r, c];
				}
			 }

			return unaugmented;

		}

	}





}
