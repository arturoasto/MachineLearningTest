using MachineLearningTestML.Model;
using System;

namespace MachineLearningTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var shouldContinue = true;
            while (shouldContinue)
            {
                var input = new ModelInput();
                input.SentimentText = Console.ReadLine();

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction} and score is: {result.Score}");

                Console.WriteLine("Should continue? Y/N");
                var response = Console.ReadKey();

                if (response.KeyChar.ToString() == "N") shouldContinue = false; 
            }
        }
    }
}
