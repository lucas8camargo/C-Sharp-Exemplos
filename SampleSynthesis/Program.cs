using System;
using System.Speech.Synthesis;

namespace SampleSynthesis
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();           

            synth.Volume = 100; // Define o volume, 100 é o volume máximo.

            synth.Rate = 2; // Define a velocidade da fala

            Console.WriteLine("Falando...");

            synth.Speak("Olá! Essa é uma amostra de voz");

        }
    }

    // Adicione a biblioteca System.Speech

    // Package Manager:
    // Install-Package System.Speech
    // .NET CLI:
    // dotnet add package System.Speech
}