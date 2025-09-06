using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.txten_
{
	/// <summary>
	/// like markdown. eg:
	///		{1,2; 3,4}
	/// </summary>
    static public class _BySemicolonX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public string Txten(double[,] matrix) {
			return $$"""{{{
				string.Join(
					";"
					,
					obj.matrix._RowsX.Rows(matrix).Select(
						r=> nilnul.objs._PhraseX._Phrase(
							r
						)
					)
				)
			}}}""";

			//for (int i = 0; i < matrix.GetLength(0); i++)
			//{
			//	var colsInRow = new StringBuilder();// "";
			//	for (int col = 0; col < matrix.GetLength(1); col++)
			//	{
			//		colsInRow.Append(col);
			//		colsInRow.Append(",");
			//	}
			//	colsInRow.RemoveLast();

			//}
		}
    }
}
