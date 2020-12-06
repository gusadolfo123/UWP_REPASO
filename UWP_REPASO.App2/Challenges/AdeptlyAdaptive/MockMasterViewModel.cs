using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_REPASO.App2.Challenges.AdeptlyAdaptive.Models;

namespace UWP_REPASO.App2.Challenges.AdeptlyAdaptive
{
    public class MockMasterViewModel
    {
        public ObservableCollection<Notice> Notices;

        public MockMasterViewModel()
        {
            this.Notices = new ObservableCollection<Notice>
            {
                new Notice { NoticeId = 1, Title = "Titulo 1", SubTitle = "Sub Titulo 1", Description = "Descripcion 1", ImageSource = "/Assets/AdeptlyAdaptive/Financial1.png" },
                new Notice { NoticeId = 2, Title = "Titulo 2", SubTitle = "Sub Titulo 2", Description = "Descripcion 2", ImageSource = "/Assets/AdeptlyAdaptive/Financial2.png" },
                new Notice { NoticeId = 3, Title = "Titulo 3", SubTitle = "Sub Titulo 3", Description = "Descripcion 3", ImageSource = "/Assets/AdeptlyAdaptive/Financial3.png" },
                new Notice { NoticeId = 4, Title = "Titulo 4", SubTitle = "Sub Titulo 4", Description = "Descripcion 4", ImageSource = "/Assets/AdeptlyAdaptive/Financial4.png" },
                new Notice { NoticeId = 5, Title = "Titulo 5", SubTitle = "Sub Titulo 5", Description = "Descripcion 5", ImageSource = "/Assets/AdeptlyAdaptive/Financial5.png" }
            };
        }

    }
}
