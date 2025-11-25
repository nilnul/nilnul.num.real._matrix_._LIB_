using nilnul.num.real.matrix_.sq.op_.unary_;
using nilnul.num.real.matrix_.sq_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_.invertible.op_
{

	public class Invert
		:
		invertible.Op8dblI
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public  double[,] _Matrix_0invertible(double[,] nonsinglularSqMatrix) {
			return matrix_.sq.op_.unary_.Inverse._Matrix_assumeSquare(
				nonsinglularSqMatrix
			);

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Invertible4dbl op(in Invertible4dbl par)
		{
			return new Invertible4dbl(
				_Matrix_0invertible(par.ee) 
			);
			//throw new NotImplementedException();
		}

	
		static public Invert Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Invert>.Instance;
			}
		}

	}
}
