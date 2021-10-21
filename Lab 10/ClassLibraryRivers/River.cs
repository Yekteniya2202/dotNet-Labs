using System;

namespace ClassLibraryRivers
{
    /// <summary>
    /// Река
    /// </summary>
    [Serializable]
    public class River
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Протяженность
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Дата открытия
        /// </summary>
        public DateTime FoundationDate { get; set; }

        /// <summary>
        /// Число притоков
        /// </summary>
        public int TributaryCount { get; set; }
    }
}
