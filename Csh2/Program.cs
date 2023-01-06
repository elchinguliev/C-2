namespace Milyonchu
{
    class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Enter your fullname for registration : ");
            string fullname=Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Dear "+ fullname+" you are welcome, we can start our game ,please click 'Enter' button for starting our game !!!");
            Console.ReadLine();
            Console.Clear();

            int trueAnswers = 0;
            int falseAnswers = 0;
            double totalScore = 0;
            Console.ForegroundColor = ConsoleColor.White;
            string[] questions = { "What is the capital of Azerbaijan ?" , "Who is the president of Azerbaijan ? " , "What is the date of independecny of Azerbiajan ?" , "What is the second largest city of Azerbiajan ? ", "What is the population of Azerbaijan ?","What is the name of the biggest lake in the world ? ","What is the best football club in the world ? ","Who is the best football player in the world ? " };
            string[] answers = { "A)Baku\nB)Paris\nC)Rome\n", "A)Jo Bayden\nB)Recep Tayip Erdogan\nC)Ilham Aliyev", "A)2003\nB)1992\nC)1918", "A)Sheki\nB)Gandja\nC)Lankaran","A)9 million\nB)8 million\nC)10 million","A)Caspian\nB)Baikal\nC)Superior","A)Real Madrid\nB)Barcelona\nC)Fenerbahce ","A)Cristiano Ronaldo\nB)Neymar Junior\nC)Leonel Messi" };
            //string[] trueAnswers = { "A", "C", "C", "B", "C" };
            Console.WriteLine(questions[0]);
            Console.WriteLine(answers[0]);
            Console.WriteLine("Enter your answer : ");
            string answer0=Console.ReadLine();
            if (answer0=="A")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[1]);
            Console.WriteLine(answers[1]);
            Console.WriteLine("Enter your answer : ");
            string answer1 = Console.ReadLine();
            if (answer1=="C")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[2]);
            Console.WriteLine(answers[2]);
            Console.WriteLine("Enter your answer : ");
            string answer2 = Console.ReadLine();
            if (answer2=="C")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();






            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[3]);
            Console.WriteLine(answers[3]);
            Console.WriteLine("Enter your answer : ");
            string answer3 = Console.ReadLine();
            if (answer3=="B")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();





            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[4]);
            Console.WriteLine(answers[4]);
            Console.WriteLine("Enter your answer : ");
            string answer4 = Console.ReadLine();
            if (answer4=="C")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[5]);
            Console.WriteLine(answers[5]);
            Console.WriteLine("Enter your answer : ");
            string answer5 = Console.ReadLine();
            if (answer5=="A")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[6]);
            Console.WriteLine(answers[6]);
            Console.WriteLine("Enter your answer : ");
            string answer6 = Console.ReadLine();
            if (answer6=="B")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(questions[7]);
            Console.WriteLine(answers[7]);
            Console.WriteLine("Enter your answer : ");
            string answer7 = Console.ReadLine();
            if (answer7=="C")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("True ");
                totalScore+=10;
                trueAnswers++;
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("False ");
                totalScore-=10;
                falseAnswers++;
                if (totalScore<0)
                {
                    totalScore=0;
                }
                Console.Write("Your score is :");
                Console.Write(totalScore);
            }
            Console.ReadLine();
            Console.Clear();




            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Count of true/false answers is as following : ");
            Console.WriteLine("Count of true answers  : "+trueAnswers);
            Console.WriteLine("Count of false answers  : "+falseAnswers);
            Console.WriteLine("You Finished the Game !!!");



        }


    }

}