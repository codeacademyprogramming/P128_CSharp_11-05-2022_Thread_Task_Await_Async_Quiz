using System;
using System.Collections.Generic;
using System.Text;

namespace P128CustomException
{
    class CustomLengthException : Exception
    {
        public override string HelpLink { get => "test.com"; set => HelpLink = "Test.com"; }
        public CustomLengthException(string msg) : base(msg){ }
    }
}
