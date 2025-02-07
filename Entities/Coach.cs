using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class Coach
{
    [XmlAttribute("number")]
    public string? Number { get; set; }

    [XmlElement("coachClass")]
    public string? CoachClass { get; set; }

    [XmlElement("loading")]
    public int? Loading { get; set; }

    [XmlElement("loadingSpecified")]
    public bool? LoadingSpecified { get; set; }

    [XmlElement("toilet")]
    public ToiletAvailability? Toilet { get; set; }
}