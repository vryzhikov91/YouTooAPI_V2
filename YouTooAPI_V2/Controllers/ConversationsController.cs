using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouTooAPI_V2.Models;

namespace YouTooAPI_V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversationsController : ControllerBase
    {
        public ConversationsController()
        {
        }

        /// <summary>
        /// Get conversation by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet("{conversationId:int}")]
        public IEnumerable<BaseResponseList<ConversationOutputModel>> Get(int conversationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete conversation by id
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpDelete("{conversationId:int}")]
        public IEnumerable<IActionResult> Delete(int conversationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All conversations
        /// </summary>
        /// <returns>Base response dto</returns>
        [HttpGet]
        public IEnumerable<BaseResponse<ConversationOutputModel>> Get()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update conversation information
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Conversation ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public Task<IActionResult> Update([FromBody] ConversationInputModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Conversation ID</returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public Task<IActionResult> Create([FromBody] ConversationInputModel model)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Base conversation input model
    /// </summary>
    public class ConversationInputModel
    {
        public int? ConversationId { get; set; }
        public int? GroupId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAdministrative { get; set; }
        public DateTime MutedTo { get; set; }
        public ConversationStatus ConversationStatus { get; set; }
        public bool IsPined { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ConversationOutputModel
    {
        public int? ConversationId { get; set; }
        public int? GroupId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAdministrative { get; set; }
        public DateTime MutedTo { get; set; }
        public ConversationStatus ConversationStatus { get; set; }
        public bool IsPined { get; set; }
    }

    public enum ConversationStatus
    {
        Muted,
        UnMuted

        //TODO: what other statuses are needed? can make bool value
    }
}