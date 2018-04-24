namespace Sitecore.Support.EmailCampaign.Cm.Dispatch
{
  using System.Collections.Generic;

  using Sitecore.EmailCampaign.Cm.Dispatch;
  using Sitecore.EmailCampaign.Cm.Managers;
  using Sitecore.ExM.Framework.Distributed.Tasks.TaskPools.ShortRunning;
  using Sitecore.Modules.EmailCampaign.Core;
  using Sitecore.Modules.EmailCampaign.Core.Contacts;
  using Sitecore.Modules.EmailCampaign.Core.Data;
  using Sitecore.Modules.EmailCampaign.Core.Dispatch;
  using Sitecore.Modules.EmailCampaign.Core.Pipelines.HandleMessageEventBase;
  using Sitecore.Modules.EmailCampaign.Factories;
  using Sitecore.XConnect;
  using Sitecore.XConnect.Operations;

  [UsedImplicitly]
  public class DispatchTask : Sitecore.EmailCampaign.Cm.Dispatch.DispatchTask
  {
    public DispatchTask(
      ShortRunningTaskPool taskPool,
      IRecipientValidator recipientValidator, 
      IContactService contactService,
      EcmDataProvider dataProvider,
      ItemUtilExt itemUtil, 
      IEventDataService eventDataService, 
      IDispatchManager dispatchManager, 
      EmailAddressHistoryManager emailAddressHistoryManager, 
      IRecipientManagerFactory recipientManagerFactory,
      SentMessageManager sentMessageManager) 
      : base(
        taskPool, 
        recipientValidator, 
        contactService, 
        dataProvider, 
        itemUtil, 
        eventDataService,
        dispatchManager,
        emailAddressHistoryManager,
        recipientManagerFactory,
        sentMessageManager)
    {
    }

    protected override IReadOnlyCollection<IEntityLookupResult<Contact>> GetContacts(List<DispatchQueueItem> dispatchQueueItems)
    {
      var contacts = base.GetContacts(dispatchQueueItems);

      return contacts;
    }
  }
}