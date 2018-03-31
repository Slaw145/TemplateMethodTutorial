using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentGenerator
{
    class HTMLDocGenerator : DocumentGenerator
    {
        public string documentDetails;

        public override void generateDetails()
        {
            documentDetails = "<header>\n\n</header>\n\n<footer>\n\n</footer>\n\n";
        }

        public override void generateBody()
        {
            Console.WriteLine("<body>\n\n" + documentDetails + "</body>");
        }

        public override void generateHeader()
        {
            Console.WriteLine("<head>\n\n</head>");
        }
    }
}
