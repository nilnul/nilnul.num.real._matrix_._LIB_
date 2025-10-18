using nilnul.num.real.matrix.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_
{
	internal class _CenteringX
	{
		/// <summary>
		/// [0]
		/// ;
		///		[
		///			1/2,-1/2
		///			-1/2, 1/2
		///		]
		/// </summary>
		/// <param name="wide"></param>
		/// <returns></returns>
		static public Q[,] _Generate_0positive(int wide)
		{
			var c = nilnul.num.real.matrix_.sq_._CanonicalX.Generate8quotient(wide);


			Q[,] denomNonnils = num.real.matrix_.sq_.unival_._OmniOneX.Generate_0wide(wide);
			denomNonnils.Shred(
				//nilnul.num.quotient_._InvertX.Invert
				(wide));

			real.matrix.bi_._SubtractX._Deduce_1equisize(
				c
				,

				denomNonnils
			);

			return c;

		}
	}
}
