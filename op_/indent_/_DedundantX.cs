namespace nilnul.num.real.matrix.op_.indent_
{
	static public class _DedundantX
	{
		static public Q[,] _Dedundant_0indent_1rank(Q[,] canon, int rank) {

			int cols = canon.GetLength(1);

			var r = new Q[rank, cols];

			for (int i = 0; i < rank; i++) {
				for (int j = 0; j < cols; j++)
				{
					r[i,j] = canon[i,j];
				}
			}

			return r;
		}
		static public Q[,] _Dedundant_0indent_1rank(Q[,] canon, long rank) {

			int cols = canon.GetLength(1);

			var r = new Q[rank, cols];

			for (int i = 0; i < rank; i++) {
				for (int j = 0; j < cols; j++)
				{
					r[i,j] = canon[i,j];
				}
			}

			return r;
		}


	}


}
