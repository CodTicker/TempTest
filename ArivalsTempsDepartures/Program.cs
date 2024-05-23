
using ArivalsTempsDepartures;

// NOTE Console readlines are there just to show the result

Console.WriteLine("Hello, World!");

var api = new API();

// assignment one get loweest temp
Console.WriteLine("lowest temp is {0}", GetLowestTemperature());

// assignment two get the people who experienced the lowest temperature
var names = PeopleWhoExperiencedTheLowestTemp();


Console.WriteLine("people who experienced the lowest temp");
foreach (var name in names)
{
    Console.WriteLine(name);
}

// assignment 3 get the all the people and their coldest day

var people = GetPeopleData();

foreach (var p in people)
{
    Console.WriteLine(p);
}

Console.Read();

int GetLowestTemperature()
{
    var teperatures = api.GetDepartures();

    var lowest = teperatures.Min(x => x.Value);

    return lowest;
}

Dictionary<string, int> GetPeopleData()
{
    var arrivals = api.GetArrivals();
    var departures = api.GetDepartures();

    var peopleAndTemps = arrivals.Concat(departures)
                        .GroupBy(x => x.Key)
                       .ToDictionary(x => x.Key, x => x.Min(cc => cc.Value));

    if (peopleAndTemps.Count == 0)
        return new Dictionary<string,int>();

    return peopleAndTemps;
}

List<string> PeopleWhoExperiencedTheLowestTemp()
{

    var lowestTemp = GetLowestTemperature();

    var arrivals = api.GetArrivals();
    var departures = api.GetDepartures();

    var peopleAndTemps = GetPeopleData();

    if(peopleAndTemps.Count != 0)
    {
        var lowestExposure = peopleAndTemps.Where(c => c.Value == lowestTemp).Select(x => x.Key).ToList();

        if (lowestExposure.Count == 0)
            return new List<string>();

        return lowestExposure;
    }

    return new List<string>();

}

