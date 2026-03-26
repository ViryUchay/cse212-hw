using System.Text.Json;

public static class SetsAndMaps
{
    // ✅ PROBLEM 1: FindPairs
    public static string[] FindPairs(string[] words)
    {
        HashSet<string> set = new HashSet<string>(words);
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            string reversed = new string(word.Reverse().ToArray());

            if (word != reversed && set.Contains(word) && set.Contains(reversed))
            {
                result.Add($"{word} & {reversed}");
                set.Remove(word);
                set.Remove(reversed);
            }
        }

        return result.ToArray();
    }

    // ✅ PROBLEM 2: SummarizeDegrees
    public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        Dictionary<string, int> degrees = new Dictionary<string, int>();

        foreach (string line in File.ReadLines(filename))
        {
            string[] parts = line.Split(',');

            if (parts.Length >= 4)
            {
                string degree = parts[3].Trim();

                if (degrees.ContainsKey(degree))
                    degrees[degree]++;
                else
                    degrees[degree] = 1;
            }
        }

        return degrees;
    }

    // ✅ PROBLEM 3: IsAnagram
    public static bool IsAnagram(string word1, string word2)
    {
        word1 = word1.Replace(" ", "").ToLower();
        word2 = word2.Replace(" ", "").ToLower();

        if (word1.Length != word2.Length)
            return false;

        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char c in word1)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        foreach (char c in word2)
        {
            if (!counts.ContainsKey(c))
                return false;

            counts[c]--;

            if (counts[c] < 0)
                return false;
        }

        return true;
    }

    // ✅ PROBLEM 5: EarthquakeDailySummary
    public static string[] EarthquakeDailySummary()
    {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";

        using var client = new HttpClient();
        var json = client.GetStringAsync(uri).Result;

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var data = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        List<string> result = new List<string>();

        if (data?.Features != null)
        {
            foreach (var feature in data.Features)
            {
                string place = feature.Properties?.Place ?? "Unknown location";
                double mag = feature.Properties?.Mag ?? 0;

                result.Add($"{place} - Mag {mag}");
            }
        }

        return result.ToArray();
    }
}