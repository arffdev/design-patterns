namespace ObjectPoolPattern.RandomObjects
{
  public class MessageObject
  {
    private string _message;

    public MessageObject()
    {
      _message = "This is a default message";
    }

    public MessageObject(string message)
    {
      _message = message;
    }

    public string Get()
    {
      return _message;
    }
  }
}
