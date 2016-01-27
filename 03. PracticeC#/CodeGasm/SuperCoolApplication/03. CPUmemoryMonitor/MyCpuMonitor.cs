using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Speech.Synthesis;

namespace MyCpuMonitor
{
    class Program
    {
        // Where all the magic happens
        static void Main(string[] args)
        {
            // This greets the user in the default voice
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome to Petko Trenev's program");

            #region My Performance Counters
            // This will pull the current CPU load in percentage
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor information", "% Processor Time", "_Total");

            // This will pull the available memory in MB 
            PerformanceCounter perfMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");

            // Number of time the system has been on (in seconds)
            PerformanceCounter perfUpTimeCount = new PerformanceCounter("System", "System Up Time");
            #endregion

            // Infinite while loop
            while (true)
            {
                int currentCpuPercentage =(int) perfCpuCount.NextValue();
                int currentAvailableMemory =(int) perfMemoryCounter.NextValue();

                // Every one second print the CPU load in percentage on screen                   
                Console.WriteLine("CPU load is      : {0}%",currentCpuPercentage);
                Console.WriteLine("Available Memory : {0}GB",currentAvailableMemory);

                // Only speak to me if the percentages are more than 80 percent
                if (currentCpuPercentage > 80)
                {
                    string cpuLoadVocalMessage = String.Format("The current CPU load is : {0} percent", currentCpuPercentage);
                    synth.Speak(cpuLoadVocalMessage);
                }

                // Only speak to me if the memory is bellow 1024
                if (currentAvailableMemory < 1024)
                {
                    string memAvailableVocalMessage = String.Format("The current Available memory is {0} ", currentAvailableMemory);
                    synth.Speak(memAvailableVocalMessage);
                }
                 
                // Speak to the user with text to speech to tell what the current values are

                Thread.Sleep(1000);

            }
        }
    }
}
