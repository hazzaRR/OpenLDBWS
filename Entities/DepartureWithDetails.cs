using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class DepartureWithDetails
{
    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("service")]
    public List<ServiceWithCallingPoints> Service { get; set;} = [];
}