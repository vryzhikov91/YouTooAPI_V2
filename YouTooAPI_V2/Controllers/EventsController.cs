using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        public EventsController()
        {
        }

        /// <summary>
        /// Get event by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet("{eventId}")]
        public IEnumerable<BaseResponse<EventOutputModel>> Get(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete event by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{eventId:int}")]
        public IEnumerable<IActionResult> Delete(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All events
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet]
        public IEnumerable<BaseResponseList<EventOutputModel>> Get([FromBody] BaseRequest<EventFilter> request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update event information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Event ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<BaseResponse<EventOutputModel>> Update([FromBody] EventInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create event 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Event ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<BaseResponse<int>> Create([FromBody] EventInputModel model)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get All questions
        /// </summary>
        /// <returns>Base response with Question output model</returns>
        [HttpGet("{eventId:int}/Questions")]
        public IEnumerable<BaseResponseList<EventQuestionOutput>> GetQuestion(int eventId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create question 
        /// </summary>
        /// <param name="eventId">Event Id</param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost("{eventId:int}/Questions")]
        public Task<BaseResponse<int>> Create(int eventId, [FromBody] EventQuestionInput model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Answer on question 
        /// </summary>
        /// <param name="eventId">Event Id</param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut("{eventId:int}/Questions")]
        public Task<BaseResponse<int>> Update(int eventId, [FromBody] EventQuestionInput model)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Get All Attendees
        /// </summary>
        /// <returns>Base response with Question output model</returns>
        [HttpGet("{eventId:int}/Attendees")]
        public IEnumerable<BaseResponseList<EventQuestionOutput>> GetAttendees(int eventId)
        {
            throw new NotImplementedException();
        }
    }

    public class EventFilter
    {
        public int GroupId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool? IsActive { get; set; }
    }



    public class EventQuestionInput
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class EventQuestionOutput
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
    /// Base event input model
    /// </summary>
    public class EventInputModel
    {
        public int? EventId { get; set; }
        public int? GroupId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string PhotoId { get; set; }
        public bool IsActive { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EventOutputModel
    {
        public int? EventId { get; set; }
        public int? GroupId { get; set; }
        public int PhotoId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsActive { get; set; }
    }
}