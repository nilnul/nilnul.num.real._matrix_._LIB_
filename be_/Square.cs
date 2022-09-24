using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using R = nilnul.num.Real;



namespace nilnul.num.real.matrix.be_
{
	public partial class Square1 : BeI1
		,
		nilnul.num.real.matrix.BeI2
		,
		real.matrix.Be4dblI

	{

		public bool be(RI[,] obj) {
			return nilnul.matrix.be_._SquareX.Square(obj);
		}
		 

		public bool be(R[,] obj) {
			return nilnul.matrix.be_._SquareX.Square(obj);
		}

		public bool be(double[,] obj) {
			return nilnul.matrix.be_._SquareX.Square(obj);

		}

		static public Square1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Square1>.Instance;
			}
		}



		 


	}
}
