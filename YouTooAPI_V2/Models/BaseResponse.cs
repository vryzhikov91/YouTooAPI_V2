using System.Collections.Generic;

namespace YouTooAPI_V2.Models
{
    public class BaseResponse
    {
        /// <summary>
        /// Error list, must be empty
        /// </summary>
        public  List<string> Errors { get; set; }
        /// <summary>
        /// Data dto or list dto
        /// </summary>
        public object Data { get; set; }

    }
}