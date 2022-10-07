namespace EinzelaufageB.Model
{
    public class Journey
    {
        public List<Logbook> Journeys { get; set; } = new List<Logbook>();
        public int DistanceTotal { get; set; } = 0;
    }
}
