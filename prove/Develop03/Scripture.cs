public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        var words = text.Split(' ');
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            var randomIndex = random.Next(_words.Count);
            while (_words[randomIndex].IsHidden())
            {
                randomIndex = random.Next(_words.Count);
            }
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.IsHidden());
    }
}