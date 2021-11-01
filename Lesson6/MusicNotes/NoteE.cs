using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    class NoteE : Note
    {
        public NoteE()
        {
            Pause = false;
        }
        public NoteE(int oktave, int duration)
        {
            Frequency = GetFrequency(oktave);
            Duration = duration;
            Pause = false;
        }

        private int GetFrequency(int oktave)
        {
            int n = (oktave - 1) * 12 + 7;
            return (int)(27.5 * Math.Pow(2, (double)n / 12));
        }
    }
}
