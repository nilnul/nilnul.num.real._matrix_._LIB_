namespace nilnul.num.real.matrix_.sq_.diag_
{
	/// <summary>
	/// the number on the diag are all the same.
	/// </summary>
	/// alias:
	///		ubiquitous
	///		
	static public class _UniformX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="size"></param>
		/// <param name="x">
		/// eg:
		///		the x in
		///		x,	0,	0
		///		0,	x,	0
		///		0,	0,	x
		///
		/// </param>
		/// <returns></returns>
		static public double[,] Generate_0width(int size, double x) {
			var r = new double[size, size];
			for (int i = 0; i < size; i++)
			{
				r[i, i] = x;
			}
			return r;
		}

		static public Q[,] Generate_0width(int size, Q x) {

			var r = new Q[size, size];
			for (int i = 0; i < size; i++)
			{
				int j = 0;
				for (; j < i; j++)
				{
					r[i, j] = 0;

				}
				r[i, j++] = x;

				for (; j < size; j++)
				{
					r[i, j] = 0;
				}
			}
			return r;
		}


	}


}
