// See https://aka.ms/new-console-template for more information
class Example
{
	private int _count {get; set;}
	public int Count
	{
		get
		{
			return _count;
		}
		set
		{
			_count = value;
		}
	}

	private string _words {get; set;}
	public string Words
	{
		get
		{
			return _words;
		}
		set
		{
			_words = value;
		}
	}


	public Example(int count, string words)
	{
		_count = count;
		_words = words;
	}
}

class ExampleTransmogrifier
{
	public void IncrementCount(Example example)
	{
		++example.Count;
		Console.WriteLine("Count is now " + example.Count);
	}
	public void AppendToString(Example example, string AppendMe)
	{
		example.Words = example.Words + AppendMe;
		Console.WriteLine("Words is now " + example.Words);
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("Making new Example class");
		var example = new Example(1, "hi there");
		Console.WriteLine("example.Count is " + example.Count);
		Console.WriteLine("example.Words is " + example.Words);
		Console.WriteLine();
		
		ExampleTransmogrifier et = new ExampleTransmogrifier();
		
		et.IncrementCount(example);
		et.AppendToString(example, ", my name is tinkerbell");
		
		Console.WriteLine();

		Console.WriteLine("example.Count is " + example.Count);
		Console.WriteLine("example.Words is " + example.Words);
	}
}
