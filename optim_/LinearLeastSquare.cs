using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.optim_
{
	/// <summary>
	/// minimize  |Ax -b|
	/// ;
	/// </summary>
	/// <remarks>
	///  The most common use of pseudoinverse is to compute the best fit solution to a system of linear equations which lacks a unique solution.
	///  
	/// the vector A^+ b is the closest approximation to a solution in least squares sense;
	/// when the solvents are not unique, that is, when there is infinite solutions or there is no solutions.
	///  
	/// </remarks>
	/// 
	/// we can solve this by project Y onto the plane of X, and b, for Y=aX + b[1,...]
	/// 
	/// alias:
	///		regression
	///		<see cref="num.real.vec.fn_.linear.of_.ILeastSquare"/>
	class LinearLeastSquare
    {
    }
}
