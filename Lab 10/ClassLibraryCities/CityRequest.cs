namespace ClassLibraryCities
{
    /// <summary>
    /// Запрос к справочнику городов
    /// </summary>
    public class CityRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public CityRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о городе
        /// </summary>
        public City City { get; set; }
    }
}