#nullable disable
Console.Clear();
// 1
List<string> jonth = new List<string>{"January", "June", "July"};

Console.WriteLine(String.Join(", ", jonth));

// 2
List<string> sevenHundo = new List<string>{};

for (int n = 0; n <= 700; n++) {
    sevenHundo.Add("joy");
}

Console.WriteLine(String.Join(", ", sevenHundo));

// 3
List<int> fiveHundo = new List<int>{};

for (int n = 0; n <= 500; n++) {
    fiveHundo.Add(7);
}

Console.WriteLine(String.Join(", ", fiveHundo));

// 4
List<int> randoFiveBands = new List<int>{};
Random rnd = new Random();
for (int n = 0; n < 5000; n++) {
    randoFiveBands.Add(rnd.Next(0, 100));
}

Console.WriteLine(String.Join(", ", randoFiveBands));

// 5
List<int> randoThreeHundo = new List<int>{};
//Random rnd = new Random();
for (int n = 0; n < 300; n++) {
    randoThreeHundo.Add(rnd.Next(0, 40));
}

Console.WriteLine(String.Join(", ", randoThreeHundo));

// 6
List<int> multiples = new List<int>{};

for (int n = 20; n <= 800; n+= 4) {
    multiples.Add(n);
}

Console.WriteLine(String.Join(", ", multiples));

// 7
List<int> even = new List<int>{};
for (int n = 100; n >= 10; n-= 2) {
    even.Add(n);
}

Console.WriteLine(String.Join(", ", even));

// 8
string colorsStr = "red,orange,yellow,green,blue,indigo,violet";

List<string> colors = colorsStr.Split(",").ToList();

Console.WriteLine(String.Join(", ", colors));

// 9
string citiesStr = "Edmonton;Calgary;Vancouver;Saskatoon;Winnipeg";

List<string> cities = citiesStr.Split(";").ToList();

Console.WriteLine(String.Join(", ", cities));

// 10
List<string> names = new List<string>{};

bool loop = true;

while (loop) {
    Console.WriteLine("Enter a Name to add or 'done' to finish");
    string response = Console.ReadLine();
    if (response == "done") {
        loop = false;
    } else {
        names.Add(response);
    }
}

Console.WriteLine(String.Join(", ", names));