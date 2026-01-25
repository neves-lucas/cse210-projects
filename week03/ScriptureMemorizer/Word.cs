/// <summary>
/// Represents a single word in the scripture that can be hidden or shown.
/// </summary>
public class Word
{
    private string _text;
    private bool _isHidden;

    /// <summary>
    /// Creates a new word with the given text.
    /// </summary>
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /// <summary>
    /// Hides the word by marking it as hidden.
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Returns whether the word is currently hidden.
    /// </summary>
    public bool IsHidden()
    {
        return _isHidden;
    }

    /// <summary>
    /// Returns the display text: the actual word if visible, or underscores if hidden.
    /// The number of underscores matches the number of letters in the word.
    /// </summary>
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}
