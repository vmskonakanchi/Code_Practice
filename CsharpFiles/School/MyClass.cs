using System;
namespace School
{
    public class MyClass
    {
        private string mystring = "Hey this is s string from baseclass";
        public string Containedstring { get => mystring; set => mystring = value; }
        protected virtual string GetString()
        {
            return Containedstring;
        }
    }
}