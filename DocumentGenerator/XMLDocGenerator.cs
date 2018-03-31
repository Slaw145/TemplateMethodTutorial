using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentGenerator
{
    class XMLDocGenerator : DocumentGenerator
    {
        public string documentDetails;

        public override void generateDetails()
        {
            documentDetails = "<name>\n\nProduct one\n\n</name>";
        }

        public override void generateBody()
        {
            Console.WriteLine("<product>\n\n" + documentDetails + "\n\n</product>");
        }

        public override void generateHeader()
        {
            Console.WriteLine("<?xml version= " + 1.0 + " ?>");
        }
    }
}
