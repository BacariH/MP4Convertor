using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Lame;


namespace MP4Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertMp4ToMp3("YOUR DIRECTORY", "PATH OUTPUT"); 
        }

        public static void ConvertMp4ToMp3(string inputFile, string outputFile)
        {
            using (var reader = new MediaFoundationReader(inputFile))
            using (var writer = new LameMP3FileWriter(outputFile, reader.WaveFormat, LAMEPreset.VBR_90))
            {
                reader.CopyTo(writer);
            }
            Console.WriteLine("Complete!!");
        }

    }
}
