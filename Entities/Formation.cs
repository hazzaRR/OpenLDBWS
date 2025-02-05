using System.Xml.Serialization;
namespace TrainDepartureBoard.Entities;
public class Formation 
{

    [XmlArray("coaches")]
    public List<Coach> Coaches {get; set;} = [];

}
