using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson6.MusicNotes;
using Lesson6.Calculator;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace Lesson6
{
    public partial class Form1 : Form
    {
         string melody = "";

        static Audio myAudio = new Audio();
        private byte[] myWaveData;

        // Sample rate (Or number of samples in one second)
        private const int SAMPLE_FREQUENCY = 44100;
        // 60 seconds or 1 minute of audio
        private const int AUDIO_LENGTH_IN_SECONDS = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            melody = "4|E54,E54,D54,D54,E54,E54,F52,E54,E54,D54,D54,E54,E54,F52,E54,E54,D54,D54,E54,E54,F54,F54,E54,E54,D54,D54,E54,E54,C54,C54";
            //melody = "4|E54,E54,D54,D54,E54,E54,F54,F54,E54,E54,D54,D54,E54,E54,C54,C54";
            //melody = "4|E54,E54,D54,D54,E54,E54,F52,E54,E54,D54,D54,E54,E54,F52";
            //melody = "4|C34,D34,E34,F34,G34,A34,H34,C44,D44,E44,F44,G44,A44,H44,C54,D54,E54,F54,G54,A54,H54";
            //melody = "4|C54,D54,E54,F54,G54,A54,H54";
            //melody = "4|C34,D34,E34,F34,G34,A34,H34,C44,D44";
            //Test(MelodyParser.ParseMelody(melody));
            lblMelody.Text = melody;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Playing...";
            Player.Play(myWaveData);
            lblStatus.Text = "Lets play it again.";
            //Test2(MelodyParser.ParseMelody(melody));
        }

        private void Test2(Note[] notes)
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

            myAudio.Play(myWaveData, AudioPlayMode.WaitToComplete);
        }


        private void Test(Note[] notes)
        {

            FileStream stream = new FileStream("test.wav", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            //int samples = 88200 * 4;
            int samples = 88200 * 4;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);
            //double aNatural = 220.0;
            double ampl = 10000;
            double perfect = 1.5;
            //double concert = 1.498307077;
            //double freq = aNatural * perfect;
            for (int j = 0; j < notes.Length; j++)
            {
                double freq = notes[j].Frequency * perfect;
                
                for (int i = 0; i < samples / 4; i++)
                {
                    double t = (double)i / (double)samplesPerSecond;
                    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                    writer.Write(s);
                }

            }
            //freq = aNatural * concert;
            //for (int i = 0; i < samples / 4; i++)
            //{
            //    double t = (double)i / (double)samplesPerSecond;
            //    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
            //    writer.Write(s);
            //}
            //for (int i = 0; i < samples / 4; i++)
            //{
            //    double t = (double)i / (double)samplesPerSecond;
            //    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * perfect * 2.0 * Math.PI)));
            //    writer.Write(s);
            //}
            //for (int i = 0; i < samples / 4; i++)
            //{
            //    double t = (double)i / (double)samplesPerSecond;
            //    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * concert * 2.0 * Math.PI)));
            //    writer.Write(s);
            //}
            writer.Close();
            stream.Close();
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Prepearing melopy, please wait... (It can take long time to create a melody, but you can play it then plenty times.)";
            btnPrepare.Enabled = false;
            myWaveData = Player.PrepareMelody(MelodyParser.ParseMelody(melody));

            lblStatus.Text = "Ready to play.";
            btnPlay.Enabled = true;
            
        }

        private void btnGetNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lblNumA.Text = Math.Round(random.NextDouble() * random.Next(-10000, 10000), 3).ToString();
            lblNumB.Text = Math.Round(random.NextDouble() * random.Next(-10000, 10000), 3).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = Calculator.Calculator.Add(double.Parse(lblNumA.Text), double.Parse(lblNumB.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = Calculator.Calculator.Sub(double.Parse(lblNumA.Text), double.Parse(lblNumB.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = Calculator.Calculator.Div(double.Parse(lblNumA.Text), double.Parse(lblNumB.Text)).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                lblResult.Text = ex.Message;
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblResult.Text = Calculator.Calculator.Mult(double.Parse(lblNumA.Text), double.Parse(lblNumB.Text)).ToString();
        }
    }
}
