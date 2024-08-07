namespace SoloLearnExercises.Exercise;
public class StringMethod
{
    string[] words =
    {
            "home",
            "programming",
            "victory",
            "C#",
            "football",
            "sport",
            "book",
            "learn",
            "dream",
            "fun"
        };

    int count = 0;

    public void OutputWords()
    {
        Console.WriteLine("Type a letter");
        string letter = Console.ReadLine();

        foreach (string item in words)
        {
            if (item.Contains(letter))
            {
                Console.WriteLine(item);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No match");
        }
    }
}
