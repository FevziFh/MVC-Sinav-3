using Sinav.Service.DTOs.ArticleDTOs;
using Sinav.Service.DTOs.TopicDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.Interfaces
{
    public interface ITopicService
    {
        public bool CreateTopic(CreateTopicDTO topicDTO);
        public bool UpdateTopic(UpdateTopicDTO topicDTO);
        public bool DeleteTopic(int id);
        public UpdateTopicDTO GetTopic(int id);
        public List<UpdateTopicDTO> GetAllTopic();
    }
}
