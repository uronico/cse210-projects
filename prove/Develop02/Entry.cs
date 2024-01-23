public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public void Display()
    {

    }

    public Entry(string prompt, string response, string date)
    {
        _promptText = prompt;
        _entryText = response;
        _date = date;
    }
}