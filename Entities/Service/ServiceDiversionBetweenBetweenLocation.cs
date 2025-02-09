using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class ServiceDiversionBetweenBetweenLocation
{
    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("Value")]
    public string Value { get; set; } = "";

}