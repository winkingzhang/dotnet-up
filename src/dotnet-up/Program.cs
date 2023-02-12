using System.Reflection;

if (args.Length == 0)
{
    var versionString = Assembly.GetEntryAssembly()?
        .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
        .InformationalVersion;
    Console.WriteLine($"up v{versionString}");
    Console.WriteLine("--------------------");
    Console.WriteLine("Usage: ");
    Console.WriteLine("  up <command>");
    return;
}

Console.WriteLine("Show something here..");
