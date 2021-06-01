using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo("pt-BR"));
            builder.AppendText("Olá, digite seu nome por favor.");
            builder.EndVoice();
            synthesizer.Speak(builder);

            string textoA = "";
            Console.WriteLine("Aguardando resposta...");
            textoA = Convert.ToString(Console.ReadLine());

            if (textoA != null)
            {
                var builderA = new PromptBuilder();
                builderA.StartVoice(new CultureInfo("pt-BR"));
                builderA.AppendText("Olá " + textoA + ", bem-vindo!");
                builderA.EndVoice();
                synthesizer.Speak(builderA);
            }
        }
    }
}
