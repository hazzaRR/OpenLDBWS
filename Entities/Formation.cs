using System.Xml.Serialization;
namespace TrainDepartureBoard.Entities;
public class Formation 
{
    [XmlArray("coaches")]
    [XmlArrayItem("coach")]
    public List<Coach> Coaches {get; set;} = [];

}
