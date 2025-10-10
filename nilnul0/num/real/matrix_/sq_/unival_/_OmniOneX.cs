namespace nilnul.num.real.matrix_.sq_.unival_
{
	static public class _OmniOneX
	{
		static public Q[,] Generate_0wide(int x) {
			var r = new Q[x, x];

			for (int i = 0; i < x; i++) {
				for (int j = 0; j < x; j++)
				{
					r[i, j] =1;
				}
			}
			return r;
		}
	}

}
