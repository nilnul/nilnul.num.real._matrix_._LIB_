using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.op_.unary_
{
	public  class Inverse
		:
		square.op_.Unary4dblI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns>
		/// empty if empty.
		/// </returns>
		/// <exception cref="">
		/// exception if determinant is nil
		/// </exception>
		public static double[,] _Matrix_assumeSquare( double[,] matrix)
		{


			//if (determ == 0)
			//{
			//	throw new Exception("The determinant of the matrix is 0 so it's not inversible.");
			//}

		

			return num.real.matrix.op_.unary_._ScaleX.Divide2new (
				Adjugate.Matrix(matrix)
				,
				
				square.to_.scalar_._DeterminantX._Determinant_assumeSquare(matrix)

			);

			




		}

		public Square4dbl op(Square4dbl par)
		{
			return new Square4dbl( _Matrix_assumeSquare(par) );
			//throw new NotImplementedException();
		}


		static public Inverse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Inverse>.Instance;
			}
		}

	}
}
