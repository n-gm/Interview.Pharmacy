namespace Interview.Pharmacy.Database.Models
{
    /// <summary>
    /// Аптека
    /// </summary>
    public class Pharmacy
    {
        public int Id { get; set; }
        /// <summary>
        /// Имя аптеки
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание аптеки
        /// </summary>
        public string Description { get; set; }
    }
}
