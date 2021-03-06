﻿//---------------------------------------------------------------------
// <copyright file="OpenApiYamlWriter.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.IO;

namespace Microsoft.OData.OpenAPI
{
    /// <summary>
    /// YAML writer.
    /// </summary>
    internal class OpenApiYamlWriter : OpenApiWriterBase
    {
        protected override int IndentShift { get { return -1; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenApiYamlWriter"/> class.
        /// </summary>
        /// <param name="textWriter">The text writer.</param>
        public OpenApiYamlWriter(TextWriter textWriter)
            : this(textWriter, new OpenApiWriterSettings())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenApiYamlWriter"/> class.
        /// </summary>
        /// <param name="textWriter">The text writer.</param>
        /// <param name="settings">The writer settings.</param>
        public OpenApiYamlWriter(TextWriter textWriter, OpenApiWriterSettings settings)
            : base(textWriter, settings)
        {
        }

        /// <summary>
        /// Write YAML start object.
        /// </summary>
        public override void WriteStartObject()
        {
            Scope preScope = CurrentScope();

            Scope curScope = StartScope(ScopeType.Object);

            IncreaseIndentation();

            if (preScope != null && preScope.Type == ScopeType.Array)
            {
                curScope.IsInArray = true;
            }
        }

        /// <summary>
        /// Write YAML end object.
        /// </summary>
        public override void WriteEndObject()
        {
            Scope current = EndScope(ScopeType.Object);

            /*
            if (current.ObjectCount == 0)
            {
                Writer.Write(WriterConstants.WhiteSpaceForEmptyObjectArray);
            }*/

            DecreaseIndentation();
        }

        /// <summary>
        /// Write YAML start array.
        /// </summary>
        public override void WriteStartArray()
        {
            StartScope(ScopeType.Array);
            IncreaseIndentation();
        }

        /// <summary>
        /// Write YAML end array.
        /// </summary>
        public override void WriteEndArray()
        {
            Scope current = EndScope(ScopeType.Array);
            /*
            if (current.ObjectCount == 0)
            {
                Writer.Write(WriterConstants.WhiteSpaceForEmptyObjectArray);
            }*/
            DecreaseIndentation();
        }

        /// <summary>
        /// Write the start property.
        /// </summary>
        public override void WritePropertyName(string name)
        {
            ValifyCanWritePropertyName(name);

            Scope current = CurrentScope();

            if (current.ObjectCount == 0)
            {
                if (current.IsInArray)
                {
                    Writer.WriteLine();

                    WritePrefixIndentation();

                    Writer.Write(WriterConstants.PrefixOfArrayItem);
                }
                else
                {
                    if (!IsTopLevelObjectScope())
                    {
                        Writer.WriteLine();
                    }
                    WriteIndentation();
                }
            }
            else
            {
                Writer.WriteLine();
                WriteIndentation();
            }

            Writer.Write(name);
            // writer.Write(WriterConstants.NameValueSeparator);
            Writer.Write(":");

            ++current.ObjectCount;
        }

        /// <summary>
        /// Write string value.
        /// </summary>
        /// <param name="value">The string value.</param>
        public override void WriteValue(string value)
        {
            WriteValueSeparator();

            value = value.Replace("\n", "\\n");

            if (value.StartsWith("#"))
            {
                value = "'" + value + "'";
            }

            Writer.Write(value);
        }

        /// <summary>
        /// the empty scalar as “null”.
        /// </summary>
        public override void WriteNull()
        {
            WriteValueSeparator();
            // nothing here
        }

        protected override void WriteValueSeparator()
        {
            if (IsArrayScope())
            {
                Writer.WriteLine();
                WriteIndentation();
                Writer.Write(WriterConstants.PrefixOfArrayItem);

                CurrentScope().ObjectCount++;
            }
            else
            {
                Writer.Write(" ");
            }
        }
    }
}
