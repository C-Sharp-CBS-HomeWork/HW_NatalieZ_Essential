using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Task2___Player
{
    class Player : IPlayable, IRecodable
    {
        private bool _paused, _recording, _playing, _notStarted;

        public bool Playing
        {
            get { return _playing; }
            private set
            {
                _playing = value;
                if (value == true)
                {
                    _paused = false;
                    _recording = false;
                    _notStarted = false;
                }
            }
        }

        public bool Paused
        {
            get { return _paused; }
            private set
            {
                _paused = value;
                if (value == true)
                {
                    _notStarted = false;
                }
            }
        }

        public bool NotStarted
        {
            get { return _notStarted; }
            private set
            {
                _notStarted = value;
                if (value == true)
                {
                    _playing = false;
                    _recording = false;
                    _paused = false;
                }
            }
        }

        public bool Recording
        {
            get { return _recording; }
            private set
            {
                _recording = value;
                if (value == true)
                {
                    _playing = false;
                    _notStarted = false;
                    _paused = false;
                }
            }
        }

        public Player()
        {
            NotStarted = true;
        }

        public string Pause()
        {
            if (Paused)
            {
                return "Already paused!";
            }
            else if (NotStarted)
            {
                return "Playing not started! Can't be paused!";
            }
            else if (Playing || Recording)
            {
                Paused = true;
            }
            return "Paused...";
            
        }

        public string Play()
        {
            if (Playing && !Paused)
            {
                return "Already playing!";
            }
            else if (Recording)
            {
                return "Recording in progress! Can't play at the same time!";
            }
            else if (NotStarted || Paused)
            {
                Playing = true;
            }
            return "Playing...";
        }

        public string Record()
        {
            if (Recording && !Paused)
            {
                return "Already recording!";
            }
            else if (Playing)
            {
                return "Playing in progress! Can't record at the same time!";
            }
            else if (NotStarted || Paused)
            {
                Recording = true;
            }
            return "Recording...";
        }

        public string Stop()
        {
            if (NotStarted)
            {
                return "Nothing to stop!";
            }
            else if (Playing || Recording)
            {
                NotStarted = true;
            }
            return "Stopped...";
        }
    }
}
