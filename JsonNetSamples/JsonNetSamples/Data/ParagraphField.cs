namespace JsonNetSamples.Data
{
    /// <summary>
    /// 段落欄位
    /// </summary>
    /// <seealso cref="JsonNetSamples.Data.Field" />
    public class ParagraphField : Field
    {
        /// <summary>
        /// 預設值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 高度；單位請自訂，pixel、pt 請隨意，但是若是 -1 就代表滿版。
        /// </summary>
        public int Height { get; set; }
    }
}
