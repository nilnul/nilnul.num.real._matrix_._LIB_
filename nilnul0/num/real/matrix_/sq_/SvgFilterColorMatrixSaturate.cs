using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.matrix.eg
{
	static public partial class SvgFilterColorMatrixSaturate
	{
		static public  double[,] FullMatrix = new double[,] {
			{   0.213 , 0.715  ,0.072, 0 , 0 },
			{ 0.213,0.715,0.072,0,  0 },
			{ 0.213,0.715,0.072,0,  0 },
			{0     ,       0     ,        0 , 1 , 0 },
			{0    ,        0    ,         0,  0 , 1}
		};

		static public double[,] CreateMatrix(double s) {
			return new double[,] {
			{   0.213 +0.787*s, 0.715 -.715*s ,0.072 -.072*s, 0 , 0 },
			{ 0.213-.213*s  ,0.715+.285*s,0.072-.072*s,0,  0 },
			{ 0.213-.213*s,0.715-.715*s,0.072+.928*s,0,  0 },
			{0     ,       0     ,        0 , 1 , 0 },
			{0    ,        0    ,         0,  0 , 1}
		};

		}
	}
}
