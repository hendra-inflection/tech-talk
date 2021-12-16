var journal = new Journal();
journal.Add("My Journal #1");
journal.Add("My Journal #2");
journal.Add("My Journal #3");

var dbContext = new DbContext();
dbContext.SaveToDb(journal);

var logger = new Logger();
logger.WriteLog(journal);

public class Journal
{
	private List<string> _entries = new List<String>();

	public override string ToString()
	{
		return string.Join(", ", _entries);
	}

	public int Count
	{
		get { return _entries.Count;  }
	}

	public void Add(string entry)
	{
		_entries.Add(entry);
	}

}

public class DbContext
{
	public void SaveToDb(Journal journal)
	{
		// Dao/DbContext
		Console.WriteLine($"Save {journal.Count} records to database");
	}
}

public class Logger
{
	public void WriteLog(Journal journal)
	{
		// Logger
		Console.WriteLine($"Log: {journal}");
	}

}