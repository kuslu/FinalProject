using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) //git base'e (Result) de ki mesajın bu =message
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
