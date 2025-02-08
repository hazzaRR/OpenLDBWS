using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class DeparturesBoardWithDetails : BaseDeparturesBoard
{

    [XmlArray("departures")]
    [XmlArrayItem("departure")]
    public List<DepartureWithCallingPoints> Departures { get; set; } = [];

}