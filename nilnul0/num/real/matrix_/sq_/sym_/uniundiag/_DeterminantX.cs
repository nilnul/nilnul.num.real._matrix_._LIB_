using nilnul.txt.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.sym_.uniundiag
{

	///<summary>
	///
	/// eg:
	///		<see cref="num.real.matrix_.sq_.IUnival"/> + <see cref="real.matrix_.sq_.IDiagonal"/>
	///		
	/// </summary>
	/// <see cref="sq.calc_.binary_.dif_.IIsorowScaler"/>
	/// <see cref="sq.calc_.binary_.dif_.isorow9scaler._DeterminantX"/>
	/// <see cref="sq.calc_.binary_.add_.isorow9scaler._DeterminantX"/>
	static public class _DeterminantX
	{
		static public Q _Determinant_0wide_1ridge_2undiagVal( Q[] ridge, Q other)
		{

			/// thus the matrix is:
			///		<see cref="real.matrix_.IUnival"/>(other)
			///		,
			///		<see cref="real.matrix_.sq_._DiagonalX.OfDiagonal(IEnumerable{quotient_.DenomNonnil})"/> (ridge)
			///		

			var wide = ridge.Length;
			if (wide==0)
			{
				return 1;
			}


			/// subtract first row from each of the other rows, we get a matrix: <see cref="matrix_.sq_.IPaw"/>,<see cref="sq_.paw_.nilsome8torso5diag._DeterminantX"/>
			/// 
			/// 
			var paw = new Q[wide, wide];
			var ridge0 = ridge[0];
			paw[0, 0] = ridge0;

			for (int c = 1; c < wide; c++)
			{
				paw[0, c] = other;
			}
			for (int r = 1; r < wide; r++)
			{
				paw[r, 0] = other -ridge0;
			}

			for (int i = 1; i < wide; i++)
			{
				int j = 1;
				for (; j < i; j++)
				{
					paw[i, j] = 0;
				}
				paw[i, j++] = ridge[i];
				for (; j < wide; j++)
				{
					paw[i, j] = 0;
				}
			}

			return sq_.paw._DeterminantX._Determinant_0paw(
				paw
			);
		}
	}
}
