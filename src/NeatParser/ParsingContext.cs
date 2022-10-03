﻿namespace NeatParser
{
    public class ParsingContext : IParsingContext
    {
        /// <summary>
        /// Represents a number for records read. (Not including skipped).
        /// </summary>
        public int ActualRecordNumber { get; set; }

        /// <summary>
        /// Represents a number for records read. (Including skipped)
        /// </summary>
        public int PhysicalRecordNumber { get; set; }

        /// <summary>
        /// Constructs an instance of the parsing context.
        /// </summary>
        internal ParsingContext()
        { }
    }
}