using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.matrix.duo_.associable;

namespace nilnul.num.ieee.matrix.str_.startedProductable
{
	public class Product
		: nilnul.matrix.str_.startedProductable.Aggregate<double>


	{
		public Product() : base(
			new InnerProduct<double>(
				(x,y)=>x*y
				,
				ieee.str.SumX.Sum	
			)
			
			)
		{

		}


		static public readonly Product Singleton = SingletonByDefault<Product>.Instance;



	}
}
