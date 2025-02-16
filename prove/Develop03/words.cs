using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Words
{
    private class Word
    {
        public string Text { get; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public string GetDisplayText()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }

    private List<Word> _words;
    private Random _random;

    public Words(List<string> words)
    {
        _words = new List<Word>();
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
        _random = new Random();
    }

public void HideRandomWords(int count)
{
    List<Word> visibleWords = _words.FindAll(w => !w.IsHidden);

    for (int i = 0; i < count && visibleWords.Count > 0; i++)
    {
        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide();
    }
}


    public bool AllHidden()
    {
        return _words.TrueForAll(w => w.IsHidden);
    }

    public string GetMaskedText()
    {
        return string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
    }
}
