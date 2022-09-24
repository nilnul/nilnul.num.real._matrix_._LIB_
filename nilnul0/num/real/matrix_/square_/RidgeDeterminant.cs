using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.realNumber;
using nilnul.proposition.predicate;
using nilnul.proposition;

namespace nilnul.linearAlgebra
{
    /// <summary>
    /// This will represent those deternimant in the form of:
    /// a,b,b,...,b
    /// b,a,b,...,b
    /// ............
    /// b,b,b,...,a
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    /// <remarks>
    ///     as a tuple and some predicate on the elements of tuple.
    /// </remarks>
    public partial class RidgeDeterminant
    {
        ///// <summary>
        ///// the cardinality of the tuple
        ///// </summary>
        //static public int TupleSize=3;
        //static public Predicate[] Axioms=new []{
        //    new IsType( ;
        //};

        static public Definition definition {
            get {
                return new Definition(
                    x=>x
                    );
            }
        }

        static public bool Is(object obj,IEnumerable<Proposition> axioms) {

            
        }

        public RidgeDeterminant()
        {
        }
					

        

        
        public RidgeDeterminant(RealI diag,RealI flank)
        {
            this.diag = diag;
            this.flank = flank;

        }
        
    }
}
