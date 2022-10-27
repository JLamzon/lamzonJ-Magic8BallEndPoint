using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_Magic8BallEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    string[] quotes = new string[] {"magic ball answers Better not tell you now.", "magicball affirms Without a doubt.", "magic eight ball maintains Yes definitely.", "magic 8 ball answers Outlook good.", "magic eight ball maintains As I see it, Yes.", "magic ball answers You may rely on it.", "magicball affirms Very doubtful.", "magicball affirms Reply hazy, try again.", "mystic eight ball said Signs point to yes.", "magic 8 ball answers Outlook not so good.", "mystic eight ball said Outlook not so good."};

    int index = 0;
    Random rand = new Random();

    [HttpGet]
    [Route("Magic")]

    public string answers(string userInput)
    {
        index = rand.Next(quotes.Length);
        string result = quotes[index];

        return result;
    }

}
