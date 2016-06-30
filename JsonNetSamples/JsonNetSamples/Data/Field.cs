using System;

namespace JsonNetSamples.Data
{
    /// <summary>
    /// 表格的欄位
    /// </summary>
    public abstract class Field
    {
        /// <summary>
        /// 識別代碼
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 表格的識別代碼
        /// </summary>
        public Guid FormId { get; set; }

        /// <summary>
        /// 欄位類型
        /// </summary>
        public FieldType Type { get; set; }

        /// <summary>
        /// 欄位名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否為必填欄位
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// 顯示順序
        /// </summary>
        public int Sequence { get; set; }
    }
}