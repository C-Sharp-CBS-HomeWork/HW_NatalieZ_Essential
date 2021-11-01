using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    abstract class Note
    {
        private int _frequency;
        private int _duration;
        private bool _pause;

        public int Frequency 
        {
            get { return _frequency; }
            protected set { _frequency = value; } 
        }

        public int Duration { get => _duration; protected set => _duration = value; }

        public bool Pause { get => _pause; protected set => _pause = value; }
    }
}
