using Core.Configurations.CloudinaryConfiguration.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class TransCarePhotoReturnDto:PhotoForReturnDto
    {
        public int TransCareId { get; set; }
    }
}
