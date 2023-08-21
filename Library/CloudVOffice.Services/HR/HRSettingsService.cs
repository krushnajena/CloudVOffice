using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR;
using CloudVOffice.Data.DTO.HR;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.HR
{
    public class HRSettingsService : IHRSettingsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<HRSettings> _hrSettingsRepo;
        public HRSettingsService(ApplicationDBContext Context, ISqlRepository<HRSettings> hrSettingsRepo)
        {
            _Context = Context;
            _hrSettingsRepo = hrSettingsRepo;
        }
        public HRSettingsDTO GetHrSettings()
        {
            try
            {
                HRSettingsDTO d = new HRSettingsDTO();

                HRSettings h = _Context.HRSettings.FirstOrDefault();

                d.HRSettingsId = h.HRSettingsId;
                d.StandardWorkingHours = h.StandardWorkingHours;
                d.BreakHours = h.BreakHours;
                d.RetirementAge = h.RetirementAge;
                d.SendBirthdaysReminder = h.SendBirthdaysReminder;
                d.SendWorkAnniversariesReminder = h.SendWorkAnniversariesReminder;
                d.SendInterviewReminder = h.SendInterviewReminder;
                d.SendInterviewFeedbackReminder = h.SendInterviewFeedbackReminder;
                return d;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum HRSettingsUpdate(HRSettingsDTO hrSettingsDTO)
        {
            try
            {

                var a = _Context.HRSettings.Where(x => x.HRSettingsId == hrSettingsDTO.HRSettingsId).FirstOrDefault();
                if (a != null)
                {

                    a.StandardWorkingHours = hrSettingsDTO.StandardWorkingHours;
                    a.BreakHours = hrSettingsDTO.BreakHours;
                    a.RetirementAge = hrSettingsDTO.RetirementAge;
                    a.SendBirthdaysReminder = hrSettingsDTO.SendBirthdaysReminder;
                    a.SendWorkAnniversariesReminder = hrSettingsDTO.SendWorkAnniversariesReminder;
                    a.SendInterviewReminder = hrSettingsDTO.SendInterviewReminder;
                    a.SendInterviewFeedbackReminder = hrSettingsDTO.SendInterviewFeedbackReminder;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Updated;
                }
                else
                    return MessageEnum.Invalid;

            }
            catch
            {
                throw;
            }
        }

    }
}
