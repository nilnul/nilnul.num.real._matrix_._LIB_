using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.be_
{
	///	<inheritdoc cref="IAntimetric"/>
	/// 
	/// if A^T = -A, then A is neg-symmetric.
	/// <summary>
	/// A = - transpose of A. that means the diagonal are all 0s;
	/// </summary>
	/// alias:
	///		antisymmetric
	///		
	///		antimetric
	///		antometric
	///		
	public class SkewSymmetric
		:
		_be_.OfArray4dblA
		,
		nilnul.num.real.matrix_.sq.Be4dblI1
		,
		_be_._ofArr_._AssumeSquareI
	{

		public override bool _be_0square(in double[,] square)
		{
			var width = square.GetLength(0);
			for (int i = 0; i < width; i++)
			{
				if (
					square[i, i] != 0
				)
				{
					return false;
				}

				for (int j = i+1; j < width; j++)
				{
					if (
						nilnul.num.real.re_.approx_.ByInjected.Singleton.re(
							square[i,j] , -square[j,i]
						)
					)
					{
						continue;
					}
					return false;
					
				}

			}

			return true;

		}


		static public SkewSymmetric Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<SkewSymmetric>.Unison;
			}
		}

	}
}
