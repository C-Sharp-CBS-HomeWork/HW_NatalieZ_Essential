using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Threading.Tasks;

namespace Lesson6.MusicNotes
{
    static class Player
    {
        private static Audio myAudio = new Audio();
        private static byte[] myWaveData;

        // Sample rate (Or number of samples in one second)
        private const int SAMPLE_FREQUENCY = 44100;
        // 60 seconds or 1 minute of audio
        private const int AUDIO_LENGTH_IN_SECONDS = 1;

        static public byte[] PrepareMelody(Note[] notes)
        {
            List<Byte> tempBytes = new List<byte>();

            WaveHeader header = new WaveHeader();
            FormatChunk format = new FormatChunk();
            DataChunk data = new DataChunk();
            SineGenerator leftData = null;
            SineGenerator rightData = null;

            //double t = 1.498307077;
            //double t = 1.5;
            double t = 1;
            for (int j = 0; j < notes.Length; j++)
            {
                //double freq = notes[j].Frequency;
                leftData = new SineGenerator(notes[j].Frequency * t,
                   SAMPLE_FREQUENCY, AUDIO_LENGTH_IN_SECONDS, (UInt16)notes[j].Duration);
                rightData = new SineGenerator(notes[j].Frequency * t,
                   SAMPLE_FREQUENCY, AUDIO_LENGTH_IN_SECONDS, (UInt16)notes[j].Duration);
                data.AddSampleData2(leftData.Data, rightData.Data);
            }

            header.FileLength += format.Length() + data.Length();

            tempBytes.AddRange(header.GetBytes());
            tempBytes.AddRange(format.GetBytes());
            tempBytes.AddRange(data.GetBytes());

            myWaveData = tempBytes.ToArray();
            return myWaveData;
        }

        static public void Play(byte[] data)
        {
            myAudio.Play(data, AudioPlayMode.WaitToComplete);
        }
    }
}
