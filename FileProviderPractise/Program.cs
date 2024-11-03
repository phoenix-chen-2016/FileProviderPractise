using System.Reflection;
using Microsoft.Extensions.FileProviders;

var fileProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());

using var fs = fileProvider.GetFileInfo("/Assets/data.txt")
	.CreateReadStream();
using var reader = new StreamReader(fs);

var text = reader.ReadToEnd();

Console.WriteLine(text);

Console.ReadKey(false);
