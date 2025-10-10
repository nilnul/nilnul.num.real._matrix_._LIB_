namespace nilnul.num.real.matrix_.unival_
{
	static public class _OmniOneX
	{
		static public Q[,] Generate_0rows_1cols(int x,int y) {
			var r = new Q[x, y];

			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++)
				{
					r[i, j] =1;
				}
			}
			return r;
		}
	}

}
