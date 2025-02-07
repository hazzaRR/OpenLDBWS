using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class Departure
{
    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("service")]
    public List<Service> Service { get; set;} = [];
}