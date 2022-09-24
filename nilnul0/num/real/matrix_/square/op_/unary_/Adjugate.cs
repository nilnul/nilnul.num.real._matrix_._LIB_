using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		 伴随矩阵
	///		 adjoin
	///			was used historically, but now is reserved for other use
	public  class Adjugate
		:
		op_.Unary4dblI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>empty if empty</returns>
		static public double[,] Matrix(double[,] matrix) {

			return Transpose._Op(CofactorMatrix.Matrix4dbl(matrix));
		
		}

		public Square4dbl op(Square4dbl par)
		{
			return new Square4dbl(
				Matrix(par)
			);
			//throw new NotImplementedException();
		}


		static public Adjugate Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Adjugate>.Instance;
			}
		}

	}
}
