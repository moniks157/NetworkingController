using DarkRift;

class QuestionMessageModel : IDarkRiftSerializable
{
    #region Properties
    public int networkID { get; set; }

    public string answerA { get; set; }
    public string answerB { get; set; }
    public string answerC { get; set; }
    public string answerD { get; set; }

    #endregion

    public void Deserialize(DeserializeEvent e)
    {
        networkID = e.Reader.ReadInt32();
        answerA = e.Reader.ReadString();
        answerB = e.Reader.ReadString();
        answerC = e.Reader.ReadString();
        answerD = e.Reader.ReadString();
    }

    public void Serialize(SerializeEvent e)
    {
        e.Writer.Write(networkID);
        e.Writer.Write(answerA);
        e.Writer.Write(answerB);
        e.Writer.Write(answerC);
        e.Writer.Write(answerD);
    }
}