using AutoMapper;
using Sinav.Core.Concretes;
using Sinav.DAL.Repositories.Interfaces;
using Sinav.Service.DTOs.TopicDTOs;
using Sinav.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Service.Services.Concretes
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository topicRepository;
        private readonly IMapper mapper;

        public TopicService(ITopicRepository topicRepository, IMapper mapper)
        {
            this.topicRepository = topicRepository;
            this.mapper = mapper;
        }

        public bool CreateTopic(CreateTopicDTO topicDTO)
        {
            Topic topic = mapper.Map<Topic>(topicDTO);

            return topicRepository.Add(topic);
        }

        public bool DeleteTopic(int id)
        {
            return topicRepository.Delete(topicRepository.GetById(id));
        }

        public List<UpdateTopicDTO> GetAllTopic()
        {
            List<Topic> topics = topicRepository.GetAll().ToList();

            List<UpdateTopicDTO> dtoTopics = mapper.Map<List<Topic>,List<UpdateTopicDTO>>(topics);
            return dtoTopics;
        }

        public UpdateTopicDTO GetTopic(int id)
        {
            Topic topic = topicRepository.GetById(id);

            UpdateTopicDTO topicDTO = mapper.Map<UpdateTopicDTO>(topic);

            return topicDTO;
        }

        public bool UpdateTopic(UpdateTopicDTO topicDTO)
        {
            Topic topic = mapper.Map<Topic>(topicDTO);
            return topicRepository.Update(topic);
        }
    }
}
