using System;

namespace ClassLibraryCities
{
    /// <summary>
    /// Город
    /// </summary>
    public class City
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Население
        /// </summary>
        public int Population { get; set; }

        /// <summary>
        /// Дата основания
        /// </summary>
        public DateTime FoundationDate { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }
    }
}