namespace RailwayReservationSystem
{
    public interface IReservation
    {
        public void BookTicket();
        public void CancelTicket();
        public void ViewTicket();
    }
}