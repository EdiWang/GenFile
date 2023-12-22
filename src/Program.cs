using System.CommandLine;

namespace GenFile;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var rootCommand = BuildCommand();
        await rootCommand.InvokeAsync(args);
    }

    public static RootCommand BuildCommand()
    {
        var directoryOption = new Option<string>(
            aliases: ["--directory", "-d"],
            getDefaultValue: () => ".",
            description: "Output directory.");

        var filenameOption = new Option<string>(
            aliases: ["--filename", "-f"],
            getDefaultValue: () => "testfile.dat",
            description: "Output filename.");

        var sizeOption = new Option<string>(
            aliases: ["--size", "-s"],
            getDefaultValue: () => "251MB",
            description: "Output file size (B, KB, MB, GB). e.g. 996MB");

        var rootCommand = new RootCommand("Generate test file at given size");
        rootCommand.AddOption(directoryOption);
        rootCommand.AddOption(filenameOption);
        rootCommand.AddOption(sizeOption);
        rootCommand.SetHandler(async (directory, filename, size) =>
        {
            var generator = new FileGenerator(directory, filename, size);
            await generator.Generate();
        }, directoryOption, filenameOption, sizeOption);

        return rootCommand;
    }
}