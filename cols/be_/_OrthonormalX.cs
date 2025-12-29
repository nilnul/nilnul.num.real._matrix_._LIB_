namespace nilnul.num.real.matrix.cols.be_
{
	static public class _OrthonormalX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
	

		static public bool Be(in Q4[,] m) {
			int width = m.GetLength(1);
			for (int i = 0; i < width; i++)
			{
				if (!nilnul.num.real.matrix.col.be_._UnialX._IsUnial_1col(in m, in i))
				{
					return false;
				}
				/// orthogonal to previous
				/// 
				for (int j = 0; j < i; j++) {


					if (!num.real.matrix.col.re_._OrthicX._IsOrthic_0col_1other(in m, in i,in j))
					{
						return false;
					}
				}
			}
			return true;
		}
	}





}
