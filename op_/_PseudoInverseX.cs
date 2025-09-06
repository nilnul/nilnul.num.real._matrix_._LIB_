using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.op_
{
	/// often defined on complex matrix;
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		generalized inverse, pseudoinverse, or Moore-Penrose inverse.
	///		pinv
	///		
	public interface IPseudoInverse { }
	/// <summary>
	/// Moore–Penrose inverse A+ of a matrix A, often called the pseudoinverse, is the most widely known generalization of the inverse matrix
	/// </summary>
	/// <remarks>
	/// The Moore-Penrose pseudoinverse is defined for any	matrix and is unique.
	/// </remarks>
	/// <see cref="to_.decom_.ISingularValueDecomposition"/>
	static public class _PseudoInverseX
    {
		static public double PseudoInverse(double x) {
			return x == 0 ? 0 : 1 / x;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// regarded as matrix.
		/// </param>
		/// <returns>
		/// a row if <paramref name="x"/> is a col
		/// ,a col if <paramref name="x"/> is a row
		/// </returns>
		static IEnumerable<double> PseudoInverse(IEnumerable<double> x)
		{
			var variance = nilnul.num.real.str._VarianceX.Variance(x);
			if (variance == 0)
			{
				return x.Select(_ => 0d);
			}

			return x.Select(c=> c/variance)			;
		}


	}
}
