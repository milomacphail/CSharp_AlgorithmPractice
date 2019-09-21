using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
                    var input = int.Parse(Console.ReadLine());
                        
                        for(int i =0; i < input; i++)
                        {
                            var individualWord = Console.ReadLine();

                            for(int j = 0; j < individualWord.Length; j++)
                            {
                                if(j % 2 == 0)
                                {
                                    Console.Write(individualWord[j]);
                                }
                            }
                                Console.Write(' ');

                                for(int j = 0; j < individualWord.Length; j++)
                                {
                                    if(j % 2 == 1)
                                    {
                                        Console.Write(individualWord[j]);
                                    }
                                }
                            Console.WriteLine();
                        }
          }
        }
