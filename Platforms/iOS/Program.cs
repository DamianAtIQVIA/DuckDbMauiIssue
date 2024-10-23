//using ObjCRuntime;
using ObjCRuntime;
using UIKit;

namespace DuckDbMauiIssue;

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		Console.WriteLine("============");
		LoadLibrary("libxamarin-dotnet-debug.dylib");
		LoadLibrary("libduckdb.dylib");
		Console.WriteLine("============");

		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		UIApplication.Main(args, null, typeof(AppDelegate));
	}

	static void LoadLibrary(string path)
	{
		bool exists = File.Exists(path);
		nint handle = Dlfcn.dlopen(path, Dlfcn.Mode.Global);
		Console.WriteLine($@"Lib: {path}
	Exists: {exists}
	Handle: {handle}
		");
	}
}
