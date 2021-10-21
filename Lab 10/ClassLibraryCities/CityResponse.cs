namespace ClassLibraryCities
{
    /// <summary>
    /// Ответ от справочника городов
    /// </summary>
    public class CityResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }
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
