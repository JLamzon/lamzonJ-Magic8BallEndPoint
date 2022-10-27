//Jessie Lamzon
//10/27/22
//Magic 8 Ball
//webapi application that has endpoints configured to complete Mini Challenge
//Peer review:


using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_Magic8BallEndPoint.Controllers;

[ApiController]
[Route("[controller]")]

public class Magic8BallController : ControllerBase
{
    //string array that contains quotes for magic 8 ball
    string[] quotes = new string[] {"magic ball answers: better not tell you now.", "magicball affirms: Without a doubt.", "magic eight ball maintains: Yes definitely.", "magic 8 ball answers: Outlook good.", "magic eight ball maintains: As I see it, Yes.", "magic ball answers: You may rely on it.", "magicball affirms: Very doubtful.", "magicball affirms: Reply hazy, try again.", "mystic eight ball says: Signs, point to yes.", "magic 8 ball answers: Outlook not so good.", "mystic eight ball said: Outlook not so good."};

    int index = 0;
    Random rand = new Random();

    [HttpGet]
    [Route("Magic/{userInput}")]

    public string answers(string userInput)
    {
        index = rand.Next(quotes.Length);
        string result = quotes[index];
        return result;
    }

}
