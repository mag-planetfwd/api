using Microsoft.AspNetCore.Mvc;
using Postgrest.Responses;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]    
    public async Task<IEnumerable<Test>> Get()
    {
        var client = new Supabase.Client("https://ymslwfbwjehfifxturei.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Inltc2x3ZmJ3amVoZmlmeHR1cmVpIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODAzMDQxOTMsImV4cCI6MTk5NTg4MDE5M30.Xwlun_ySomyoKIF1HgCzHal1tr09e6WsvNY6IQEzTB4");
        await client.InitializeAsync();
        ModeledResponse<TestModel> response = await client.From<TestModel>()
            .Get();
        return response.Models.Select(m=>m.AsTest());
    }
}
