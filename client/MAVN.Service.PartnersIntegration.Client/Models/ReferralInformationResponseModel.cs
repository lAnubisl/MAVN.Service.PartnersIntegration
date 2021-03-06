using System.Collections.Generic;
using MAVN.Service.PartnersIntegration.Client.Enums;

namespace MAVN.Service.PartnersIntegration.Client.Models
{
    /// <summary>
    /// Represents a model response with referral information
    /// </summary>
    public class ReferralInformationResponseModel
    {
        /// <summary>
        /// Represents the status of the information retrieval
        /// </summary>
        public ReferralInformationStatus Status { get; set; }

        /// <summary>
        /// Represents the referrals if retrieval was successful
        /// </summary>
        public List<ReferralModel> Referrals { get; set; }
    }
}
