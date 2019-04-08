using DarkRift;

public class MyMessageContent : IDarkRiftSerializable
{
    //Data to send within the message
    public string myName;
    public int myAge;
    
    //Constructor (can be empty)
    public MyMessageContent()
    { }
    
    #region Interface implementation IDarkRiftSerializable
    
    //Used by the DarkRift reader
    public void Deserialize(DeserializeEvent e)
    {
        myName = e.Reader.ReadString();
        myAge = e.Reader.ReadInt32();
    }
    
    //Used by the DarkRift writer
    public void Serialize(SerializeEvent e)
    {
        e.Writer.Write(myName);
        e.Writer.Write(myAge);
    }
    #endregion
}
