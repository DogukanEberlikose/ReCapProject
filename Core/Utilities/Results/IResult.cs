using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    { //Voidler için, Data dönmediğimiz zamanlar bunu kullanılır.
        bool Success { get; }
        string Message { get; }
    }
}
