using System.Collections.Generic;

namespace JsonNetSamples.Data
{
    /// <summary>
    /// 單選的欄位
    /// </summary>
    /// <seealso cref="JsonNetSamples.Data.Field" />
    public class RadioField : Field
    {
        /// <summary>
        /// 選項
        /// </summary>
        public List<FieldOption> Options { get; set; }

        /// <summary>
        /// 預設值
        /// </summary>
        public int DefaultValue { get; set; }
    }
}
