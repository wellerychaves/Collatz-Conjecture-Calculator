namespace Collatz
{
    internal class Program
    {
        // Recebe e testa todos os números enviado durante o looping, no final ela retorna um array com todos os valores após os calculos.
        // Receives and tests all numbers sent in the looping, in the end, is returned an array with all values with all math applied 
        static double[] Validator(double numberToTest)
        {
            var validatorList = new List<double> { };
            validatorList.Add(numberToTest);

            for (double index = numberToTest; index > 1;)
            {
                if (index % 2 == 0)
                {
                    index /= 2;
                }
                else
                {
                    index = (index * 3) + 1;
                }
                validatorList.Add(index);
            }
            double[] validatorArray = validatorList.ToArray();
            return validatorArray;
        }

        static void Main(string[] args)
        {
            double million = 1000000;
            double bestNumber = 0;
            double highestSequence = 0;
            double[] intArray;

            // looping que chama a função Validator para testar todos os números de 1 a 1 milhão e registrar a maior sequencia e o numero inicial da mesma.
            // looping to call the Validator function to test all numbers from 1 to a million and register the highest sequence and the initial number from the sequence.
            while (million >= 1)
            {
                intArray = Validator(million);
                if (intArray.Length > highestSequence)
                {
                    highestSequence = intArray.Length;
                    bestNumber = intArray[0];
                }

                million--;
            }

            Console.WriteLine($"O número inicial de maior sequencia é: {bestNumber}");
            Console.WriteLine($"A maior sequencia é de {highestSequence} termos");
        }
    }
}