﻿

using System;

namespace MPPTracer.Format
{

    public abstract class Formatter : IFormatter
    {
        public const string TAB = "\t";
        public const string NL = "\r\n";

        abstract public string Format(TraceResult traceResult);
        public string CreateIndent(int nestingLevel)
        {
            string indent = "";
            for (int i = 0; i < nestingLevel; i++)
            {
                indent += TAB;
            }
            return indent;
        }
    }
}
