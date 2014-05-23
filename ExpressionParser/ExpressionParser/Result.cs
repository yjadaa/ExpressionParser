using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionParser
{
    class Result
    {
        #region Parameters

        public string Name;
        public double Score;

        #endregion

        // constructor
        public Result(string name, double score) 
        {
	        this.Name = name;
	        this.Score = score;
        }
    }
}
