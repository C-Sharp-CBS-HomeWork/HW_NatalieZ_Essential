using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    class SineGenerator
    {
        private readonly double _frequency;
        private readonly UInt32 _sampleRate;
        private readonly UInt16 _secondsInLength;
        private readonly UInt16 _partOfSecond;
        private short[] _dataBuffer;

        public short[] Data { get { return _dataBuffer; } }

        public SineGenerator(double frequency,
           UInt32 sampleRate, UInt16 secondsInLength, UInt16 partOfSecond)
        {
            _frequency = frequency;
            _sampleRate = sampleRate;
            _secondsInLength = secondsInLength;
            _partOfSecond = partOfSecond;
            GenerateData();
        }

        private void GenerateData()
        {
            uint bufferSize = _sampleRate * _secondsInLength / _partOfSecond;
            _dataBuffer = new short[bufferSize];

            int amplitude = 32760;

            double timePeriod = (Math.PI * 2 * _frequency) /
               (_sampleRate);

            for (uint index = 0; index < bufferSize - 1; index++)
            {
                _dataBuffer[index] = Convert.ToInt16(amplitude *
                   Math.Sin(timePeriod * index));
            }
        }
    }
}
