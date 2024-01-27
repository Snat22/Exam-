namespace Task2;

public class Post
{
    public string Title {get; set;}
    public string Description {get; set;}
    public int LikeCount;
    public List<string> Comment = new List<string>();
    public bool IsPublushed;


    public void Publish()
    {
        if(IsPublushed == true)
        System.Console.WriteLine("The post is published.");
        else
        {
            System.Console.WriteLine("The post isn't published");
        }
    }
    public int Like()
    {
        return LikeCount+1;
    }
    // public List<> Coments(string messages)
    // {
    //     foreach (var com in Comments)
    //     {
            
    //     }
    // }

}
