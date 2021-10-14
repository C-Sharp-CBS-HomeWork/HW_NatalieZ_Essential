using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override string SaveDocument()
        {
            return "Document saved in new version.";
        }
    }
}
