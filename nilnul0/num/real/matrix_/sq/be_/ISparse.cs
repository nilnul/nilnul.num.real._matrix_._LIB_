//using System.Data.Entity.Core.Metadata.Edm;
namespace nilnul.num.real.matrix_.sq.be_
{
	/// vast 0s;
	/// 
	/// 
	///	degenerate	:
	/// when the count of nonnil cels is less than n
	/// ,where n is the width of the square matrix.
	/// 
	/// in other words, count of 0s is gt n*(n-1)
	/// this means, at least one row is all 0s. 
	/// otherwise, each row can have one unnil.
	/// 
	///		:gt  n*(n-1)
	/// 
	///			[
	///				1,0
	///				0,0
	///			]
	/// 一个n阶行列式若其非零元素的个数小于n,则行列式的值必为0. This shall be regarded sparse.
	///		density lt n; sparsity gt n(n-1)
	/// ;;;;;;;;;;;;;;;
	/// 
	/// 
	/// 
	///	
	/// diag:
	/// a diagonal matrix shall be regarded as sparse.  <see cref="matrix.cels_.unnil.count.IProportion"/> le <var>n</var>, or <see cref="matrix.ISparsity"/> ge n(n-1) 
	/// ; it can be stored as a vec. 
	/// 
	/// 
	///		:ge  n*(n-1)
	/// 
	///			[
	///				1,0
	///				0,2
	///			]
	///			[
	///				1,2
	///				0,0
	///			]
	/// 
	/// a triag may be regarded as sparse. density ge n(n+1)/2; sparsity lt n(n-1)/2
	/// 
	/// 
	///			
	///		:ge  n*(n-1) /2
	///			[
	///				1,2,3,4
	///				0,6,7,8
	///				0,0,1,2
	///				0,0,0,6
	///			]
	///		
	///			[
	///				1,2,3,4,5
	///				0,6,7,8,9
	///				0,0,1,2,3
	///				0,0,0,6,7
	///				0,0,0,0,4
	///			]
	///			
	///		:gt  n*(n-1) /2
	/// 
	///			[
	///				1,2,3,4
	///				0,6,7,8
	///				0,0,1,2
	///				0,0,0,0
	///			]
	///			
	///		:ge  n*(n) /2
	/// 
	///			[
	///				1,2,3,4
	///				0,6,7,8
	///				0,0,0,2
	///				0,0,0,0
	///			]
	///			
	///		:gt  n*(n) /2
	/// 
	///			[
	///				1,2,3,4
	///				0,0,7,8
	///				0,0,0,2
	///				0,0,0,0
	///			]
	/// 
	///	
	///	/// grid triag
	///  the count of 0 cels is 
	///		: gt  (n/2 *n/2)
	///			[
	///				1,2,3,4,5
	///				5,6,7,8,9
	///				9,1,0,0,0
	///				2,3,0,0,0
	///				3,4,0,0,0
	///			]
	///		: ge  (n/2 *n/2)
	///			[
	///				1,2,3,4
	///				5,6,7,8
	///				9,1,0,0
	///				2,3,0,0
	///			]
	///			,which is block wise triag plaid <see cref="matrix_.sq.grid_.IPlaid"/>
	///  
	public interface ISparse:real.matrix_.sq.IBe { }



}
