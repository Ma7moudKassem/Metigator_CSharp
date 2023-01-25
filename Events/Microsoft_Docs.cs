namespace Events;

public class SampleEventArgs
{
    public string Text { get; }
    public SampleEventArgs(string text) { Text = text; }
}
