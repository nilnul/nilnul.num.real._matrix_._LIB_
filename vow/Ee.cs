using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.matrix.vow
{
	public class Ee
		: nilnul.obj.vow.Ee1<R[,]>
	{
		public Ee(R[,] val, VowI2<R[,]> vow) : base(val, vow)
		{
		}
	}
}
