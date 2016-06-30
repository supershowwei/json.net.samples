using System.Collections.Generic;

namespace JsonNetSamples.Data
{
    /// <summary>
    /// 下拉式選單欄位
    /// </summary>
    /// <seealso cref="JsonNetSamples.Data.Field" />
    public class DropDownField : Field
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
