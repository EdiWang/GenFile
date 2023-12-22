namespace GenFile;

public class FileGenerator(string directory, string filename, string sizeStr)
{
    public async Task Generate()
    {
        Console.WriteLine($"Generating '{filename}' at '{directory}' with size '{sizeStr}'...");

        var path = Path.Combine(directory, filename);
        var size = ParseSize(sizeStr);
        var buffer = new byte[1024 * 1024];
        var random = new Random();
        await using var stream = File.OpenWrite(path);
        while (stream.Length < size)
        {
            random.NextBytes(buffer);
            await stream.WriteAsync(buffer);
        }

        Console.WriteLine("File generated.");
    }

    private static long ParseSize(string size)
    {
        var unit = size[^2..].ToUpper();
        var value = long.Parse(size[..^2]);
        return unit switch
        {
            "B" => value,
            "KB" => value * 1024,
            "MB" => value * 1024 * 1024,
            "GB" => value * 1024 * 1024 * 1024,
            _ => throw new ArgumentException("Invalid size unit")
        };
    }
}