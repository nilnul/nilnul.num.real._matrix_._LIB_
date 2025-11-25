//using System.Data.Entity.Core.Metadata.Edm;
using System.Collections;

namespace nilnul.num.real.matrix_.sq.be_
{
	static public class _ShufflerX
	{
		static public bool _Be_0equilat(in int[,] equilat)
		{
			int h = equilat.GetLength(0);
			var occured = new BitArray(h);

			for (int i = 0; i < h; i++)
			{

				int j = 0;

				while (j < h)
				{
					if (equilat[i, j] ==0)
					{
						j++;
						continue;
					}
					break;
				}
				/// at unnil or out of the end
				/// 
				if (j < h)
				{
					if (equilat[i, j] ==1)
					{
						for (var k = j; ++k < h;)
						{
							if (equilat[i, k]!=0)
							{
								return false;
							}
						}

						if (occured[j])
						{
							return false;
						}
						occured[j] = true;
						/// 

					}
					else
					{
						return false;
					}
				}
				else
				{
					/// all nis;
					return false;
				}
			}
			///every bit is true;
			return true;
			///throw new UnexpectedReachException();
		}
	}
}
