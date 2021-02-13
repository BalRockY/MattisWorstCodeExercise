using System;

namespace WorstCodeExercise
{
    class Program
    {
        static void Main(string[] args)
                                                                                     {
                                                 int one;                  int two;

            Console.
    WriteLine
                                                                        ("Choose a number");
            one 
                                        =
      Convert
                                                        .
                     ToInt32(
          Console               .                                       ReadLine()
          
          
          
          
          );

            Console.
                
                
                
                WriteLine                                                                      ("Choose another number");
            
            
            two                         =                       Convert                     
                
                
                
                .
                              
                
                ToInt32                                 (Console.ReadLine()
                
                
                
                );

                                                                                                          if 
            (one != two)
                                             {
                Console                                 .
                    
                    WriteLine
                                                    ($"your result: {one} + {two} = " + (one + two));
                                                                                                 }
            else
                                                                                                            {
                Console.                                WriteLine
                    
                    ($"your result: = " + ((one + two) * 3)
                    
                    
                    
                                                                                                    );
                                                                                                             }

            
        }
    }
}
