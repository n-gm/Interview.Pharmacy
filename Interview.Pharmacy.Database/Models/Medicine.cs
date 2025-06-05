namespace Interview.Pharmacy.Database.Models
{
    /// <summary>
    /// Тип лекарства
    /// </summary>
    public enum MedicineType
    {
        Heart,
        Brain,
        Kidney
    }

    /// <summary>
    /// Лекарство
    /// </summary>
    public class Medicine
    {
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор аптеки
        /// </summary>
        public int PharmacyId { get; set; }
        /// <summary>
        /// Тип лекарства
        /// </summary>
        public MedicineType Type { get; set; }
        /// <summary>
        /// Имя лекарства
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание лекарства
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Доступность к продаже
        /// </summary>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// Дата ожидаемой поставки
        /// </summary>
        public DateTime ExpectedAt { get; set; }
        /// <summary>
        /// Доступное количество
        /// </summary>
        public int Count { get; set; }
    }
}
