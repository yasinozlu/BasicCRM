using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicCRM.Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success, string message) : base(data, success, message)
        {

        }
        public SuccessDataResult(T data ) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
       
    }
}
