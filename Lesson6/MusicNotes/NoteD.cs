using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    class NoteD : Note
    {
        public NoteD()
        {
            Pause = false;
        }
        public NoteD(int oktave, int duration)
        {
            Frequency = GetFrequency(oktave);
            Duration = duration;
            Pause = false;
        }

        private int GetFrequency(int oktave)
        {
            int n = (oktave - 1) * 12 + 5;
            return (int)(27.5 * Math.Pow(2, (double)n / 12));
        }
    }
}
