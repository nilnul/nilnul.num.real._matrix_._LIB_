namespace nilnul.num.real.matrix.rows.be_
{
	static public class _OrthonormalX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <returns></returns>
	

		static public bool Be(in Q4[,] m) {
			int height = m.GetLength(0);
			for (int i = 0; i < height; i++)
			{
				if (!nilnul.num.real.matrix.row.be_._UnialX._IsUnial_1row(in m, in i))
				{
					return false;
				}
				/// orthogonal to previous
				/// 
				for (int j = 0; j < i; j++) {


					if (!num.real.matrix.row.re_._OrthicX._IsOrthic_0row_1other(in m, in i,in j))
					{
						return false;
					}
				}
			}
			return true;
		}
	}





}
