using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		pinv
	static public class _PseudoInverseX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">
		/// the basis
		/// </param>
		/// <param name="b">
		/// the inverse.
		///
		/// unique: exists and is unique.
		/// </param>
		/// <returns></returns>
		static public bool Re(int[,] a, int[,] b)
		{

			if (
				a.GetLength(0) != b.GetLength(1)
				||
				a.GetLength(1) != b.GetLength(0)
			)
			{
				return false;
			}
			var ab = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(a, b);
			//var ba = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(b, a);


			return nilnul.num.real.matrix.Eq4int.Singleton.Equals(
					real.matrix.bi_._MultiX._Multiply_1sociable(ab, a)
					, a
				)
				&&
				nilnul.num.real.matrix.Eq4int.Singleton.Equals(
					real.matrix.bi_._MultiX._Multiply_1sociable(b, ab)
					, b
				)
				&&
				nilnul.num.real.matrix_.sq.be_._SymmetricX._Be_0square(
					ab
				)
				&&
				nilnul.num.real.matrix_.sq.be_._SymmetricX._Be_0square(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(b, a)
				)

			;

		}

		static public bool _Be_1flip(Q[,] a, Q[,] b)
		{

		
			var ab = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(a, b);
			//var ba = nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(b, a);

			/// A purely algebraic characterization of A^+ is given in the theorem proved by Penrose in 1956.
			return nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					real.matrix.bi_._MultiX._Multiply_1sociable(ab, a)
					,
					a
				)
				&&
				nilnul.num.real.matrix.Eq8quotient.Singleton.Equals(
					real.matrix.bi_._MultiX._Multiply_1sociable(b, ab)
					, b
				)
				&&
				nilnul.num.real.matrix_.sq.be_._SymmetricX._Be_0square(
					ab
				)
				&&
				nilnul.num.real.matrix_.sq.be_._SymmetricX._Be_0square(
					nilnul.num.real.matrix.bi_._MultiX._Multiply_1sociable(b, a)
				)

			;

		}

		static public bool Be(Q[,] a, Q[,] b)
		{

			if (
				a.GetLength(0) != b.GetLength(1)
				||
				a.GetLength(1) != b.GetLength(0)
			)
			{
				return false;
			}

			return _Be_1flip(a, b);


		}
	}
}
