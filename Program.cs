using TrainDepartureBoard;
using TrainDepartureBoard.Entities;

string departureStationCode = "COL";
string destinationStationCode = "LST";

LdbwsClient client = new LdbwsClient("72a8196c-6306-4f02-8194-6225e3eee456");

GetDepBoardWithDetailsResponse response = await client.GetDepBoardWithDetails(2, departureStationCode, 120, destinationStationCode);

Console.WriteLine($"Station Board for: {response.StationBoardWithDetails.LocationName}({response.StationBoardWithDetails.Crs})");
Console.WriteLine($"For Services to: {response.StationBoardWithDetails.FilterLocationName}({response.StationBoardWithDetails.FilterCrs})");
Console.WriteLine($"Platform available: {response.StationBoardWithDetails.PlatformAvailable}");
Console.WriteLine($"Generated at:{response.StationBoardWithDetails.GeneratedAt}");

foreach(string message in response.StationBoardWithDetails.NrccMessages)
{
   Console.WriteLine($"{message}");
}

Console.WriteLine($"\nServices leaving {response.StationBoardWithDetails.LocationName} are:\n");

List<Service> services = response.StationBoardWithDetails.TrainServices;

foreach (Service service in services)
{

   Console.WriteLine($"Platform: {service.Platform}");
   Console.WriteLine($"{service.Std} - {service.Destination.Location.LocationName} {service.Etd}");
   Console.WriteLine($"From: {service.Origin.Location.LocationName}");
   Console.WriteLine($"Operator: {service.Operator} ({service.OperatorCode})");
   Console.WriteLine($"{service.ServiceType}");
   Console.WriteLine($"{service.ServiceId}");

   Console.WriteLine($"Carriages: {service.Length}");
   Console.WriteLine($"Train Formation:");
   

   foreach(Coach coach in service.Formation.Coaches)
   {
      Console.WriteLine($"{coach.Number} = {coach.CoachClass} {coach.Toilet}");
   }

   


   Console.WriteLine($"Calling at:");

   foreach (CallingPoint callingPoint in service.SubsequentCallingPoints.CallingPoints)
   {
      Console.WriteLine($"-{callingPoint.LocationName}({callingPoint.Crs}), {callingPoint.St} - {callingPoint.Et}");
   }
   Console.WriteLine($"************");
}