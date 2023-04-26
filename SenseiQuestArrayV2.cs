namespace SenseiQuestArrayV2
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
                Console.Write(masivi[i] + " ");
            }

            int jami = ricxvtaJami(masivi);
            Console.WriteLine("\nricxvta jamia " + jami);

            int namravli = ricxvtaNamravli(masivi);
            Console.WriteLine("ricxvta namravlia " + namravli);

            int mini = minNumber(masivi);
            Console.WriteLine("minimum ricxvia " + mini);

            int maxi = maxNumber(masivi);
            Console.WriteLine("miximum ricxvia " + maxi);


            int[] zrda = zrdisMixedvit(masivi);
            Console.Write("zrdis mixedvit ");
            {
                for (int k = 0; k < masivi.Length; k++)

                    Console.Write(zrda[k] + " ");
            }

            int[] kleba = klebisMixedvit(masivi);
            Console.Write("\nklebis mixedvit ");
            {
                for (int k = 0; k < masivi.Length; k++)

                    Console.Write(kleba[k] + " ");
            }
        }


        // ricxvta jamis metodi
        public static int ricxvtaJami(int[] masivi)
        {
            int jami = 0;

            for (int i = 0; i < masivi.Length; i++)
            {
                jami += masivi[i];

            }

            return jami;
        }

        // ricxvta jamis metodi
        public static int ricxvtaNamravli(int[] masivi)
        {
            int namravli = 1;

            for (int i = 0; i < masivi.Length; i++)
            {
                namravli *= masivi[i];

            }

            return namravli;
        }

        // min number
        public static int minNumber(int[] masivi)
        {
            int minNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] < minNum)
                    minNum = masivi[i];
            }

            return minNum;
        }


        // max number
        public static int maxNumber(int[] masivi)
        {
            int maxNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] > maxNum)
                    maxNum = masivi[i];
            }

            return maxNum;
        }

        // zrdis mixedvit
        public static int[] zrdisMixedvit(int[] masivi)
        {
            int temp = masivi[0];


            for (int i = 0; i < masivi.Length; i++)


                for (int j = i; j < masivi.Length; j++)


                    if (masivi[i] > masivi[j])
                    {

                        temp = masivi[i];
                        masivi[i] = masivi[j];
                        masivi[j] = temp;
                    }

            return masivi;
        }



        // klebis mixedvit
        public static int[] klebisMixedvit(int[] masivi)
        {
            int temp = masivi[0];


            for (int i = 0; i < masivi.Length; i++)


                for (int j = i; j < masivi.Length; j++)


                    if (masivi[i] < masivi[j])
                    {

                        temp = masivi[i];
                        masivi[i] = masivi[j];
                        masivi[j] = temp;
                    }

            return masivi;
        }

    }
}
