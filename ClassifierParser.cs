﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCSE_Reloaded.ClassifierLanguage
{
    public class Parser
    {
        public static string ParseToCSharp(string source)
        {
            string result;
            result = ProcessReplace(source);
            result = MethodReplace(result);
            return result;
        }

        private static string ProcessReplace(string source)
        {
            string result;
            result = source.Replace("#Classifier", "public class Program\r\n{");
            result = result.Replace("#Markings", "// Generated by RCSE Classifier");
            result = result.Replace("#DefineImport", "using");
            result = result.Replace("#End", ";");
            result = result.Replace("#MainMethod", "public static void Main(string[] args)\r\n  {");
            result = result.Replace("#EndMainMethod", "    }");
            result = result.Replace("#EndClassifier", "}");
            return result;
        }

        private static string MethodReplace(string source)
        {
            string result;
            result = source.Replace("Print", "Console.WriteLine");
            result = result.Replace("Error", "Console.Error");
            result = result.Replace("PrintCurrentLine", "Console.Write");
            return result;
        }
    }
}
