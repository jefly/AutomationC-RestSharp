using Allure.NUnit;
using Allure.NUnit.Attributes;
using AmusedAutomation.config;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using NUnit.Framework;
using System.Net;

[TestFixture]
[AllureNUnit]
public class ApiTest
{
    private RestClientHelper _client;
    
    [SetUp]
    public void Setup()
    {   
        _client = new RestClientHelper("https://api.restful-api.dev/");
    }

    [AllureSuite("API Tests")]
    [AllureTest("Get All Objects")]
    [Test]
    public void TestGetAllObjects()
    {
        var response = _client.SendRequest(RestSharp.Method.Get, "/objects");        
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }
   
    [AllureSuite("API Tests")]
    [AllureTest("Add Object")]
    [Test]
    public void TestAddObject()
    {
        var newObject = new ObjectModel()
        {            
            Name = "Apple MacBook Pro 16",
            Data = new ObjectModelData() { Year = 2019, Price = 1849.99F, CPUModel = "Intel Core i9", HardDiskSize = "1 TB" }
        };
        var response = _client.SendRequest(RestSharp.Method.Post, "/objects", newObject);
       
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);        
    }

    [AllureSuite("API Tests")]
    [AllureTest("Get a single Object")]
    [Test]
    public void TestGetSingleObject()
    {   
        var postResponse = _client.SendRequest(RestSharp.Method.Get, "/objects/7");       

        Assert.AreEqual(HttpStatusCode.OK, postResponse.StatusCode);
    }

    [AllureSuite("API Tests")]
    [AllureTest("Update an Object")]
    [Test]
    public void TestUpdateObject()
    {
        var newObject = new ObjectModel()
        {
            Name = "Apple MacBook Pro 16",
            Data = new ObjectModelData() { Year = 2019, Price = 1849.99F, CPUModel = "Intel Core i9", HardDiskSize = "1 TB" }
        };
        var responseAdd = _client.SendRequest(RestSharp.Method.Post, "/objects", newObject);
        var responseBodyAdd = _client.DeserializeResponse<ObjectModel>(responseAdd);

        var putResponse = _client.SendRequest(RestSharp.Method.Put, $"/objects/{responseBodyAdd!.Id}", newObject);
        
        Assert.AreEqual(HttpStatusCode.OK, putResponse.StatusCode);
    }

    [AllureSuite("API Tests")]
    [AllureTest("Delete an Object")]
    [Test]
    public void TestDeleteObject()
    {
        // adding a new object
        var newObject = new ObjectModel()
        {
            Name = "Apple MacBook Pro 16",
            Data = new ObjectModelData() { Year = 2019, Price = 1849.99F, CPUModel = "Intel Core i9", HardDiskSize = "1 TB" }
        };
        var responseAdd = _client.SendRequest(RestSharp.Method.Post, "/objects", newObject);

        var responseBodyAdd = _client.DeserializeResponse<ObjectModel>(responseAdd);
        //

        // deleting the object
        var postResponse = _client.SendRequest(RestSharp.Method.Delete, $"/objects/{responseBodyAdd!.Id}");
        
        Assert.AreEqual(HttpStatusCode.OK, postResponse.StatusCode);
    }   
}

internal class AllureTestAttribute : Attribute
{
    private string v;

    public AllureTestAttribute(string v)
    {
        this.v = v;
    }
}
