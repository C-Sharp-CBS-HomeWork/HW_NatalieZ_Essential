using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class ProDocumentWorker : DocumentWorker
    {
        public override string EditDocument()
        {
            return "Document edited";
        }
        public override string SaveDocument()
        {
            return "Document saved in old version, you can save it in a new version in Expert version.";
        }

    }
}
