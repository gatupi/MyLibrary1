using System;

namespace MyLibrary1.Exceptions {
    public class MyArrayException : ApplicationException  {

        public MyArrayException() : base() { }
        public MyArrayException(string message) : base(message) { }
    }
}
