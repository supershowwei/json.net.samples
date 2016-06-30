namespace JsonNetSamples.Data
{
    /// <summary>
    /// 短文字欄位
    /// </summary>
    /// <seealso cref="JsonNetSamples.Data.Field" />
    public class ShortTextField : Field
    {
        /// <summary>
        /// 預設值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 寬度；單位請自訂，pixel、pt 請隨意，但是若是 -1 就代表滿版。
        /// </summary>
        public int Width { get; set; }
    }
}
