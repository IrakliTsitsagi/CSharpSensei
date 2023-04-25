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
                Console.WriteLine(masivi[i]);
            }
            ricxvtaJami(masivi, masivi.Length);
            ricxvtaNamravli(masivi, masivi.Length);
            minNumber(masivi, masivi.Length);
            maxNumber(masivi, masivi.Length);
            zrdisMixedvit(masivi, masivi.Length);
            klebisMixedvit(masivi, masivi.Length);
        }


        // ricxvta jamis metodi
        public static int ricxvtaJami(int[] masivi, int axali)
        {
            int jami = 0;

            for (int i = 0; i < masivi.Length; i++)
            {
                jami += masivi[i];

            }
            Console.WriteLine("elementebis jamia " + jami);
            return jami;
        }

        // ricxvta jamis metodi
        public static int ricxvtaNamravli(int[] masivi, int axali)
        {
            int namravli = 1;

            for (int i = 0; i < masivi.Length; i++)
            {
                namravli *= masivi[i];

            }
            Console.WriteLine("elementebis namravlia " + namravli);
            return namravli;
        }

        // min number
        public static int minNumber(int[] masivi, int axali)
        {
            int minNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] < minNum)
                    minNum = masivi[i];
            }
            Console.WriteLine("minimaluri ricxvia " + minNum);
            return minNum;
        }


        // max number
        public static int maxNumber(int[] masivi, int axali)
        {
            int maxNum = masivi[0];
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] > maxNum)
                    maxNum = masivi[i];
            }
            Console.WriteLine("minimaluri ricxvia " + maxNum);
            return maxNum;
        }

        // zrdis mixedvit
        public static int zrdisMixedvit(int[] masivi, int axali)
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

            Console.WriteLine("zrdis mixedvit");
            for (int k = 0; k < masivi.Length; k++)
            {

                Console.Write(masivi[k] + " ");
            }
            return temp;
        }



        // klebis mixedvit
        public static int klebisMixedvit(int[] masivi, int axali)
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

            Console.WriteLine("\nklebis mixedvit");
            for (int k = 0; k < masivi.Length; k++)
            {

                Console.Write(masivi[k] + " ");
            }
            return temp;
        }

    }
}
