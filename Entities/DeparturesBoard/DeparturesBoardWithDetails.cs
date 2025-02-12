using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class DeparturesBoardWithDetails : BaseDeparturesBoard
{

    [XmlArray("departures")]
    [XmlArrayItem("departure")]
    public List<DepartureWithDetails> Departures { get; set; } = [];

}