int len = 15; //RandomString Length
var rs = "abcdefghijklmnopqrstuvwxyz";
var result = "";

if(len <= 0)
{
    result = "min is 1";
}

for(var i = 0; i < len; i++)
{
    Random rand = new Random();

    result += rs[rand.Next(0, rs.Length)];
}

Console.WriteLine(result);
