var builder = WebApplication.CreateBuilder(args);

#region IOC Container



#endregion


var app = builder.Build();


#region Request Pipeline

app.MapGet("/", () => "Hello World!");

#endregion

app.Run();
