using System;

public class Lecture : Event

{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }

     public string CreateLecture()
    {
        string detailed = CreateStandard() + "\n";

        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Capacity: " + _capacity;
        return detailed;
    }

    public string CreateShortLecture()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();

        shortLecture += "Type: " + eventType + "\n";
        shortLecture += CreateShort();
        return shortLecture;
    }
}