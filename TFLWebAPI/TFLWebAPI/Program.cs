//Minimal Code Strategy

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

//setting up router for incomming requests received from client side
//web url request url  mapping

app.MapGet("/api/hello", () =>{  return "Welcome to Transflower Web World!";});  //get request received
app.MapGet("/api/about",()=>{return "Transflower Learning Pvt. Ltd.";});
app.MapGet("/api/courses",()=>{return "C, C++,C#";});
// app.MapGet("/api/Home/",()=>{return "THis is your home page";});

    app.MapGet("/api/Home/",()=>{
        List<int> tools= new List<int>{10,20,30};
        return tools;
        });
app.Run();  //Keep Web server listening for incomming HTTP Requests

//Event Drive Programming
// event raised------>attached event handler is  callbacked