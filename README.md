# Utilities for C#

A small library of helper functions for CLI applications that I extracted from my [Fallin](https://github.com/UnLuckyNikolay/fallin) project.

## Contents

* Shuffle.cs
    * function `Shuffle<T>(T[] array)`

		Uses [Fisher–Yates shuffle](https://en.wikipedia.org/wiki/Fisher–Yates_shuffle	) to achieve time complexity of O(n).
* ConsoleHelper.cs
	* enum `Color`

		Lists all the possible colors and color schemes that can be used for WriteColored(). 

		Colors: White (default), DarkGray, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, Blue, Green, Cyan, Red, Magenta, Yellow.

		Color schemes: Pride (cycles through the rainbow colors with each character) 

	* function `GetColorEnum(string color)`

		Returns Color enum, defaults to White if no color is found.

	* function `WriteColored(string text, Color colorEnum)`

		Writes colored text (without a new line at the end).

	* function `WriteColored(string text, string color)`

		Overload that uses GetColorEnum() to find a suitable color.

	* function `Dots(int dotDuration=800, int dotsAmount=3)`

		Writes dots at selected intervals to simulate a pause. Creates a new line after the last dot. Usually used after certain actions before the screen is cleared and information is rewritten to give user time to read the results. 

## Installation

1. Install [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) 8.0 or higher.

2. Navigate to your repo.

3. Add the library as a submodule:

	```bash
	git submodule add https://github.com/UnLuckyNikolay/utilities-c-sharp
	```

4. Import the whole library with a `using` statement at the start of the file:

	```csharp
	using Utilities;
	```

	or import certain files (preferred, makes commands shorter):

	```csharp
	using static Utilities.*file_name*;
	```

## Updating

1. Navigate to your repo.

2. Run the update command:

	```bash
	git submodule update --remote
	```

## Usage Examples

* `Shuffle` example:

	Code:

	```csharp
	using static Utilities.ShuffleUtilities;

	namespace UtilitiesShowcase
	{
		internal class Program
		{
			static void Main(string[] args)
			{
				int[] numArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
				Console.Write("Current array: ");
				foreach (int num in numArray) {
					Console.Write("{0} ", num);   
				}
				Console.WriteLine();

				Shuffle(numArray);
				Console.WriteLine("Shuffling the array");

				Console.Write("Current array: ");
				foreach (int num in numArray) {
					Console.Write("{0} ", num);   
				}
				Console.WriteLine();
			}
		}
	}
	```

	Result:

	![Shuffle Showcase](https://imgur.com/twKltPk.png)

* `WriteColored` example:

	Code:

	```csharp
	using static Utilities.ConsoleHelper;

	namespace UtilitiesShowcase
	{
		internal class Program
		{
			static void Main(string[] args)
			{
				Console.WriteLine("Writing in Red");
				WriteColored("We're no strangers to love", Color.Red);
				Console.WriteLine();
				Console.WriteLine("Writing in DarkCyan");
				WriteColored("You know the rules and so do I", Color.DarkCyan);
				Console.WriteLine();
				Console.WriteLine("Writing in DarkYellow");
				WriteColored("A full commitment's what I'm thinking of", Color.DarkYellow);
				Console.WriteLine();
				Console.WriteLine("Writing in Magenta");
				WriteColored("You wouldn't get this from any other guy", Color.Magenta);
				Console.WriteLine();
				Console.WriteLine("Writing in DarkGray");
				WriteColored("I just wanna tell you how I'm feeling", Color.DarkGray);
				Console.WriteLine();
				Console.WriteLine("Writing in Pride");
				WriteColored("Gotta make you understand", Color.Pride);
				Console.WriteLine();
			}
		}
	}
	```

	Result:

	![WriteColored Showcase](https://imgur.com/e3PM7it.png)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.