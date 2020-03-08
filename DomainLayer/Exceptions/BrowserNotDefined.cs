using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer.Exceptions
{
    public class BrowserNotDefined : Exception
    {
        public BrowserNotDefined(string message) : base(message)
        {
        }
    }
}
