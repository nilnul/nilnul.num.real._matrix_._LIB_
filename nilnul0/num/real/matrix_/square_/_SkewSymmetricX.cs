using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.square_
{
	/*
	  请教 一道高等代数题（反对称矩阵）
发信站: 水木社区 (Thu Nov  2 17:37:10 2017), 站内

设n阶反对称矩阵A的元素都是整数，证明|A|是一个完全平方数，即存在一个整数m使得|A|=m^2.
--

※ 来源:·水木社区 http://www.newsmth.net·[FROM: 110.82.43.*]



[本篇全文] [回复文章] [本篇作者：gtgtjing] [回信给作者] [进入讨论区] [返回顶部][分享到 腾讯微博]
2

发信人: gtgtjing (生在苦中不知苦), 信区: Mathematics
标  题: Re: 请教 一道高等代数题（反对称矩阵）
发信站: 水木社区 (Fri Nov  3 00:31:18 2017), 站内

特征值正负成对出现？
【 在 hyk84 的大作中提到: 】
: 设n阶反对称矩阵A的元素都是整数，证明|A|是一个完全平方数，即存在一个整数m使得|A|=m^2.
--

※ 来源:·水木社区 http://m.newsmth.net·[FROM: 61.148.244.*]



[本篇全文] [回复文章] [本篇作者：vinbo] [回信给作者] [进入讨论区] [返回顶部][分享到 腾讯微博]
3

发信人: vinbo (vinbo), 信区: Mathematics
标  题: Re: 请教 一道高等代数题（反对称矩阵）
发信站: 水木社区 (Fri Nov  3 11:00:58 2017), 站内

https://en.wikipedia.org/wiki/Skew-symmetric_matrix#Determinant

Let A be a n×n skew-symmetric matrix. The determinant of A satisfies

    det(A) = det(A^T) = det(-A) = (-1)^n*det(A).

In particular, if n is odd, and since the underlying field is not of characteristic 2, the determinant vanishes. Hence, all odd dimension skew symmetric matrices are singular as their determinants are always zero. This result is called Jacobi's theorem, after Carl Gustav Jacobi (Eves, 1980).

The even-dimensional case is more interesting. It turns out that the determinant of A for n even can be written as the square of a polynomial in the entries of A, which was first proved by Cayley:[2]

    det(A) = Pf(A)^2

This polynomial is called the Pfaffian of A and is denoted Pf(A). Thus the determinant of a real skew-symmetric matrix is always non-negative. However this last fact can be proved in an elementary way as follows: the eigenvalues of a real skew-symmetric matrix are purely imaginary (see below) and to every eigenvalue there corresponds the conjugate eigenvalue with the same multiplicity; therefore, as the determinant is the product of the eigenvalues, each one repeated according to its multiplicity, it follows at once that the determinant, if it is not 0, is a positive real number.



[2] Cayley, Arthur (1847). "Sur les determinants gauches" [On skew determinants]. Crelle's Journal. 38: 93–96. Reprinted in Cayley, A. (2009). "Sur les Déterminants Gauches". The Collected Mathematical Papers. 1. p. 410. ISBN 978-0-511-70367-6. doi:10.1017/CBO9780511703676.070.
【 在 hyk84 的大作中提到: 】
: 设n阶反对称矩阵A的元素都是整数，证明|A|是一个完全平方数，即存在一个整数m使得|A|=m^2.

--
※ 修改:·vinbo 于 Nov  3 11:18:20 2017 修改本文·[FROM: 222.44.86.*]

		Deformation (形变), 信区: Mathematics
标  题: Re: 请教 一道高等代数题（反对称矩阵）
发信站: 水木社区 (Sat Nov  4 08:19:32 2017), 站内

你们为啥不把wiki的参考文献看全了呢。。。

下面这篇不就是个简单的归纳证法吗？
Parameswaran, S. (1954). "Skew-Symmetric Determinants". The American Mathematical Monthly. 61 (2): 116. JSTOR 2307800. doi:10.2307/2307800.

		 */
	class _SkewSymmetricX
	{
	}
}
