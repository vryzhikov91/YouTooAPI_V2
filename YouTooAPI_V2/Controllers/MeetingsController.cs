using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingsController : ControllerBase
    {
        public MeetingsController()
        {
        }

        /// <summary>
        /// Get meeting by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet("{meetingId}")]
        public IEnumerable<BaseResponse<MeetingOutputModel>> Get(int meetingId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete meeting by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{meetingId:int}")]
        public IEnumerable<IActionResult> Delete(int meetingId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update meeting information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Meeting ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<IActionResult> Update([FromBody] MeetingInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create meeting 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Meeting ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<IActionResult> Create([FromBody] MeetingInputModel model)
        {
            throw new NotImplementedException();
        }
    }

    public class MeetingQuestionInput
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class MeetingQuestionOutput
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        /// <summary>
        /// user Id
        /// </summary>
        public int AskedBy { get; set; }

        /// <summary>
        /// user id
        /// </summary>
        public int AnsweredBy { get; set; }
    }

    /// <summary>
    /// Base meeting input model
    /// </summary>
    public class MeetingInputModel
    {
        public int? MeetingId { get; set; }
        public int EventId { get; set; }

        public string Title { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MeetingOutputModel
    {
        public int? MeetingId { get; set; }
        public int? EventId { get; set; }
        public Uri MeetingJoinUrl { get; set; }
        public Uri MeetingStartUrl { get; set; }
    }
}