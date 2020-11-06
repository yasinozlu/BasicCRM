using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.Core.Utilities
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
