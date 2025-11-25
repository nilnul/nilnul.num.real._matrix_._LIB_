namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// </summary>
	static public class _ShufflerX
	{

		/// <summary>
		/// </summary>
		/// <param name="shuffler">
		/// a full permutation of 0,1,2,3.
		/// eg:
		///		[0,3,2,1]
		/// </param>
		/// <returns></returns>
		static public Q[,] _Generate_0shuffle(params int[] shuffler)
		{
			int w = shuffler.Length;

			var o = new Q[w, w];

			for (int i = 0; i < w; i++)
			{
				int j = 0;

				int pick = shuffler[i];

				for (; j<pick; j++)
				{
					o[i, j] = 0;
				}
				o[i, j++] = 1;

				for (; j<w; j++)
				{
					o[i, j] = 0;
				}

			}

			return o;

		}
	}


}
