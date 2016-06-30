using System.Collections.Generic;

namespace JsonNetSamples.Data
{
    /// <summary>
    /// 勾選的欄位
    /// </summary>
    /// <seealso cref="JsonNetSamples.Data.Field" />
    public class CheckField : Field
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
