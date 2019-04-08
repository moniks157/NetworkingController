using DarkRift;

class AnswerMessage : IDarkRiftSerializable
{
    #region Properties
    public int networkID { get; set; }
    public int chosenAnswer { get; set; }
    #endregion

    public void Deserialize(DeserializeEvent e)
    {
        networkID = e.Reader.ReadInt32();
        chosenAnswer = e.Reader.ReadInt32();
    }

    public void Serialize(SerializeEvent e)
    {
        e.Writer.Write(networkID);
        e.Writer.Write(chosenAnswer);
    }
}

