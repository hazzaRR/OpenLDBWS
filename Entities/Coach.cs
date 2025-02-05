using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class Coach
{
    [XmlAttribute("number")]
    public string Number { get; set; }

    [XmlElement("coachClass")]
    public string CoachClass { get; set; }

    [XmlElement("toilet")]
    public string Toilet { get; set; }
}