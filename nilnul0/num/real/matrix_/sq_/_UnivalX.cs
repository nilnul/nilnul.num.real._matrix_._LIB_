namespace nilnul.num.real.matrix_.sq_
{
	/// <summary>
	/// <see cref="num.real.matrix_.IUnival"/>
	/// </summary>
	static public class _UnivalX
	{

		/// <summary>
		/// <see cref="matrix_.unival_._OmniOneX"/>
		/// </summary>
		/// <param name="wide"></param>
		/// <returns></returns>
		static public Q[,] Generate(int wide, Q val) {
			var o = new Q[wide, wide];
			for (int i = 0; i < wide; i++) {
				for (int j = 0; j < wide; j++)
				{
					o[i, j] = val;
				}
			}
			return o;
		}
	}


}
