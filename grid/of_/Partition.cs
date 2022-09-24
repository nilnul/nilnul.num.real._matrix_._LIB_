using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix.grid.of_
{
	static public class _PartitionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="_majorPartition_assumePositivesSumValid"> group rows</param>
		/// <param name="_minorPartition_assumePositivesSumValid">
		/// group cols
		/// </param>
		/// <returns></returns>
		static public double[,][,] _Partition_assumeValid(
			double[,] matrix
			,
			int[] _majorPartition_assumePositivesSumValid
			,
			int[] _minorPartition_assumePositivesSumValid
		)
		{
			var mosaic = new double[
				_majorPartition_assumePositivesSumValid.Length, _minorPartition_assumePositivesSumValid.Length
			][,];

			for (
				int i = 0,rowIndexBase = 0;
				i < _majorPartition_assumePositivesSumValid.Length;
				rowIndexBase += _majorPartition_assumePositivesSumValid[i], i++
			)
			{
				for (
					int j = 0,colIndexBase = 0;
					j < _minorPartition_assumePositivesSumValid.Length;
					colIndexBase += _minorPartition_assumePositivesSumValid[j],j++
				)
				{
					var block = new double[_majorPartition_assumePositivesSumValid[i], _minorPartition_assumePositivesSumValid[j]];
					for (
						int m = 0,rowIndex = rowIndexBase;
						m < _majorPartition_assumePositivesSumValid[i];
						m++, rowIndex++
					)
					{
						for (
							int n = 0,colIndex = colIndexBase;
							n < _minorPartition_assumePositivesSumValid[j];
							n++, colIndex++
						)
						{
							block[m, n] = matrix[rowIndex, colIndex];
						}
					}
					mosaic[i, j] = block;
				}
			}
			return mosaic;
		}
	}
}
