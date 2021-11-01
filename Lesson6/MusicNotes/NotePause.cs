using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    class NotePause : Note
    {
        public NotePause()
        {
            Pause = true;
        }
        public NotePause(int duration)
        {
            Duration = duration;
            Pause = true;
        }
    }
}
