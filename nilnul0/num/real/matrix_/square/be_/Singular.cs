using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix_.square.be_
{
	public  class Singular
		:
		matrix_.square.Be4dblI
	{

		public bool be(Square4dbl obj)
		{
			return nilnul.num.real.be_.AboutNil4Dbl.Injected.be(
				square.to_.scalar_._DeterminantX._Determinant_assumeSquare(obj)
			);
		}


		static public Singular Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Singular>.Instance;
			}
		}

	}
}
