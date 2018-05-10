// #! "netcoreapp2.0"
// #r "nuget:NetStandard.Library,2.0"
#r "nuget:Newtonsoft.Json,11.0.2 "

using Newtonsoft.Json;

class Data
{
    public int X { set; get; }
    public int Y { set; get; }
    public int Z { set; get; }
}

var json = JsonConvert.SerializeObject(new Data());
Console.WriteLine(json);
