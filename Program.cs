/*
*Msg1: 96+!9?-?P,'"$90-=X#?#91?96#>P0+8<=0L55B."=4)

1ª Mensagem: INIMIGOS TENTARAM ASSASSINAR HITLER EM BREVE
Chaves: Chave 1: 112  Chave 2: 120  Chave 3: 98  Chave 4: 108
Composição das chaves =  1886937708

Msg2: >U():2*%>U/$_="5309A:&? _%9$)<85>U; -4K 24%)>

2ª Mensagem: A CHEGADA DE HITLER ESTA PREVISTA PARA AMANHA
Chaves: Chave 1: 127  Chave 2: 117  Chave 3: 107  Chave 4: 97
Composição das chaves =   2138401633
*/

using System;

namespace desafio2
{
    class Program
    {
        static void Main()
        {
            string data;
            char[] c = new char[50];
            bool end = false;
            var toBeMatched = "HITLER";

            Console.Write("Mensagem: ");
            data = Console.ReadLine();


            while (end == false)
            {
                for (int key1 = 0; key1 <= 255; key1++)
                    for (int key2 = 0; key2 <= 255; key2++)
                        for (int key3 = 0; key3 <= 255; key3++)
                            for (int key4 = 0; key4 < 255; key4++)
                            {
                                for (int i = 0, j = 1, k = 2, l = 3; i < data.Length; i = i + 4, j = j + 4, k = k + 4, l = l + 4)
                                {
                                    if (i < data.Length)
                                    {
                                        c[i] = data[i];
                                        c[i] = Convert.ToChar(Convert.ToInt32(c[i]) ^ key1);
                                    }
                                    if (j < data.Length)
                                    {
                                        c[j] = data[j];
                                        c[j] = Convert.ToChar(Convert.ToInt32(c[j]) ^ key2);
                                    }
                                    if (k < data.Length)
                                    {
                                        c[k] = data[k];
                                        c[k] = Convert.ToChar(Convert.ToInt32(c[k]) ^ key3);
                                    }
                                    if (l < data.Length)
                                    {
                                        c[l] = data[l];
                                        c[l] = Convert.ToChar(Convert.ToInt32(c[l]) ^ key4);
                                    }
                                }
                                string msg = new string(c);

                                var idx = msg.IndexOf(toBeMatched, StringComparison.OrdinalIgnoreCase);
                                if (idx != -1)
                                {
                                    Console.WriteLine(key1 + "-" + key2 + "-" + key3 + "-" + key4 + " = " + msg);
                                    long longkey1 = key1;
                                    long longkey2 = key2;
                                    long longkey3 = key3;
                                    long longkey4 = key4;

                                    longkey1 <<= 24;
                                    longkey2 <<= 16;
                                    longkey3 <<= 8;

                                    Console.WriteLine("\n" + msg);
                                    Console.WriteLine("As chaves sao: " + "Chave 1: " + key1 + "  Chave 2: " + key2 + "  Chave 3: " + key3 + "  Chave 4: " + key4);
                                    Console.WriteLine("Composição das chaves: " + (longkey1 + longkey2 + longkey3 + longkey4));
                                    Console.ReadKey();
                                }
                                else
                                { Console.WriteLine(key1 + "-" + key2 + "-" + key3 + "-" + key4 + " = " + msg); }
                            }
            }
        }
    }
}