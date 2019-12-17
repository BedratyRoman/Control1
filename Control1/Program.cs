using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Kharkv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352";

            string[] strmass = str.Split('=', ',', ';');

           //  Console.WriteLine(strmass[0]);


          //  Console.ReadKey();
            int count = 1;

            for (int i = 0; i < str.Length; i ++)
                {
                 
                if(str[i]==';')

                {
                    count++;
                                                        
                }

                }

            string[] strmass6 = new string[count];
            int p = 0;
            for (int j = 0; j < count; j++)


            {

                strmass6[j] = strmass[p];
                p = p + 3;

            }

            string[] strmass2 = new string[count];
            int k = 0;
            for (int j = 0; j < count; j++)
                

                {
                
                strmass2[j] = strmass[k];
                k = k + 3;

                  }

          /*  Console.WriteLine(strmass2[0]);
            Console.WriteLine(strmass2[1]);
            Console.WriteLine(strmass2[2]);*/



               string tmp;
               for (int i = 0; i < count - 1; i++)

               {
                   for (int j = 0; j < count - i - 1; j++)
                   {
                       if (strmass2[j + 1].Length > strmass2[j].Length)

                       {
                           tmp = strmass2[j + 1];
                        strmass2[j + 1] = strmass2[j];
                        strmass2[j] = tmp;

                        
                       }

                   }

                      
               }
         //   Console.WriteLine("Longest name:" +strmass2[0]+'(' +strmass2[0].Length+" letters )");
            /* string temp;
                 for (int i = 0; i < count; i++)

                 {

                     if (strmass2[i].Length < strmass2[i + 1].Length)
                     {
                         temp = strmass2[i];
                         strmass2[i] = strmass2[i + 1];
                         strmass2[i + 1] = temp;
                         i++;

                     }

                     Console.WriteLine(strmass2[0]);

                 }*/






            // Console.WriteLine(count);



            int[] strmass3 = new int[count];
            int l = 1;
            for (int j = 0; j < count; j++)


            {

                strmass3[j] = Convert.ToInt32(strmass[l]);
                l = l + 3;

            }

            int tmp1;
            for (int i = 0; i < count - 1; i++)

            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (strmass3[j + 1] > strmass3[j])

                    {
                        tmp1 = strmass3[j + 1];
                        strmass3[j + 1] = strmass3[j];
                        strmass3[j] = tmp1;



                    }

                }



                //   Console.WriteLine(strmass3[0]);
               
                

               // Console.ReadKey();
            }

            string outcity = Convert.ToString (strmass3[0]);
           // Console.WriteLine(outcity);


            for(int i = 0; i < strmass.Length; i++)
            {
                if (string.Equals(outcity, strmass[i]))
                {
                    Console.WriteLine("Most populated:" + strmass[i - 1] + '(' + outcity + " people)");
                    break;
                }
            }

            Console.WriteLine("Longest name:" + strmass2[0] + '(' + strmass2[0].Length + " letters )");

            int[] strmass5 = new int[count];
            int m = 1;
            for (int j = 0; j < count; j++)


            {

                strmass5[j] = Convert.ToInt32(strmass[m]);
                m = m + 3;
                

            }

            int[] strmass4 = new int[count];
            int n = 2;
            for (int j = 0; j < count; j++)


            {

                strmass4[j] = Convert.ToInt32(strmass[n]);
                n = n + 3;

            }

            double[] dencity = new double[count];
            for(int denc = 0; denc < count; denc++)

            {

                dencity[denc] =Convert.ToDouble(strmass5[denc]) / Convert.ToDouble (strmass4[denc]);
                
            }
            Console.WriteLine("Dencity :");


            for (int i = 0; i < count; i++)

            { Console.WriteLine(strmass6[i] + '-' +string.Format("{0:N2}", dencity[i]));
                Console.WriteLine();
            }


            int tmp2;
            for (int i = 0; i < count - 1; i++)

            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (strmass4[j + 1] > strmass4[j])

                    {
                        tmp2 = strmass4[j + 1];
                        strmass4[j + 1] = strmass4[j];
                        strmass4[j] = tmp2;



                    }

                }



               
            }
            //Console.WriteLine(strmass3[0]);
            //Console.WriteLine(strmass4[0]);
            Console.ReadKey();

        }
    }
}
