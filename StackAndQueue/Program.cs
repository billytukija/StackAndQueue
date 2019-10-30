using System;
using System.Collections.Generic;
using System.IO;

namespace StackAndQueue
{
    public class Reception
    {
        public string MotPasse { get; set; }
        public string Departement { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var infosReception = new List<Reception>
            {
                new Reception {
                    MotPasse= "3", Departement = "Info"
                },
                new Reception {
                    MotPasse= "1", Departement = "Chimie"
                },
                new Reception {
                    MotPasse= "2", Departement = "Math"
                }
            };

            Console.WriteLine("------------STACK-----------");
           

            var stack = new Stack<Reception>();

            infosReception.ForEach(x =>
            {
                stack.Push(x);
            });


            
            Console.WriteLine(stack.Count);

            // Pop lit et retire
            var usingPop = stack.Pop();
            Console.WriteLine(usingPop.Departement);

            // Peek Retire sans lire
            var usingPeek = stack.Peek();
            Console.WriteLine(usingPeek.Departement);
            Console.WriteLine(stack.Count);

            Console.WriteLine("------------END STACK-----------");

            Console.WriteLine("------------QUEUE-----------");

            var queues = new Queue<Reception>();

            infosReception.ForEach(x =>
            {
                queues.Enqueue(x);
            });

            Console.WriteLine(queues.Count);

            Console.WriteLine("Lista de mot de passe");

            foreach (var item in queues)
            {
                Console.WriteLine(item.MotPasse + " - " + item.Departement);
            }


            while (queues.Count > 0)
            {
                Console.WriteLine("Appuyez n'importe quelle touche pout appeler le prochain mot de passe");
                Console.ReadKey();
                Console.WriteLine("Vous avez appeler: " + queues.Dequeue().Departement);
            }

            Console.WriteLine("------------END QUEUE-----------");
        }
        
    }
}
