﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.matrix.str
{
	//extern alias obj;
	public interface BeI
		:
		//obj::
		nilnul.obj.BeI1<
			IEnumerable<
			double[,]
			>>
		,
		nilnul.BeI<IEnumerable<double[,]>>
	{
	}
}
