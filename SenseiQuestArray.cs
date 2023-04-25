namespace SenseiQuestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //shemovitanot masivi
            int min = 0;
            int max = 100;

            int[] masivi = new int[15];
            Random randNum = new Random();

            for (int i = 0; i < masivi.Length; i++)
            {
                masivi[i] = randNum.Next(min, max);
                Console.WriteLine(masivi[i]);
            }

            //gamovtvalot masivis elementebis jami
            int jami = 0;

            for (int i = 0; i < masivi.Length; i++)
                jami += masivi[i];
            Console.WriteLine("elementebis jamia " + jami);


            //gamovtvalot masivis elementebis namravli
            int namravli = 1;

            for (int i = 0; i < masivi.Length; i++)
                namravli *= masivi[i];
            Console.WriteLine("elementebis namravlia " + namravli);


            // min number vipovot
            int minNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
                if (masivi[i] < minNum)
                    minNum = masivi[i];
            Console.WriteLine("minimaluri ricxvia " + minNum);


            // max number vipovot
            int maxNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
                if (masivi[i] > maxNum)
                    maxNum = masivi[i];
            Console.WriteLine("maqsimaluri ricxvia " + maxNum);


            // zrdis mixedvit
            int temp = masivi[0];


            for (int i = 0; i < masivi.Length; i++)


                for (int j = i; j < masivi.Length; j++)


                    if (masivi[i] > masivi[j])
                    {

                        temp = masivi[i];
                        masivi[i] = masivi[j];
                        masivi[j] = temp;
                    }

            Console.WriteLine("zrdis mixedvit");
            for (int k = 0; k < masivi.Length; k++)
            {

                Console.Write(masivi[k] + " ");
            }


            // klebis mixedvit
            int tempo = masivi[0];

            for (int i = 0; i < masivi.Length; i++)


                for (int j = i; j < masivi.Length; j++)


                    if (masivi[i] < masivi[j])
                    {

                        tempo = masivi[i];
                        masivi[i] = masivi[j];
                        masivi[j] = tempo;


                    }
            Console.WriteLine("\nklebis mixedvit");
            for (int k = 0; k < masivi.Length; k++)
            {

                Console.Write(masivi[k] + " ");
            }

        }
    }
}
