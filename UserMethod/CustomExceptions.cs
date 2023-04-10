using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMethod
{
    public class CustomExceptions : Exception
    {
       
            public enum ExceptionType
            {
               INVALID
            }
            public ExceptionType exceptionType;
            public CustomExceptions(ExceptionType exceptionType, string message) : base(message)
            {
                this.exceptionType = exceptionType;
            }
        }
    
}
