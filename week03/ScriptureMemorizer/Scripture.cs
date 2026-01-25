/// <summary>
/// Represents a scripture with a reference and text composed of Word objects.
/// </summary>
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    /// <summary>
    /// Creates a new scripture with the given reference and text.
    /// </summary>
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    /// <summary>
    /// Hides a specified number of random words that are not already hidden.
    /// </summary>
    public void HideRandomWords(int numberToHide)
    {
        // Get list of indices for words that are not yet hidden
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        // Determine how many words we can actually hide
        int wordsToHide = Math.Min(numberToHide, visibleIndices.Count);

        // Randomly select and hide words
        Random random = new Random();
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(visibleIndices.Count);
            int wordIndex = visibleIndices[randomIndex];
            _words[wordIndex].Hide();
            visibleIndices.RemoveAt(randomIndex);
        }
    }

    /// <summary>
    /// Returns true if all words in the scripture are hidden.
    /// </summary>
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Returns the full display text including the reference and scripture text.
    /// </summary>
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string> wordTexts = new List<string>();

        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordTexts);
        return $"{referenceText} {scriptureText}";
    }
}
