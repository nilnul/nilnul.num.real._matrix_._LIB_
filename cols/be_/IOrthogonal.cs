namespace nilnul.num.real.matrix.cols.be_
{
	/// <summary>
	/// <see cref="num.real.vecs.be_."/>
	/// <see cref="num.real.vec.str.be_"/>
	/// </summary>
	public interface IOrthogonal
	{
	}

	static public class _OrthogonalX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <param name="row"></param>
		/// <returns></returns>
	

		static public bool Be(in Q4[,] m) {
			int width = m.GetLength(1);
			for (int i = 0; i < width; i++)
			{
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
