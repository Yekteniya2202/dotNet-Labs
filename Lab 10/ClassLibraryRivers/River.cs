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
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Протяженность
        /// </summary>
        public double Length { get; set; } = double.NaN;

        /// <summary>
        /// Дата открытия
        /// </summary>
        public DateTime FoundationDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Число притоков
        /// </summary>
        public int TributaryCount { get; set; } = -1;

        public bool IsValid()
        {
            return 
                string.IsNullOrWhiteSpace(Title) == false &&
                Length != double.NaN &&
                FoundationDate != DateTime.MinValue &&
                TributaryCount != -1;
        }

        public override string ToString()
        {
            return $"Название - {Title}. Протяженность - {Length}. Дата открытия - {FoundationDate}. Число притоков - {TributaryCount}";
        }
    }
}
