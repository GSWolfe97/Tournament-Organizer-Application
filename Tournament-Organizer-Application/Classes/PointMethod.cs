using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament_Organizer_Application.Classes
{
    [Serializable]
    public class PointMethod
    {
        public List<Method> AllPointMethods { get; set; } = new List<Method>();

        public PointMethod()
        {
            AllPointMethods.Add(new Method("Escape - 1pt", 1));
            AllPointMethods.Add(new Method("Reversal - 2pts", 2));
            AllPointMethods.Add(new Method("Backpoint - 1pt", 1));
            AllPointMethods.Add(new Method("Backpoint - 2pts", 2));
            AllPointMethods.Add(new Method("Technical Violation - 1pt", 1));
        }
    }

    public struct Method
    {
        public string MethodScored { get; set; }
        public int Value { get; set; }

        public Method(string methodScored, int value)
        {
            MethodScored = methodScored;
            Value = value;
        }

        public override string ToString()
        {
            return MethodScored;
        }
    }
}
