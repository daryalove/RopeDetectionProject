using System;

namespace RopeDetectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting training...");
                // Measure #1 prediction execution time.
                var watch = System.Diagnostics.Stopwatch.StartNew();

                ModelBuilder.CreateModel();

                // Stop measuring time.
                watch.Stop();

                var elapsedMs = watch.ElapsedMilliseconds;
                var minutes = TimeSpan.FromMilliseconds(elapsedMs).TotalMinutes;
                Console.WriteLine("First Training took: " + minutes + " minutes");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong: " + ex.Message);
            }
        }
    }
}
