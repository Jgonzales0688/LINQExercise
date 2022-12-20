

using System.Collections.Generic;

List<string> gameName = new List<string>();

gameName.Add("Spyro");
gameName.Add("Halo");
gameName.Add("Lost in Random");
gameName.Add("Super Mario");
gameName.Add("Fortnite");
gameName.Add("Crash Bandicoot");

gameName.OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine(x)); 

