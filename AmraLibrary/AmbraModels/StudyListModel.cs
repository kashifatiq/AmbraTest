// -----------------------------------------------------------------------
// <copyright file="StudyListModel.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class StudyListModel
    {
        public string HTTP_STATUS_CODE { get; set; }
        public int more { get; set; }
        public string status { get; set; }
        public List<Study> studies { get; set; }
        public PageModel page { get; set; }
    }
}
