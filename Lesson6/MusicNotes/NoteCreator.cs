using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    static class NoteCreator
    {
        public static Note Create(string note, int duration)
        {
            Note result;
            if (string.IsNullOrEmpty(note))
            { 
                    return new NotePause();
            }
            int oktave = int.Parse(note[1].ToString());
            switch (note[0])
            {
                case 'C':
                    result = new NoteC(oktave, duration);
                    break;
                case 'D':
                    result = new NoteD(oktave, duration);
                    break;
                case 'E':
                    result = new NoteE(oktave, duration);
                    break;
                case 'F':
                    result = new NoteF(oktave, duration);
                    break;
                case 'G':
                    result = new NoteG(oktave, duration);
                    break;
                case 'A':
                    result = new NoteA(oktave, duration);
                    break;
                case 'H':
                    result = new NoteH(oktave, duration);
                    break;
                case ' ':
                    result = new NotePause();
                    break;
                default:
                    throw new ArgumentException();
            }

            return result;
        }
    }
}
