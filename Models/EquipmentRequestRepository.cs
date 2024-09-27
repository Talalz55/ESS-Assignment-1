namespace Assignment_1.Models
{
    public static class EquipmentRequestRepository
    {
        private static List<EquipmentRequest> requests = new List<EquipmentRequest>();
        private static int currentId = 1;

        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = currentId++;
            requests.Add(request);
        }

        public static IEnumerable<EquipmentRequest> GetAllRequests()
        {
            return requests;
        }
    }
}
