using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R3 = nilnul.num.Real;
using R2 = nilnul.num.Real;
using RI = nilnul.num.RealI;



namespace nilnul.num.real.matrix.be
{
	//extern alias num;
	public class En1<TBe>
		:nilnul.be.Asserted<RI[,] , TBe>
		where TBe:BeI1, new()
	{
		public En1(R3[,] v):base(v)
		{

		}

		public En1(RI[,] v):this(
			nilnul.slew_.matrix.op_._CastX.Cast<RI,R3>(v, x=>new R3(x))
			)
		{

		}

		public    En1(params R3[] args):base(
			nilnul.matrix_.square.fro_._StrX.Eval<R3>(args).avowed	
		)
		{

		}

	public    En1(IEnumerable< R3> args):base(
			nilnul.matrix_.square.fro_._StrX.Eval<R3>(args).avowed	
		)
		{

		}		public override string ToString()
		{
			return nilnul.slew_.matrix.to_.Txt.Eval(val);
		}

		public nilnul.obj.matrix._dim.Ret dimension {
			get {
				return nilnul.obj.matrix._DimX.Dimension(val);
				//return nilnul.matrix.to_._DimensionX.Dimension(val);

			}
		}

	}
}
