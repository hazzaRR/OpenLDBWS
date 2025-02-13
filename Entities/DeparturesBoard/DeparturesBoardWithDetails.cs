using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class DeparturesBoardWithDetails : BaseDeparturesBoard
{

    [XmlArray("departures")]
    [XmlArrayItem("destination")]
    public List<DepartureWithDetails> Departures { get; set; } = [];

}