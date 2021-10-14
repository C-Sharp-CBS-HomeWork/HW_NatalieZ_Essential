using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class DocumentWorker
    {
        public string OpenDocument()
        {
            return "Docunemt is opened.";
        }
        public virtual string EditDocument()
        {
            return "You can edit document in PRO version";
        }
        public virtual string SaveDocument()
        {
            return "You can save document in PRO version";
        }
    }
}
