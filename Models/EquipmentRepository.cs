namespace Assignment_1.Models
{
    public static class EquipmentRepository
    {
        private static List<Equipment> equipmentList = new List<Equipment>
        {
            new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "MacBook Pro 2022", IsAvailable = true },
            new Equipment { Id = 2, Type = EquipmentType.Phone, Description = "iPhone 15 Pro", IsAvailable = false },
            new Equipment { Id = 3, Type = EquipmentType.Tablet, Description = "iPad Air", IsAvailable = true }
        };

        public static IEnumerable<Equipment> GetAllEquipment()
        {
            return equipmentList;
        }

        public static IEnumerable<Equipment> GetAvailableEquipment()
        {
            return equipmentList.Where(i => i.IsAvailable);
        }
    }
}
