// See https://aka.ms/new-console-template for more information
Console.WriteLine("EightBall Prediction Engine");

List<string> listOfFortunes = new() {
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes – definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again.",
                "Ask again later",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
            };

string input = "";
Random randomGenerator = new Random();
// we no longer need the 'true' statement
while (!input.ToUpper().Equals("STOP"))
{

    
    Console.Write("What is your question:\t");

    input = Console.ReadLine();
    if (!input.ToUpper().Equals("STOP"))
    {
        int questionNumber = randomGenerator.Next(0, listOfFortunes.Count);
        //Console.WriteLine($"Random number is: {questionNumber}");
        string prediction = listOfFortunes[questionNumber];
        Console.WriteLine($"You asked '{input}'\t\t : {prediction}");
    }

}
