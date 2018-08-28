using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public double FirstNumber;
        public double SecondNumber;

        public double ShowResult()
        {
            return FirstNumber + SecondNumber;
        }
        private string Message;
        public string ShowMessage()
        {
           

            Message = "First Number" + "SecondNumber" + SecondNumber;
           return Message;
        }
    }
}
