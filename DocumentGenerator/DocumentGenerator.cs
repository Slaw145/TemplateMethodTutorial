using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentGenerator
{
    abstract class DocumentGenerator
    {
        public abstract void generateHeader();
        public abstract void generateBody();
        public abstract void generateDetails();

        public void generateDocument()
        {
            generateHeader();
            generateDetails();
            generateBody();
        }
    }
}
