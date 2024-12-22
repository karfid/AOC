//part 1

var input = File.ReadAllLines("../../../../../input.txt").Select(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToList();
var a = new List<int>();
var b = new List<int>();
foreach (var line in input)
{
    a.Add(int.Parse(line[0]));
    b.Add(int.Parse(line[1]));
}

a.Sort();
b.Sort();

int sum = 0;

for (int i = 0; i < a.Count; i++)
{
    sum += Math.Abs((a[i] -b[i]));
}

Console.WriteLine(sum);

//part2

Dictionary<int,int> list = new Dictionary<int, int>();
var sum2 = 0;

for (int i = 0;i < b.Count;i++)
{
    if (!list.ContainsKey(b[i]))
        {
        list[b[i]] = 1; 
    }
    else
    {
        list[b[i]]++;
    }
}
for (int i = 0;i<a.Count;i++)
{
    if (list.TryGetValue(a[i], out var val))
    {
        sum2 += a[i] * list[a[i]];
    }
}

Console.WriteLine(sum2);

