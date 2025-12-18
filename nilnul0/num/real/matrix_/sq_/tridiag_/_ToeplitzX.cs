namespace nilnul.num.real.matrix_.sq_.tridiag_
{
	/// <see cref="obj.matrix_.sq_.tri"/>
	/// <see cref="real.matrix_.sq_.ITriDiagonal"/>
	/// <summary>
	/// 
	/// </summary>
	static public class _ToeplitzX
	{
		static public Q4[,] Generate(int wide, Q4 c00, Q4 c01, Q4 c10)
		{
			switch (wide)
			{
				case 0:
					return new quotient_.DenomNonnil[0, 0];
				case 1:
					return new quotient_.DenomNonnil[,] { { c00 } };
				//case 2:

				//default:
				//	break;
			}
			var o = new Q4[wide, wide];

			var wideMinus = wide-1;

			{
				int j = 0;
				o[0, j++] = c00;
				o[0, j++] = c01;

				for (; j < wide; j++)
				{
					o[0, j] = 0;
				}


			}


			for (var i = 1; i < wideMinus; i++)
			{
				int j = 0;
				for (; j < i-1; j++)
				{
					o[i, j] = 0;
				}

				o[i, j++] = c10;
				o[i, j++] = c00;

				o[i, j++] = c01;

				for (; j < wide; j++)
				{
					o[i, j] = 0;
				}
			}
			{
				int j = 0;
				var wideMinusTwo = wideMinus-1;

				for (; j < wideMinusTwo; j++)
				{
					o[wideMinus, j] = 0;
				}

				o[wideMinus, j++] = c10;
				o[wideMinus, j++] = c00;



			}

			return o;
		}
	}
}
