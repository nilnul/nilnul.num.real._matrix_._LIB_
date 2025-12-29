using System;
using System.Collections.Generic;
//using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq.be_
{
	/// <summary>
	/// either <see cref="_orthonorm.ColsOrthonorm"/> or <see cref="_orthonorm.RowsOrthonorm"/>
	/// ;
	/// as the two implis each other, hence this means both <see cref="_orthonorm.RowsOrthonorm"/> and <see cref="_orthonorm.ColsOrthonorm"/>
	/// </summary>
	public interface IOrthoNormal { }


	public class Orthonormal8dbl
	{

		private real.matrix.re_.Approx4dbl1 _approx;

		public real.matrix.re_.Approx4dbl1 approx
		{
			get { return _approx; }
			set { _approx = value; }
		}

		public Orthonormal8dbl(real.matrix.re_.Approx4dbl1 approx)
		{
			_approx = approx;
		}

		public Orthonormal8dbl(num.real.re_.Approx4dblI approx )
			:this(new real.matrix.re_.Approx4dbl1(approx))
		{
				
		}

		public bool _be_0square(double[,] matrix ) {
			return approx.re(
					real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
						matrix
						,
						real.matrix.op_.unary_.Transpose.Op(matrix)
					)
					,
					real.matrix_.sq_._CanonicalX.Generate(matrix.GetLength(0))
			);
		}


	}
}
