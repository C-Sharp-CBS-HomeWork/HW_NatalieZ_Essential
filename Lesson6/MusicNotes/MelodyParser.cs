using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.MusicNotes
{
    static class MelodyParser
    {

        /// <summary>
        /// Can pars melody 
        /// </summary>
        /// <param name="melody">String with notes like C54 where C-note 5-oktave 4-duration. Notes are separated by comma. Space is a pause.
        /// string starts with duration of pause, then '|', then string with notes
        /// Example! 4|C54,D14,H32, ,E32,F34
        /// </param>
        /// <returns></returns>
        static public Note[] ParseMelody(string melody)
        {
            string[] notes = melody.Split('|', StringSplitOptions.None);
            int pauseDuration = int.Parse(notes[0]);
            notes =notes[1].Split(',', StringSplitOptions.None);
            Note[] result = new Note[notes.Length];
            for (int i = 0; i < notes.Length; i++)
            {
                if (string.IsNullOrEmpty(notes[i].Trim()))
                {
                    result[i] = NoteCreator.Create(string.Empty, pauseDuration);
                }
                else
                { 
                    result[i] = NoteCreator.Create(notes[i].Substring(0,2), int.Parse(notes[i].Substring(2)));
                }
            }

            return result;
        }
    }
}
