using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class DeparturesBoard : BaseDeparturesBoard
{

    [XmlArray("departures")]
    [XmlArrayItem("departure")]
    public List<Departure> Departures { get; set; } = [];

}