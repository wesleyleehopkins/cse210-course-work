
public class Scripture
{
    private Reference _reference;
    private string _text;
    
    private Words _words;
    public Scripture(Reference reference, string text)
    {
     _reference = reference;

     _text = text;  

     _words = new Words(_text.Split(' ').ToList()); 
    }

    public string GetReference()
    {
       
        return $"{_reference.GetBook()} {_reference.GetChapter()} {_reference.GetVerseStart()} {_reference.GetVerseEnd()}";
    }

    public string GetText()
    {
        return _text;
    }

    public string GetMaskedText()
    {
        return _words.GetMaskedText();
    }
    public void HideWords(int count)
    {
        _words.HideRandomWords(count);
    }
    public bool AllWordsHidden()
        {
            return _words.AllHidden();
        }
    
}