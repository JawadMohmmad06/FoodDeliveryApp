using Finalv1BLL.ModelDTOs;
using Finalv1DAL.Repos;
using Finalv1DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finalv1DAL.Models;

namespace Finalv1BLL.Services
{
    public class FeedBackService
    {
        public static List<FeedBackDTO> Get()
        {
            var feedbacks = DataAccessFactory.FeedbackData().Get();
            var dto = new List<FeedBackDTO>();
            foreach (var i in feedbacks)
            {
                dto.Add(new FeedBackDTO()
                {
                    Id= i.Id,
                    UId= i.UId,
                    Subject= i.Subject, 
                    Body= i.Body,

                });
            }
            return dto;
        }
        public static FeedBackDTO GetById(int id)
        {
            var feedBack = DataAccessFactory.FeedbackData().Get(id);

            if (feedBack != null)
            {
                var dto = new FeedBackDTO()
                {
                   Id=id,
                   UId= feedBack.UId,
                   Subject= feedBack.Subject,
                   Body= feedBack.Body,
                };
                return dto;
            }
            return null;
        }
        public static bool Update(FeedBackDTO feedback)
        {
            var feedbackmodel = new FeedBack();
            feedbackmodel.Id= feedback.Id;
            feedbackmodel.UId= feedback.UId;
            feedbackmodel.Subject= feedback.Subject;
            feedbackmodel.Body= feedback.Body;
            return DataAccessFactory.FeedbackData().Update(feedbackmodel);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.FeedbackData().Delete(id);
        }
        public static List<FeedBackDTO> GetBySubject(string subject)
        {
            var feedbacks = Get();
            var getfeedback=(from i in feedbacks
                             where i.Subject.Contains(subject)
                             select i).ToList();
            var dto=new List<FeedBackDTO>();
            foreach (var i in getfeedback)
            {
                dto.Add(new FeedBackDTO()
                {
                    Id = i.Id,
                    UId = i.UId,
                    Subject = i.Subject,
                    Body = i.Body,

                });
            }
            if (getfeedback != null)
            {
                return dto;
            }
            return null;

        }
        public static List<FeedBackDTO> GetByBody(string body)
        {
            var feedbacks = Get();
            var getfeedback = (from i in feedbacks
                               where i.Body.Contains(body)
                               select i).ToList();
            var dto = new List<FeedBackDTO>();
            foreach (var i in getfeedback)
            {
                dto.Add(new FeedBackDTO()
                {
                    Id = i.Id,
                    UId = i.UId,
                    Subject = i.Subject,
                    Body = i.Body,

                });
            }
            if (getfeedback != null)
            {
                return dto;
            }
            return null;

        }
        public static bool Create(FeedBackDTO feedBackDTO)
        {
            var feedbackmodel = new FeedBack();
            feedbackmodel.UId=feedBackDTO.UId;
            feedBackDTO.Subject = feedbackmodel.Subject;
            feedBackDTO.Body = feedbackmodel.Body;
            return DataAccessFactory.FeedbackData().Create(feedbackmodel);

        }
    }
}
