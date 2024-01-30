using System;
using System.Collections.Generic;
using System.IO;


public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

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