namespace SixMinAPI.Test;

using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;

public class CommandsServiceTests
{

  [Test]
  public void Test1()
  {
    Assert.Pass();
  }

  // [Test]
  // public async Task GetAllCommands_ReturnsArrayOfObjects()
  // {
  //   await using var application = new WebApplicationFactory<Program>();
  //   using var client = application.CreateClient();

  //   var response = await client.GetAsync("/api/v1/commands");

  //   Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
  // }
}