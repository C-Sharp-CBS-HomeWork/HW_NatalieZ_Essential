using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    class NoteC : Note
    {
        
        public NoteC()
        {
            Pause = false;
        }
        public NoteC(int oktave, int duration)
        {
            Frequency = GetFrequency(oktave);
            Duration = duration;
            Pause = false;
        }

        private int GetFrequency(int oktave) 
        {
            int n = (oktave - 1) * 12 + 3;
            return (int)(27.5 * Math.Pow(2, (double)n / 12));
        }
    }
}
