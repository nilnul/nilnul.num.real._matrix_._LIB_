using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
//using Matrix1 = nilnul.num.matrix._1.Matrix;

namespace nilnul.num.real.matrix.op_.rowwise_
{
	/// <see cref="matrix.op_.IIndent"/>
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		echelon:<see cref="matrix.be_.IIndent"/>, <see cref="matrix_.indent_.indep_."/>
	///		gaussian
	public  class Gaussian4quotient
	{
		private Q[,] _matrix;

		private int _wide;
		private int _high;

		public Gaussian4quotient(Q[,] matrix) {
			this._matrix = matrix;
			this._high = matrix.GetLength(0); 
			this._wide = matrix.GetLength(1); 

		}
	



	


	}
}
