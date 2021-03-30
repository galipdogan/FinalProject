using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Generic class T ile coder dan tip istiyoruz...
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
