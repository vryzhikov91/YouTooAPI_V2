﻿using System.Collections.Generic;

namespace YouTooAPI_V2.Models
{
    public class BaseResponse<T>
    {
        /// <summary>
        /// Error list, must be empty
        /// </summary>
        public  List<string> Errors { get; set; }
        /// <summary>
        /// Data dto or list dto
        /// </summary>
        public T Data { get; set; }
        
    }
}