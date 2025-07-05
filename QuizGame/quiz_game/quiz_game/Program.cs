using System.IO;

string[] text = File.ReadAllLines("questions.txt");

List<string> questions = new List<string>();  
List<string> answers = new List<string>();

for (int i = 0; i < text.Length; i++)
{
    if( i % 4 == 0)
    
        questions.Add(text[i]);
    else
 
        answers.Add(text[i]);   
}
int questionsIndex = 0;
int answersIndex = 0;
int scores = 0;

while(questionsIndex < questions.Count)
{
    Console.WriteLine(questions[questionsIndex]);
    questionsIndex++;

    int correctAnswerIndex = 0; 
    for (int i = 0; i < 3; i++)
    {
        if (answers[answersIndex].StartsWith(">"))
            correctAnswerIndex = i + 1;

        Console.WriteLine(i + 1 + "." + answers[answersIndex].Replace(">", ""));
        answersIndex++;
    }
     int answer = int.Parse(Console.ReadLine());
    if(answer == correctAnswerIndex)
    {
        Console.WriteLine("Correct!");
        scores++;
    }
    else
    {
        Console.WriteLine("Incorrect");
    }
    Console.WriteLine("End of the Quiz! Your score was " + scores + " Points!");
    Console.ReadKey();
}